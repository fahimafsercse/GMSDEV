using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Model
{
    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
      //  public List<Product> Products { get; set; }
    }
}