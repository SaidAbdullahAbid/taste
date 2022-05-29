
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository
{
    public class FoodTypeRepository : Repository<FoodType>, IFoodType
    {
        private readonly ApplicationDbContext _db;
        public FoodTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAllFoodTypeSelectList()
        {
            return _db.FoodType.Select(f => new SelectListItem { Text = f.Name, Value = f.Id.ToString() });
        }

        public void Update(FoodType entity)
        {
            FoodType foodType = _db.FoodType.FirstOrDefault(f => f.Id == entity.Id);
            foodType.Name = entity.Name;
            _db.SaveChanges();
        }
    }
}

