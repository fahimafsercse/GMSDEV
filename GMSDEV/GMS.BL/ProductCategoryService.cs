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
    public class ProductCategoryService :IProductCategoryService
    {
        public async Task<ResponseModel> CreateProductCategory(ProductCategory objProductCategory)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {

                    gmsDbContext.Entry(objProductCategory).State = EntityState.Added;
                    await gmsDbContext.SaveChangesAsync();
                    return HelperClass.Response(true
                         , GlobalDecleration._savedSuccesfully
                         , null
                     );
                }
            }
            catch (Exception ex)
            {
                Print("CreateProductCategory", ex.Message);
                return HelperClass.Response(false
                         , GlobalDecleration._internalServerError
                         , null
                     );
            }

        }
        public async Task<ProductCategory> GetProductCategoryByCategoryId(long id)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    return await gmsDbContext.ProductCategories.FindAsync(id);
                }
            }
            catch (Exception ex)
            {
                Print("GetProductCategoryByCategoryId", ex.Message);
                return null;
            }
        }
        public async Task<List<ProductCategory>> GetAllProductCategory()
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    var retLst = gmsDbContext.ProductCategories.ToList();
                    return retLst;
                }
            }
            catch (Exception ex)
            {
                Print("GetAllSubCategory", ex.Message);
                return null;
            }
        }
        public async Task<ResponseModel> UpdateProductCategory(ProductCategory objProductCategory)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    var checkProductCategory = gmsDbContext.ProductCategories.Where(cat => cat.Name == objProductCategory.Name && cat.Id != cat.Id).ToList();
                    if (checkProductCategory.Count() > 0)
                    {
                        return HelperClass.Response(false
                         , GlobalDecleration._alreadyExits
                         , null
                     );
                    }
                    else
                    {
                        gmsDbContext.Entry(objProductCategory).State = EntityState.Modified;
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
                Print("UpdateProductCategory", ex.Message);
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
            ErrorLogs.PrintError("CategoryService"
                , method
                , msg);
        }

        Task<ResponseModel> IProductCategoryService.GetProductCategoryByCategoryId(long id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}