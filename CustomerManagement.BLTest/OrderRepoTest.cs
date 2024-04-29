using System;

public class OrderRepoTest
{
    [Fact]
    public void Retrieve_ValidOrderId()
    {
        var repository = new OrderRepository();
        var expectedOrder = repository.Retrieve(1);

        
        var order = repository.Retrieve(1);

        Assert.NotNull(order);
        Assert.Equal(expectedOrder.OrderId, order.OrderId);
        Assert.NotNull(order.OrderDate);
    }

}

