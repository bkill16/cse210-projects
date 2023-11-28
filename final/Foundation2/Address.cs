public class Address {
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private bool _usa = true;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country.ToLower() != "united states of america" && _country.ToLower() != "united states" && _country.ToLower() != "usa")
        {
            _usa = false;
        }
        else
        {
            _usa = true;
        }
        return _usa;
    }

    public string FormatAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}