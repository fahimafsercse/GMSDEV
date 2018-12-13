using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMS.Helper
{
    public static class HelperClass
    {
        /*public static string GetEnumDisplayName(this Enum enumType)
        {
            return enumType.GetType().GetMember(enumType.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;
        }*/
        public static ResponseModel Response(bool success, string message, dynamic output)
        {
            return new ResponseModel()
            {
                success = success,
                message = message,
                output = output
            };
        }
        /*public static Dictionary<int, string> GetAdminPrivileges()
        {
            Dictionary<int, string> adminPrivileges = new Dictionary<int, string>();

            adminPrivileges.Add((int)AdminPrivilege.Local, AdminPrivilege.Local.ToString());
            adminPrivileges.Add((int)AdminPrivilege.Domain, AdminPrivilege.Domain.ToString());
            adminPrivileges.Add((int)AdminPrivilege.System, AdminPrivilege.System.ToString());
            adminPrivileges.Add((int)AdminPrivilege.No, AdminPrivilege.No.ToString());

            return adminPrivileges;
        }

        public static Dictionary<int, string> GetUserAccessTypes()
        {
            Dictionary<int, string> userAccessTypes = new Dictionary<int, string>();

            userAccessTypes.Add((int)userAccessType.Permanent, userAccessType.Permanent.ToString());
            userAccessTypes.Add((int)userAccessType.Temporary, userAccessType.Temporary.ToString());

            return userAccessTypes;

        }*/
    }
}