using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PhoneStore.Model.Catalog;
using PhoneStore.Web.ViewModels;
using PhoneStore.Web.Models;


using PhoneStore.Model.Discounts;
using PhoneStore.Model.Customers;


namespace PhoneStore.Web.Extensions
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination> (this TSource source)
        {
            Mapper.CreateMap<TSource, TDestination>();
            return Mapper.Map<TSource, TDestination>(source);
        }


        #region Product
        public static ProductIndexModel ToVM(this Product entity)
        {
            return entity.MapTo<Product, ProductIndexModel>(); 
        }
        #endregion

        #region User 
        
        public static User ToEntity(this RegisterViewModel vm)
        {
            return vm.MapTo<RegisterViewModel, User>(); 
        }
        #endregion


    }
}