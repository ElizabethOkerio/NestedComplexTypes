using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProductService.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
namespace NestedComplexTypes
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<ProductEntity>("ProductEntity");
            builder.ComplexType<Product>();
            builder.Namespace = "ProductService";
            builder.EntityType<ProductEntity>()
                .Action("Rate")
                .ReturnsCollection<Product>();

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }
    }
}
