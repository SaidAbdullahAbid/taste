using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taste.DataAccess.Data.Repository.IRepository;

namespace Taste.Pages.Admin.FoodType
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _uniteOfWork;

        public UpsertModel(IUnitOfWork uniteOfWork)
        {
            _uniteOfWork = uniteOfWork;
        }
        [BindProperty]
        public Models.FoodType foodType { get; set; }
        public ActionResult OnGet(int? id)
        {
            foodType = new Models.FoodType();
            if (id != null)
            {
                foodType = _uniteOfWork.FoodType.GetFirstOrDefault(x => x.Id == id.GetValueOrDefault());
                if (foodType == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            if (foodType.Id == 0)
            {
                _uniteOfWork.FoodType.Add(foodType);
            }
            else
            {
                _uniteOfWork.FoodType.Update(foodType);
            }
            _uniteOfWork.Save();
            return RedirectToPage("./Index");

        }
    }
}
