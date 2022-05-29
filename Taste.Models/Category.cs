using System;
using System.ComponentModel.DataAnnotations;

namespace Taste.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Display(Name = "Category Name")]
		public String Name { get; set; }
		[Required, Display(Name = "Display Order")]
		[DataType(DataType.Text)]
		public int DisplayOrder { get; set; }
	}
}
