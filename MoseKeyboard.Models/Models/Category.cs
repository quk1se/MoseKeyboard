using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseKeyboard.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter category name")]
        [DisplayName("Category name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter category description")]
        [DisplayName("Category description")]
        public string Description { get; set; }
    }
}
