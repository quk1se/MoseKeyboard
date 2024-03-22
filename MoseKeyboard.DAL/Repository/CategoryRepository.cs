using MoseBoard.DAL.Entity;
using MoseBoard.Models.Models;
using MoseBoard.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoseBoard.DAL.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _db;

        public CategoryRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var categoryFromDb = base.FirstOrDefault(x => x.Id == category.Id);
            if (categoryFromDb != null)
            {
                categoryFromDb.Name = category.Name;
            }
        }

        public void UpdateName(string category)
        {
            var categoryFromDb = base.FirstOrDefault(x => x.Name == category);
            if (categoryFromDb != null)
            {
                categoryFromDb.Name = category;
            }
        }
    }
}
