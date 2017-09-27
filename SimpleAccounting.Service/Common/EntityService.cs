using SimpleAccounting.Model;
using SimpleAccounting.Repository;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service.Common
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {

        IUnitOfWork _unitOfWork;
        IRepositoryBase<T> _repository;
        private IUnitOfWork unitOfWork;
        private IAccountingCompanyDetailRepository countryRepository;
     //   private IAccountingCustomerService countryRepository1;
      //  private IAccountingOptionService countryRepository2;

        public EntityService(IUnitOfWork unitOfWork, IRepositoryBase<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public EntityService(IUnitOfWork unitOfWork, IAccountingCompanyDetailRepository countryRepository)
        {
            this.unitOfWork = unitOfWork;
            this.countryRepository = countryRepository;
        }

        //public EntityService(IUnitOfWork unitOfWork, IAccountingCustomerService countryRepository1)
        //{
        //    this.unitOfWork = unitOfWork;
        //    this.countryRepository1 = countryRepository1;
        //}

        //public EntityService(IUnitOfWork unitOfWork, IAccountingOptionService countryRepository2)
        //{
        //    this.unitOfWork = unitOfWork;
        //    this.countryRepository2 = countryRepository2;
        //}

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);
            _unitOfWork.Commit();

        }


        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Update(entity);
            _unitOfWork.Commit();

        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
              _unitOfWork.Commit();
       
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
