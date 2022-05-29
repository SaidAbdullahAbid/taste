using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.Pages.Customer.Home
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWrok;

        public IEnumerable<MenuItem> menuItems { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(IUnitOfWork unitOfWrok)
        {
            _unitOfWrok = unitOfWrok;
        }
        public void OnGet()
        {
            menuItems = _unitOfWrok.MenuItem.GetAll(null, null, "Category,FoodType");
            Categories = _unitOfWrok.Category.GetAll(null, q => q.OrderBy(c => c.DisplayOrder), null);

        }
    }
}
