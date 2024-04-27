
using CustomerManagement.BL;

public class Product
{
	public double? CurrentPrice { get; set; }
    public string  ProductDescription { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }

    public Product(int productId)
	{
        ProductId = productId;
	}


    public List<Product> Retrieve()
    {
        return new List<Product>();
    }

}

