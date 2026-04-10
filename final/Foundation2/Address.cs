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
        return _country.ToLower() == "usa";
    }

    //this returns the full address as a string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}]\n{_country}";
    }
}