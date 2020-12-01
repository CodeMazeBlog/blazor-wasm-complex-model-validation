using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared
{
	public class ProductDetails
	{
		[Required(ErrorMessage = "Description is required")]
		public string Description { get; set; }
	}
}
