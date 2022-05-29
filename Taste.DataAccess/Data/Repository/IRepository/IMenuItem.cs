using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Taste.Models;

namespace Taste.DataAccess.Data.Repository.IRepository
{
    public interface IMenuItem : IRepository<MenuItem>
    {
        public IEnumerable<SelectListItem> GetFoodTypeWithSelectListItem();
        public void Update(MenuItem item);

    }
}
