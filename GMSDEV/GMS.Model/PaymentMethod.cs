using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("PaymentMethod")]
    public partial class PaymentMethod
    {
        //incomplete
        //bkash,bank
        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}