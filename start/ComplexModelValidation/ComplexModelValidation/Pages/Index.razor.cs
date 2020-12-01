using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexModelValidation.Pages
{
	public partial class Index
	{
		private Product _product = new Product();

		private void Submit() => Console.WriteLine($"{_product.Name}, {_product.Supplier}");
	}
}
