using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("Store")]
    public partial class Store
    {

        [Key]
        public long Id { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }



        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }

    
    }
}