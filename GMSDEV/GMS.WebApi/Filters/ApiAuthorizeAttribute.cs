using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMS.WebApi.Filters
{
    public class ApiAuthorizeAttribute //: AuthorizeAttribute
    {
       /* private string headerAccessToken = "accessToken";
        private string headerSharePointUrl = "sharePointUrl";
        private string headerAccount = "account";
        private string headerHostedUrl = "hostedUrl";

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            string accessToken = actionContext.Request.Headers?.FirstOrDefault(x => x.Key.Equals(headerAccessToken)).Value?.FirstOrDefault();
            string sharePointUrl = actionContext.Request.Headers?.FirstOrDefault(x => x.Key.Equals(headerSharePointUrl)).Value?.FirstOrDefault();
            string account = actionContext.Request.Headers?.FirstOrDefault(x => x.Key.Equals(headerAccount)).Value?.FirstOrDefault();
            string hostedUrl = actionContext.Request.Headers?.FirstOrDefault(x => x.Key.Equals(headerHostedUrl)).Value?.FirstOrDefault();

            if (accessToken == null)
            {
                return false;
            }
            else
            {
                if (HttpContext.Current.Session["SPAuthSetting"] == null)
                {
                    SPAuthSetting sPAuthSetting = new SPAuthSetting()
                    {
                        accessToken = accessToken,
                        loginName = account,
                        spUrl = sharePointUrl,
                        hostedUrl = hostedUrl
                    };
                    HttpContext.Current.Session["SPAuthSetting"] = sPAuthSetting;

                    return true;
                }
                else
                    return true;
            }
        }*/
    }
}