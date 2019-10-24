namespace Boundaries.Models
{
    public class Coordinate
    {
        public double Latitude { get; } //Y
        public double Longitude { get; } //X

        public Coordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }


    }
}
