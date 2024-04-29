using System;
using CustomerManagement.BL;

public class OrderRepository
{

    public Order Retrieve(int orderId)
    {
        Order order = new Order(orderId);

        if (orderId == 1)
        {
            order.OrderDate = DateTimeOffset.Now;


        }

        return order;
    }
}

