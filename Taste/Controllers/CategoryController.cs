using Microsoft.AspNetCore.Mvc;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult<Category> Get()
        {
            return Json(new { data = _unitOfWork.Category.GetAll() });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var objForDelete = _unitOfWork.Category.GetFirstOrDefault(x => x.Id == id);
            if (objForDelete == null)
            {
                return Json(new { success = false, message = "Error while Deleteing" });
            }
            _unitOfWork.Category.Remove(objForDelete);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Object is deleted Successfully" });
        }
    }
}
