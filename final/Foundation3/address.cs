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

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state} {_zipCode}\n{_country}";
    }
}
