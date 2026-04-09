using System;

public class Customer
{
    private string _name;
    private Address _address;
    
    //constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    //this part checks if the customer lives in the United States
    public bool LivesInUSA()
    {
        return _address.IsUsa();
    }
}