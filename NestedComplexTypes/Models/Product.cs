using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public abstract class Product
    {
      //  public string Name { get; set; }
     
    
    }
    public class ProductA : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string DetailsA { get; set; }
       
    }
    public class ProductB : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string DetailsB { get; set; }
    }
    ////public class Configuration
    ////{
    ////    public Product Product { get; set; }
    ////}
    public class ProductEntity
    {
        public int Id { get; set; }
        public Product Product { get; set; }
       // public Configuration Configuration { get; set; }
    }
}