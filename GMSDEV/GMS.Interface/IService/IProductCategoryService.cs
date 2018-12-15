using GMS.Helper;
using GMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Interface.IService
{
    public interface IProductCategoryService
    {
        Task<ResponseModel> CreateProductCategory(ProductCategory objProductCategory);
        Task<ProductCategory> GetProductCategoryByCategoryId(long id);
        Task<List<ProductCategory>> GetAllProductCategory();
        Task<ResponseModel> UpdateProductCategory(ProductCategory objProductCategory);
    }
}
