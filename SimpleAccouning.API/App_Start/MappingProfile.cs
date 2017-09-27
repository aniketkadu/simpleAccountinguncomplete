using AutoMapper;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleAccounting.Model.Model;

namespace SimpleAccouning.API.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountingCompanyDetail, AccountingCompanyDetailDtos>();
            CreateMap<AccountingCompanyDetailDtos, AccountingCompanyDetail>();

            CreateMap<AccountingCustomer, AccountingCustomerDtos>();
            CreateMap<AccountingCustomerDtos, AccountingCustomer>();

            CreateMap<AccountingLogin, AccountingLoginDtos>();
            CreateMap<AccountingLoginDtos, AccountingLogin>();

            CreateMap<AccountingOption, AccountingOptionDtos>();
            CreateMap<AccountingOptionDtos, AccountingOption>();

            CreateMap<AccountingProduct, AccountingProductDtos>();
            CreateMap<AccountingProductDtos, AccountingProduct>();

            CreateMap<AccountingPurchaseInvoice, AccountingPurchaseInvoiceDtos>();
            CreateMap<AccountingPurchaseInvoiceDtos, AccountingPurchaseInvoice>();

            CreateMap<AccountingPurchaseInvoiceDetail, AccountingPurchaseInvoiceDetailDtos>();
            CreateMap<AccountingPurchaseInvoiceDetailDtos, AccountingPurchaseInvoiceDetail>();

            CreateMap<AccountingPurchaseOrder, AccountingPurchaseOrderDtos>();
            CreateMap<AccountingPurchaseOrderDtos, AccountingPurchaseOrder>();

            CreateMap<AccountingPurchaseOrderDetail, AccountingPurchaseOrderDetailDtos>();
            CreateMap<AccountingPurchaseOrderDetailDtos, AccountingPurchaseOrderDetail>();

            CreateMap<AccountingSalesInvoice, AccountingSalesInvoiceDtos>();
            CreateMap<AccountingSalesInvoiceDtos, AccountingSalesInvoice>();

            CreateMap<AccountingSalesInvoiceDetail, AccountingSalesInvoiceDetailDtos>();
            CreateMap<AccountingSalesInvoiceDetailDtos, AccountingSalesInvoiceDetail>();

            CreateMap<AccountingSalesOrder, AccountingSalesOrderDtos>();
            CreateMap<AccountingSalesOrderDtos, AccountingSalesOrder>();

            CreateMap<AccountingSalesOrderDetail, AccountingSalesOrderDetailDtos>();
            CreateMap<AccountingSalesOrderDetailDtos, AccountingSalesOrderDetail>();

            CreateMap<AccountingSupplier, AccountingSupplierDtos>();
            CreateMap<AccountingSupplierDtos, AccountingSupplier>();

        }
    }
}