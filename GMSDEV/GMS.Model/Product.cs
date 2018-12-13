using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GMS.Model
{
    [Table("Product")]
    public partial class Product
    {
        //id,Brand(companyName),name,quantity,amount,des,price,pic,category,date,taxable(0/1)
        [Key]
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long Stock { get; set; }

        public bool Active { get; set; }
        public long Author { get; set; }
        public DateTime? Created { get; set; }
        public long Editor { get; set; }
        public DateTime? Modified { get; set; }
    }
}