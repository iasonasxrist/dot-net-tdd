using System;
using CustomerManagement.BL;

public class Order
{
	public DateTimeOffset? OrderDate { get;  set; }
    public int OrderId { get; private set; }

    public Order(int orderId)
	{
        OrderId = orderId;

    }

    public List<Order> Retrieve()
    {
        return new List<Order>();
    }

}

