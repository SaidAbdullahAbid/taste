using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taste.DataAccess.Data.Repository.IRepository;

namespace Taste.Pages.Admin.Category
{
	public class UpsertModel : PageModel
	{
		private readonly IUnitOfWork _uniteOFwork;

		public UpsertModel(IUnitOfWork uniteOFwork)
		{
			_uniteOFwork = uniteOFwork;
		}
		[BindProperty]
		public Models.Category categoryObj { get; set; }
		public IActionResult OnGet(int? id)
		{
			categoryObj = new Models.Category();
			if (id != null)
			{
				categoryObj = _uniteOFwork.Category.GetFirstOrDefault(c => c.Id == id.GetValueOrDefault());
				if (categoryObj == null)
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
			if (categoryObj.Id == 0)
			{
				_uniteOFwork.Category.Add(categoryObj);
			}
			else
			{
				_uniteOFwork.Category.Update(categoryObj);
			}
			_uniteOFwork.Save();
			return RedirectToPage("./Index");
		}
	}
}
