using MoseBoard.DAL.Entity;
using MoseBoard.Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoseBoard.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseBoard.DAL.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDBContext _db;
        public ProductRepository(ApplicationDBContext db) : base(db)
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
