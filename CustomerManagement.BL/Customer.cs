﻿namespace CustomerManagement.BL;

public class Customer : EntityBase, ILoggable
{

    public int CustomerId { get; set; }
    public int CustomerType { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? EmailAddress { get; set; }
    public List<Address> AddressList { get; set; }

    public Customer(int customerId)
    {
        CustomerId = customerId;
        AddressList  = new List<Address>();
    }


    public string FullName
    {
        get
        {
            string fullName = LastName;
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }
                fullName += FirstName;
            }
            return fullName;
        }
    }

    public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

    public override bool Validate()
    {
        var isValid = true;
        if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
        if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
        return isValid;
    }

    public List<Customer> Retrieve()
    {
        return new List<Customer>();
    }

}

