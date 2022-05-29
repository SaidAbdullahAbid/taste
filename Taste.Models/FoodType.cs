using System.ComponentModel.DataAnnotations;

namespace Taste.Models
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Food Type Name can not be blank!")]
        [Display(Name = "Food Type Name")]
        [MaxLength(255, ErrorMessage = "Food Type Name must be less then 255 character")]
        [MinLength(3, ErrorMessage = "Food Type Name must be greather then 3 character")]
        public string Name { get; set; }
    }
}
