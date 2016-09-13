using Backend.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.WebApi.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : ApiController
    {

        //Products
        private Product[] products = new Product[]
        {
            new Product() { Id = 1, Name = "Grus", Category = "Kedelige ting", Price = 45.00M },
            new Product() { Id =2, Name = "Glass", Category = "Plastik", Price = 12.00M },
            new Product() { Id =3, Name = "Kasse", Category = "Karton", Price = 15.00M }
        };

        [Route("")]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [Route("{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }           
        }

        //Reviews
        private Review[] reviews = new Review[]
           {
            new Review() { Id = 1, ProductId = 1, Rating = 1, Text = "" },
            new Review() { Id =2, ProductId = 2, Rating = 1, Text = "" },
            new Review() { Id =3, ProductId = 2, Rating = 1, Text = "" }
           };

        [Route("{productId}/reviews")]
        public IEnumerable<Review> GetReviewsForProduct(int productId)
        {
            return reviews.Where(r => r.ProductId == productId);
        }
        
    }
}
