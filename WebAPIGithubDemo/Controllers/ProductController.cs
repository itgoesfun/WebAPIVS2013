using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIGithubDemo.Models;

namespace WebAPIGithubDemo.Controllers
{
    public class ProductController : ApiController
    {
        //since no database create dummy data here
        private List<Product> products = new List<Product>()
        {
            new Product{ ProductId = 1, ProductName= "T Shirt", ProductPrice= 26.5m, ProductQuantity= 5  },
            new Product{ ProductId = 2, ProductName= "T Shirt 2", ProductPrice= 12.5m, ProductQuantity= 2  }
        };

    public IEnumerable<Product> Get()
        {
            return products.ToList();
        }

    public IHttpActionResult Get(int id)
        {
            var product = products.Where(x => x.ProductId== id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
            
        }
    }
}
