using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMS.Helper
{
    public class ResponseModel
    {
        public bool success { get; set; }
        public string message { get; set; }
        public dynamic output { get; set; }
    }
}