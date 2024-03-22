using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseKeyboard.Models.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter product name")]
        [DisplayName("Product name")]
        public string Name { get; set; }

        [DisplayName("Product description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Enter product price")]
        [DisplayName("Product price")]
        [Range(1, int.MaxValue)]
        public float Price { get; set; }

        [DisplayName("Product image")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Enter product cagetegory")]
        [DisplayName("Product category")]
        public int CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}
