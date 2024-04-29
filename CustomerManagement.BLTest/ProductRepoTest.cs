using System.Net.Mail;
using CustomerManagement.BL;


public class ProductRepoTest
{


    [Fact]
    public void Retrieve_ValidProductId()
    {

        var repository = new ProductRepository();

        // Expected product
        var expected = new Product(1)
        {
            ProductName = "Widget",
            ProductDescription = "A description of the widget product",
            CurrentPrice = 10.99
        };

        var actualProduct = repository.Retrieve(1);

        // Assert
        Assert.NotNull(actualProduct);
        Assert.Equal(expected.ProductId, actualProduct.ProductId);
        Assert.Equal(expected.ProductName ,actualProduct.ProductName);
        Assert.Equal(expected.ProductDescription, actualProduct.ProductDescription);
        Assert.Equal(expected.CurrentPrice, actualProduct.CurrentPrice);
    }

    [Fact]
    public void SaveTestValid()
    {
        var repository = new ProductRepository();

        // Expected product
        var updatedProduct = new Product(1)
        {
            ProductName = "Widget",
            ProductDescription = "A description of the widget product",
            CurrentPrice = 10.99,
            HasChanges = true
        };

        var actual = repository.Save(updatedProduct);

        Assert.Equal(true, actual);

    }


    }





