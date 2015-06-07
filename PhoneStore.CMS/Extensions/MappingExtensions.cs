using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PhoneStore.Model.Catalog;
using PhoneStore.CMS.ViewModels;
using PhoneStore.Model.Discounts;
using PhoneStore.Model.Media;
using PhoneStore.CMS.Extensions;

namespace PhoneStore.CMS.Extensions
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination> (this TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        #region Category
        public static Category ToEntity(this CreateCategorySpec entity)
        {
            return entity.MapTo<CreateCategorySpec , Category>(); 
        }
        #endregion

        #region Manufacturer 
        public static Manufacturer ToEntity(this CreateManufacturerSpec entity)
        {
            return entity.MapTo<CreateManufacturerSpec, Manufacturer>();
        }
        #endregion

        #region Product 
        public static Product ToEntity(this CreateProductSpec entity)
        {
            return entity.MapTo<CreateProductSpec, Product>();
        }
        #endregion

        #region Discount
        public static Discount ToEntity(this CreateDiscountSpec entity)
        {
            return entity.MapTo<CreateDiscountSpec, Discount>();
        }
        #endregion

        #region Picture
        public static Picture ToEntity(this CreatePictureSpec entity)
        {
            return entity.MapTo<CreatePictureSpec, Picture>();
        }
        #endregion

        #region Tag 
        public static Tag ToEntity(this CreateTagSpec entity)
        {
            return entity.MapTo<CreateTagSpec, Tag>();
        }
        #endregion 
    }
}