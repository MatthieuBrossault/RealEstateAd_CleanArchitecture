namespace RealEstateAd_CleanArchitecture.Domain.ValueObjects;

public class Location : ValueObject
{
    public Address? Address { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    public Location() { }

    public Location(Address? address, double? latitude, double? longitude)
    {
        Address = address;
        Latitude = latitude;
        Longitude = longitude;
    }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        // Using a yield return statement to return each element one at a time
        yield return Address;
        yield return Latitude;
        yield return Longitude;
    }
}
