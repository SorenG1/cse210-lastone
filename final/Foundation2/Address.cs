using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    
    //This checks if the address is inside the United States
    public bool IsUsa()
    {
        return _country.ToLower() == "usa";Principle: Inheritance
20 pts
Complete
All behaviors and attributes, shared among multiple related classes, are placed in a base class and inherited.
14 pts
Developing
Inheritance is used in the program.
0 pts
Incomplete
Inheritance is not used in the program.
20 pts
    }

    //this returns the full address as a string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}]\n{_country}";
    }
}