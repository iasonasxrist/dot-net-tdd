using System;
using CustomerManagement.BL;

public class LoggingServiceTest
{

    [Fact]
    public void WriteToFileTest()
    {
        var changedItems = new List<ILoggable>();

        var customer = new Customer(1)
        {
            EmailAddress = "fbaggins@hobbiton.me",
            FirstName = "Frodo",
            LastName = "Baggins",
            AddressList = null
        };

        changedItems.Add(customer);

        var product = new Product(1)
        {
            ProductName = "Rake",
            ProductDescription = "Garden Rake with Steel Head",
            CurrentPrice = 10.9
        };
        changedItems.Add(product);

        // Act
        LoggingService.WriteToFile(changedItems);
    }

}

