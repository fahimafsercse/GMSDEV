using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GMS.Model
{
    [Table("AdminUser")]
    public partial class AdminUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long AdminUserTypeId { get; set; }
        public string NID { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public long StoreId { get; set; }
        public long TotalShopping { get; set; }

        public bool? Active { get; set; }
        public long? Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}