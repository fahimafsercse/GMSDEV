using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("UserType")]
    public partial class UserType
    {
        //admin,

        //employee/
        //store_id
        //customer
        //lst shopping date, joined
        //supplier
        public long Id { get; set; }
        public string Name { get; set; }


        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}