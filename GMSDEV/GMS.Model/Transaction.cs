using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("Transaction")]
    public partial class Transaction
    {
        //userId,totalShoping
        [Key]
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long UserId { get; set; }
        public long MembershipId { get; set; }
        public long OfferId { get; set; }



        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}