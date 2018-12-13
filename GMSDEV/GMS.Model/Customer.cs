using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Model
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long CustomerTypeId { get; set; }
        public long MembershipId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public long TotalShopping { get; set; }


        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}