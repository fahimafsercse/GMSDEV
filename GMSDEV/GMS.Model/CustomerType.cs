using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GMS.Model
{
    [Table("CustomerType")]
    public partial class CustomerType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }


        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}