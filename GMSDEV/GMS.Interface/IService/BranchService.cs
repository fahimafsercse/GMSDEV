using GMS.Helper;
using GMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Interface.IService
{
    public class BranchService{
        public async Task<ResponseModel> CreateBranch(Branch objBranch)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    if (objBranch.Id == 0)
                    {
                        objBranch.Id = gmsDbContext.Branches.DefaultIfEmpty().Max(p => p == null ? 0 : p.Id) + 1;
                    }
                    objBranch.Created = DateTime.Now;
                    objBranch.Modified = DateTime.Now;
                    gmsDbContext.Entry(objBranch).State = System.Data.Entity.EntityState.Added;
                    await gmsDbContext.SaveChangesAsync();
                    return HelperClass.Response(true
                         , GlobalDecleration._savedSuccesfully
                         , null
                     );
                }
            }
            catch (Exception ex)
            {
                Print("CreateBranch", ex.Message);
                return HelperClass.Response(false
                         , GlobalDecleration._internalServerError
                         , null
                     );
            }
        }
        public async Task<ResponseModel> GetAllBranch()
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    var retLst =  gmsDbContext.Branches.OrderByDescending(x => x.Id).ToList();
                    return HelperClass.Response(true
                         , GlobalDecleration._savedSuccesfully
                         , retLst
                     );
                }
            }
            catch (Exception ex)
            {
                Print("GetAllBranch", ex.Message);
                return HelperClass.Response(false
                          , GlobalDecleration._internalServerError
                          , null
                      );
            }
        }
        public async Task<ResponseModel> UpdateBranch(Branch objBranch)
        {
            try
            {
                using (GMSEntities gmsDbContext = new GMSEntities())
                {
                    objBranch.Modified = DateTime.Now;
                    gmsDbContext.Entry(objBranch).State = EntityState.Modified;
                    await gmsDbContext.SaveChangesAsync();
                    return HelperClass.Response(true
                         , GlobalDecleration._savedSuccesfully
                         , null
                     );
                }
            }
            catch (Exception ex)
            {
                Print("UpdateBranch", ex.Message);
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
            ErrorLogs.PrintError("BranchService"
                , method
                , msg);
        }

        #endregion
    }
}
