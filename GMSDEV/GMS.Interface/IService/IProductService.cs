using GMS.Helper;
using GMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Interface.IService
{
    public interface IProductService
    {
        Task<ResponseModel> CreateProduct(Product objProductCategory);
        Task<Product> GetProductById(long id);
        Task<List<Product>> GetAllProduct();
        Task<ResponseModel> UpdateProduct(Product objProductCategory);
    }
}
