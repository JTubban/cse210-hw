public class Address
{
    private string _venueName;
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string venueName, string streetAddress, string city, string stateProvince, string country)
    {
        this._venueName = venueName;
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateProvince = stateProvince;
        this._country = country;
    }

    public string GetAddress()
    {
        return $"{_venueName}\n{_streetAddress}\n{_city}\n{_stateProvince}\n{_country}";
    }
}