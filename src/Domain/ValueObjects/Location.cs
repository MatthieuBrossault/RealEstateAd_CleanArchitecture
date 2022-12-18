namespace RealEstateAd_CleanArchitecture.Domain.ValueObjects;

public class Location : ValueObject
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string ZipCode { get; private set; }

    public Location() { }

    public Location(double latitude, double longitude, string street, string city, string state, string country, string zipcode)
    {
        Latitude = latitude;
        Longitude = longitude;
        Street = street;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipcode;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        // Using a yield return statement to return each element one at a time
        yield return Latitude;
        yield return Longitude;
        yield return Street;
        yield return City;
        yield return State;
        yield return Country;
        yield return ZipCode;
    }
}
