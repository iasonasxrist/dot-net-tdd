using System.Net.Mail;
using CustomerManagement.BL;

public class CustomerTest
{
    [Fact]
    public void FullNameMatching()
    {

        Customer customer = new Customer(1)
        {
            FirstName = "John",
            LastName = "Doe"
        };

        // Act
        string fullName = customer.FullName;

        // Assert
        Assert.Equal("John, Doe", fullName);
    }
    [Fact]
    public void FullNameIsEmpty()
    {

        Customer customer = new Customer(1)
        {
            FirstName = "John"
        };
        string expected = "John";

        // Act
        string actual = customer.FullName;

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ValidateValid()
    {

        Customer customer = new Customer(1)
        {
            FirstName = "John",
            LastName = "Doe",
            EmailAddress = "ias@gmail.com"
        };

        var expected = true;

        // Act
        var actual = customer.Validate();

        // Assert
        Assert.Equal(expected, actual);
    }

}