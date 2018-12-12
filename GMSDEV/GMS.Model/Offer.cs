using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("Offer")]
    public partial class Offer
    {
        [Key]
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long ProductId { get; set; }
        public long MembershipId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Discount { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }


        //id,offerType
        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}