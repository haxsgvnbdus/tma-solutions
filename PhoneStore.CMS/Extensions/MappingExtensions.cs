using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PhoneStore.Model.Catalog;
using PhoneStore.CMS.ViewModels;
using PhoneStore.Model.Discounts;
using PhoneStore.Model.Media;


namespace PhoneStore.CMS.Extensions
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination> (this TSource source)
        {
            Mapper.CreateMap<TSource, TDestination>();
            return Mapper.Map<TSource, TDestination>(source);
        }

        #region Category
        public static Category ToEntity(this CreateCategorySpec vm)
        {
            return vm.MapTo<CreateCategorySpec , Category>(); 
        }
        
        public static CreateCategorySpec ToVM (this Category entity)
        {
            return entity.MapTo<Category, CreateCategorySpec>();
        }

        public static IndexCategorySpec ToVMIndex (this Category entity)
        {
            return entity.MapTo<Category, IndexCategorySpec>();
        }
       
        #endregion

        #region Manufacturer 
        public static Manufacturer ToEntity(this CreateManufacturerSpec vm)
        {
            return vm.MapTo<CreateManufacturerSpec, Manufacturer>();
        }

        public static CreateManufacturerSpec ToVM(this Manufacturer entity)
        {
            return entity.MapTo<Manufacturer, CreateManufacturerSpec>(); 
        }
        #endregion

        #region Product 
        public static Product ToEntity(this CreateProductSpec vm)
        {
            return vm.MapTo<CreateProductSpec, Product>();
        }

        public static CreateProductSpec ToVM(this Product entity)
        {
            return entity.MapTo<Product, CreateProductSpec>(); 
        }   
        
        public static IndexProductSpec ToVMIndex (this Product entity)
        {
            return entity.MapTo<Product, IndexProductSpec>();
        }

        public static DetailProductSpec ToVMDetail (this Product entity)
        {
            return entity.MapTo<Product, DetailProductSpec>(); 
        }

        #endregion

        #region Discount
        public static Discount ToEntity(this CreateDiscountSpec vm)
        {
            return vm.MapTo<CreateDiscountSpec, Discount>();
        }

        public static CreateDiscountSpec ToVM(this Discount entity)
        {
            return entity.MapTo<Discount, CreateDiscountSpec>(); 
        }
        #endregion

        #region Picture
        public static Picture ToEntity(this CreatePictureSpec vm)
        {
            return vm.MapTo<CreatePictureSpec, Picture>();
        }

        public static CreatePictureSpec ToVM(this Picture entity)
        {
            return entity.MapTo<Picture, CreatePictureSpec>();
        }

        #endregion

        #region Tag 
        public static ProductTag ToEntity(this CreateTagSpec entity)
        {
            return entity.MapTo<CreateTagSpec, ProductTag>();
        }

        public static CreateTagSpec ToVM(this ProductTag vm)
        {
            return vm.MapTo<ProductTag, CreateTagSpec>(); 
        }
        #endregion 

        
    }
}