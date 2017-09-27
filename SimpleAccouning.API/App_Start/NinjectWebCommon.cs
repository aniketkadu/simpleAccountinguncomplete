[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SimpleAccouning.API.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SimpleAccouning.API.App_Start.NinjectWebCommon), "Stop")]

namespace SimpleAccouning.API.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.WebApi;
    using System.Web.Http;
    using SimpleAccounting.Service;
    using SimpleAccounting.Repository;
    using SimpleAccounting.Model;
    using SimpleAccounting.Repository.Infrastructure;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));

                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);

                RegisterServices(kernel);

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
          //  GenericRepository
            kernel.Bind<IAccountingCompanyDetailService>().To<AccountingCompanyDetailService>();

            kernel.Bind<IAccountingCompanyDetailRepository>().To<AccountingCompanyDetailRepository>().InRequestScope();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            kernel.Bind<ISimpleAccountingContext>().To<SimpleAccountingContext>().InRequestScope();
            kernel.Bind<SimpleAccountingContext>().To<SimpleAccounting.Repository.SimpleAccountingContext>();
        // kernel.Bind< SimpleAccounting.Service.Common.IEntityServiceBaseEntity<>().To<SimpleAccounting.Service.Common.EntityService<>;
        }
    }
}
