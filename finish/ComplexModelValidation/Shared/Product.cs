using System;
using System.ComponentModel.DataAnnotations;

namespace Shared
{
	public class Product
	{
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Supplier is required")]
		public string Supplier { get; set; }
		[CompareProperty("Supplier", ErrorMessage = "Comparation failed")]
		public string ConfirmSupplier { get; set; }
		[ValidateComplexType]
		public ProductDetails ProductDetails { get; set; }
	}
}
