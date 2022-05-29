using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItem
    {
        private readonly ApplicationDbContext _db;

        public MenuItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetFoodTypeWithSelectListItem()
        {
            return _db.MeunItem.Select(m => new SelectListItem { Text = m.Name, Value = m.Id.ToString() });
        }

        public void Update(MenuItem item)
        {
            MenuItem menuItem = _db.MeunItem.FirstOrDefault(m => m.Id == item.Id);
            menuItem.Name = item.Name;
            menuItem.Description = item.Description;
            menuItem.Price = item.Price;
            if (item.Image != null)
                menuItem.Image = item.Image;
            menuItem.CategoryId = item.CategoryId;
            menuItem.FoodTypeId = item.FoodTypeId;

            _db.SaveChanges();
        }
    }
}
