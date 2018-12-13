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
    [RoutePrefix("api/ProductCategory")]
    public class ProductCategoryController : ApiController
    {
        [HttpPost]
        [Route("Create")]
        public async Task<IHttpActionResult> Create(ProductCategory objProductCategory)
        {
            return Ok(await new ProductCategoryService().CreateProductCategory(objProductCategory));
        }
        [HttpPost]
        [Route("Update")]
        public async Task<IHttpActionResult> Update(ProductCategory objProductCategory)
        {
            return Ok(await new ProductCategoryService().UpdateProductCategory(objProductCategory));
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<IHttpActionResult> GetAll()
        {
            return Ok(await new ProductCategoryService().GetAllProductCategory());
        }

        [Route("GetByCategoryId")]
        public async Task<IHttpActionResult> GetByCategoryId(long id)
        {
            return Ok(await new ProductCategoryService().GetProductCategoryByCategoryId(id));
        }
    }
}
