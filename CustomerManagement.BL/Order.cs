using System;
using CustomerManagement.BL;

public class Order
{
	public DateTimeOffset? OrderDate { get;  set; }
    public int OrderId { get; private set; }
    public int CustomerId { get; set; }
    public int ShippingAddressId { get; set;}
    public List<OrderItem> OrderItems { get; set;}


    public Order(int orderId)
	{
        OrderId = orderId;

    }

    public List<Order> Retrieve()
    {
        return new List<Order>();
    }

}

