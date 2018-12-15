using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("Membership")]
    public class Membership
    {
        //id,name,gen,addres,cntact,memberType
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public long MembershipTypeId { get; set; }
        public string DiscountToken { get; set; }
        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}