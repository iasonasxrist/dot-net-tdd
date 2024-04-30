using System;
using System.Net.Mail;
using CustomerManagement.BL;

public class Order : EntityBase, ILoggable
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

    public string Log() => $"{OrderId}: {CustomerId} List: {OrderDate.Value.Date} Status: {EntityState.ToString()}";

    public override bool Validate()
    {
        throw new NotImplementedException();
    }
}

