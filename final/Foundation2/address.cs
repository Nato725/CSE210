public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;

    public Address(string street, string city, string state, string zipCode, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES" || _country.ToUpper() == "UNITED STATES OF AMERICA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state} {_zipCode}\n{_country}";
    }
}
