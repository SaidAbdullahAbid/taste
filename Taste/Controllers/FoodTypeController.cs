using Microsoft.AspNetCore.Mvc;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models;

namespace Taste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult<FoodType> Get()
        {
            return Json(new { data = _unitOfWork.FoodType.GetAll() });
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            FoodType foodType = _unitOfWork.FoodType.GetFirstOrDefault(x => x.Id == id);
            if (foodType == null)
            {
                return Json(new { success = false, message = "Error while Deleteing" });
            }
            _unitOfWork.FoodType.Remove(foodType);
            _unitOfWork.Save();
            return Json(new { success = true, message = "The record is deleted successfully" });
        }

    }
}
