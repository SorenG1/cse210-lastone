using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    //constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    //We add the product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //This calculates the cost of the order 
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total +=5;
        }

        else
        {
            total += 35;
        }

        return total;

    }

    //this gives us the packing label
    public string GetPackingLabel()
    {
        string result = "";
        
        foreach (Product p in _products)
        {
            result += $"{p.GetName()} ({p.GetId()})\n";
        }
        return result;
    }

    //returns the shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}