using GMS.BL;
using GMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace GMS.WebApi.Controllers
{
 
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        [HttpPost]
        [Route("Create")]
        public async Task<IHttpActionResult> Create(Product objProduct)
        {
            return Ok(await new ProductService().CreateProduct(objProduct));
        }
        [HttpPost]
        [Route("Update")]
        public async Task<IHttpActionResult> Update(Product objProduct)
        {
            return Ok(await new ProductService().UpdateProduct(objProduct));
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IHttpActionResult> GetAll()
        {
            return Ok(await new ProductService().GetAllProduct());
        }

        [Route("GetById")]
        public async Task<IHttpActionResult> GetByProductId(long id)
        {
            return Ok(await new ProductService().GetProductById(id));
        }
    }
}
