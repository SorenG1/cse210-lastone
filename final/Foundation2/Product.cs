using System;

public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    //consturctor

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // This part returns the total cost of the specific product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    
    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }
}