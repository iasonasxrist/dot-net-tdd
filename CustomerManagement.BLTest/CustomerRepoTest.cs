using System.Diagnostics.Metrics;
using System.Net.Mail;
using CustomerManagement.BL;

public class CustomerRepoTest
{
    [Fact]
    public void Retrieve_ValidCustomerId_ReturnsCustomerWithCorrectData()
    {
        // Arrange
        int validCustomerId = 1;
        var repository = new CustomerRepository();

        var expected = new Customer(1)
        {
            EmailAddress = "ffdgdfg",
            FirstName = "fsdggfsd",
            LastName = "sgfdgdgf"
        };

        var actual = repository.Retrieve(1);

        Assert.NotNull(expected); // Ensure that the returned customer is not null
        Assert.Equal(validCustomerId, actual.CustomerId); // Check if the customer's ID matches the expected value
        Assert.Equal(expected.EmailAddress, actual.EmailAddress); // Check if the customer's email address matches the expected value
        Assert.Equal(expected.FirstName, actual.FirstName); // Check if the customer's first name matches the expected value
        Assert.Equal(expected.LastName, actual.LastName); // 
    }


    [Fact]
    public void Retrieve_ValidCustomerId_ReturnsCustomerWithAddressList()
    {
        // Arrange
        var customerRepository = new CustomerRepository();
        var expectedCustomer = new Customer(1)
        {
            EmailAddress = "ffdgdfg",
            FirstName = "fsdggfsd",
            LastName = "sgfdgdgf",
            AddressList = new List<Address>()
            {

                new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                new Address(2)
                {
                    AddressType = 2,
                    StreetLine1 = "Green Dragon",
                    City = "Bywater",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "146"
                }

            }
        };

        // Act
        var actual = customerRepository.Retrieve(1);

        // Assert
        Assert.NotNull(actual);

        Assert.Equal(expectedCustomer.CustomerId, actual.CustomerId);
        Assert.Equal(expectedCustomer.EmailAddress, actual.EmailAddress);
        Assert.Equal(expectedCustomer.FirstName, actual.FirstName);
        Assert.Equal(expectedCustomer.LastName, actual.LastName);

        for (int i = 0; i < 1; i++)
        {
            Assert.Equal(expectedCustomer.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            Assert.Equal(expectedCustomer.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
            Assert.Equal(expectedCustomer.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
            Assert.Equal(expectedCustomer.AddressList[i].City, actual.AddressList[i].City);
            Assert.Equal(expectedCustomer.AddressList[i].State, actual.AddressList[i].State);
            Assert.Equal(expectedCustomer.AddressList[i].Country, actual.AddressList[i].Country);
            Assert.Equal(expectedCustomer.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

        }
    }

}