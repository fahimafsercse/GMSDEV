using GMS.Helper;
using GMS.Model;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using GMS.BL.Common;
using GMS.Interface.IService;

namespace GMS.BL
{
    public class ProductService : IProductService
    {
        public async Task<ResponseModel> CreateProduct(Product objProduct)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {

                    gmsDbContext.Entry(objProduct).State = EntityState.Added;
                    await gmsDbContext.SaveChangesAsync();
                    return HelperClass.Response(true
                         , GlobalDecleration._savedSuccesfully
                         , null
                     );
                }
            }
            catch (Exception ex)
            {
                Print("CreateProduct", ex.Message);
                return HelperClass.Response(false
                         , GlobalDecleration._internalServerError
                         , null
                     );
            }

        }
        public async Task<Product> GetProductById(long id)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    return await gmsDbContext.Products.FindAsync(id);
                }
            }
            catch (Exception ex)
            {
                Print("GetProductById", ex.Message);
                return null;
            }
        }
        public async Task<List<Product>> GetAllProduct()
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    var retLst = gmsDbContext.Products.ToList();
                    return retLst;
                }
            }
            catch (Exception ex)
            {
                Print("GetAllProduct", ex.Message);
                return null;
            }
        }
        public async Task<ResponseModel> UpdateProduct(Product objProduct)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    var checkProduct = gmsDbContext.Products.Where(product => product.Name == objProduct.Name && product.Id != product.Id).ToList();
                    if (checkProduct.Count() > 0)
                    {
                        return HelperClass.Response(false
                         , GlobalDecleration._alreadyExits
                         , null
                     );
                    }
                    else
                    {
                        gmsDbContext.Entry(objProduct).State = EntityState.Modified;
                        await gmsDbContext.SaveChangesAsync();
                        return HelperClass.Response(true
                             , GlobalDecleration._savedSuccesfully
                             , null
                         );
                    }
                }
            }
            catch (Exception ex)
            {
                Print("UpdateProduct", ex.Message);
                return HelperClass.Response(false
                         , GlobalDecleration._internalServerError
                         , null
                     );
            }
        }
        #region Error

        private static void Print(string method
             , string msg)
        {
            ErrorLogs.PrintError("ProductService"
                , method
                , msg);
        }
        #endregion
    }
}