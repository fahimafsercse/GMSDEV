using GMS.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMS.BL.Common
{
    internal class ErrorLogs
    {
        internal static void PrintError(string className
          , string methodName
          , string msg)
        {
            string layerName = "TOGWorkflow.BL";
            Error.PrintError(layerName
                , className
                , methodName
                , msg);
        }
    }
}