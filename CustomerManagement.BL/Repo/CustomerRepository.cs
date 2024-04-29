using System;
using CustomerManagement.BL;

public class CustomerRepository
{

    private AddressRepository addressRepository { get; set; }


    public CustomerRepository()
    {
        addressRepository = new AddressRepository();
    }

   

    public Customer Retrieve(int customerId)
    {
        Customer customer = new Customer(customerId);

        if (customerId == 1)
        {
            customer.EmailAddress = "ffdgdfg";
            customer.FirstName = "fsdggfsd";
            customer.LastName = "sgfdgdgf";
            customer.AddressList = addressRepository.RetrieveById(customerId).
                ToList();
        }

        return customer;
    }

    public bool Save(Customer customer)
    {
        return true;
    }
}


