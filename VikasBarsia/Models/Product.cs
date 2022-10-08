using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VikasBarsia.Models
{
    public class Product
    {
        [Key]
        [DisplayName("ProductId")]
        public int Id { get; set; }
        [DisplayName("ProductName")]
        public string Name { get; set; }
        public Nullable<int> CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}