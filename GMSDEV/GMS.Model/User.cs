using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("User")]
    public partial class User
    {
        //username,email,contactNo,address,Usertype,NID,JOINDATE
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long UserTypeId { get; set; }
        public string NID { get; set; }// for admin user
        public decimal Salary { get; set; } //for admin employee
        public long MembershipId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string StoreId { get; set; }
        public long TotalShopping { get; set; }


        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}