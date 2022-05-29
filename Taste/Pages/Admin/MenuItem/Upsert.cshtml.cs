using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models.ViewModels;

namespace Taste.Pages.Admin.MenuItem
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvoirment;

        public UpsertModel(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvoirment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvoirment = hostEnvoirment;
        }
        [BindProperty]
        public MenuItemVM menuItemVM { get; set; }

        public IActionResult OnGet(int? id)
        {
            menuItemVM = new MenuItemVM
            {
                MenuItem = new Models.MenuItem(),
                CategoryList = _unitOfWork.Category.GetCategoryListForDropDown(),
                FoodTypeList = _unitOfWork.FoodType.GetAllFoodTypeSelectList()
            };
            if (id.HasValue)
            {
                menuItemVM.MenuItem = _unitOfWork.MenuItem.GetFirstOrDefault(m => m.Id == id);
                if (menuItemVM.MenuItem == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            string rootPath = _hostEnvoirment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (menuItemVM.MenuItem.Id == 0)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(rootPath, @"images\menuItems");
                var extention = Path.GetExtension(files[0].FileName);
                if (files.Count > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extention), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    menuItemVM.MenuItem.Image = @"\images\menuItems\" + fileName + extention;
                }
                _unitOfWork.MenuItem.Add(menuItemVM.MenuItem);
            }
            else
            {
                var objFormDb = _unitOfWork.MenuItem.Get(menuItemVM.MenuItem.Id);
                if (files.Count > 0)
                {
                    var uploads = Path.Combine(rootPath, @"images\menuItems");
                    string fileName = Guid.NewGuid().ToString();
                    var extention = Path.GetExtension(files[0].FileName);
                    if (!string.IsNullOrEmpty(objFormDb.Image))
                    {
                        var imagePath = Path.Combine(rootPath + objFormDb.Image.Trim('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extention), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    menuItemVM.MenuItem.Image = @"\images\menuItems" + fileName + extention;
                }
                else
                {
                    menuItemVM.MenuItem.Image = objFormDb.Image;
                }
                _unitOfWork.MenuItem.Update(menuItemVM.MenuItem);
            }
            _unitOfWork.Save();
            return RedirectToPage("./index");
        }
    }
}
