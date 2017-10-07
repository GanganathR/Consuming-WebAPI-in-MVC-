using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
namespace WebApi.Controllers
{
    public class ProductApiController : ApiController
    {
        private ProductRepository productrespository = new ProductRepository();

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return productrespository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public Product GetById(string id)
        {
            try
            {
                return productrespository.FindbyId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
