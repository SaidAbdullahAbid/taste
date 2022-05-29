using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            return _db.Category.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() });
        }

        public void Update(Category category)
        {
            //Category objFormdb = _db.Category.FirstOrDefault(c => c.Id == category.Id);
            //objFormdb.Name = category.Name;
            //objFormdb.DisplayOrder = category.DisplayOrder;
            _db.Category.Update(category);
            _db.SaveChanges();
        }
    }
}
