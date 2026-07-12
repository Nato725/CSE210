public class Address
{
    private string _streetAddress { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _zipCode { get; set; }

    public Address(string street, string city, string state, string zipCode)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES" || _country.ToUpper() == "UNITED STATES OF AMERICA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state} {_zipCode}";
    }
}
