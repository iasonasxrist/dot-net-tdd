using System;

public class ProductRepository
{


	public Product Retrieve(int productId)
	{
		Product product = new Product(productId);

		if ((productId) == 1)
		{
			product.ProductName = "Widget";
			product.ProductDescription = "A description of the widget product";
			product.CurrentPrice = 10.99;


			Console.WriteLine($"Product: {product.ToString()}");
		}
		return product;

	}

	public bool Save(Product product)
	{

		var success = true;

		if (product.HasChanges)
		{
			if (product.IsValid)
			{
				if (product.IsNew)
				{


				}
			}
			else {
				success = false;
			}
		}
		return success;

	}
}

