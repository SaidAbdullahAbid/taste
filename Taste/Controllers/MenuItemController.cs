using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Taste.DataAccess.Data.Repository.IRepository;

namespace Taste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : Controller
    {
        private readonly IUnitOfWork _uniteOfWork;
        private readonly IWebHostEnvironment _webHostEnvoirment;

        public MenuItemController(IUnitOfWork uniteOfWork, IWebHostEnvironment webHostEnvoirment)
        {
            _uniteOfWork = uniteOfWork;
            _webHostEnvoirment = webHostEnvoirment;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(new { data = _uniteOfWork.MenuItem.GetAll(null, null, "Category,FoodType") });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var menuItem = _uniteOfWork.MenuItem.GetFirstOrDefault(m => m.Id == id);
                if (menuItem == null)
                {
                    return Json(new { succes = false, message = "Error will deleting" });
                }
                var imagepath = Path.Combine(_webHostEnvoirment.WebRootPath, menuItem.Image.TrimStart('\\'));
                if (System.IO.File.Exists(imagepath))
                {
                    System.IO.File.Delete(imagepath);
                }
                _uniteOfWork.MenuItem.Remove(menuItem);
                _uniteOfWork.Save();

            }
            catch (System.Exception ex)
            {
                return Json(new { succes = false, message = "Error will deleting" });

            }

            return Json(new { succes = true, message = "Deleted Successfully" });
        }
    }
}
