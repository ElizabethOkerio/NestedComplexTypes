using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.OData;
using ProductService.Models;

namespace ProductService.Controllers
{
    public class ProductEntityController :ODataController
    {
        [EnableQuery]
        public IHttpActionResult Get()
        {
            return Ok(DataSource.Instance.ProductEntities.AsQueryable());
        }
        
        public IHttpActionResult Post(ProductEntity productEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DataSource.Instance.ProductEntities.Add(productEntity);
            return Created(productEntity);
        }
        [HttpPost]
        public IHttpActionResult Rate(int key)
        {
            List<Product> prod = new List<Product>();
            prod.Add(
                new ProductA
                {
                    Name = "sjhfs",
                    Category = "fhDGDG",
                    Price = 120.00,
                    DetailsA = "yuyu"
                }
            );
          
            return Ok(prod);
        }
    }
}
