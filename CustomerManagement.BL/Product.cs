
using CustomerManagement.BL;

public class Product : EntityBase
{
	public double CurrentPrice { get; set; }
    public string  ProductDescription { get; set; }
    public int ProductId { get; set; }

    private string _productName;
    public string ProductName
    {
        get
        {
            return StringHandler.InsertSpaces(_productName);
        }
        set
        {
            _productName = value;
        }
    }
   

    public Product(int productId)
	{
        ProductId = productId;
	}


    public List<Product> Retrieve()
    {
        return new List<Product>();
    }

    public override string ToString() => ProductName;


    public override bool Validate()
    {
        var isValid = true;

        if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
        if (CurrentPrice == null) isValid = false;

        return isValid;
    }

}

