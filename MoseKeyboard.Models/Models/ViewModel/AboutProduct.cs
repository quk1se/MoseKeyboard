using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseKeyboard.Models.Models.ViewModel
{
    public class AboutProduct
    {
        public AboutProduct()
        {
            Product = new Product();
        }
        public Product Product { get; set; }
        public bool ExistsInCart { get; set; }
    }
}
