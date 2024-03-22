using MoseBoard.DAL.Repository.IRepository;
using MoseKeyboard.Data;
using MoseKeyboard.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MoseBoard.DAL.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllDropDownList(string obj)
        {
            if (obj == "Category")
            {
                return _db.Category.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
            }
            return null;
        }

        public void Update(Product product)
        {
            _db.Product.Update(product);
        }
    }
}
