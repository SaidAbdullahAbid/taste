using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository.IRepository
{
    public interface IFoodType : IRepository<FoodType>
    {
        IEnumerable<SelectListItem> GetAllFoodTypeSelectList();
        void Update(FoodType entity);
    }
}
