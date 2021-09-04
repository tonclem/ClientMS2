using System;
namespace NotificationService.Data
{
    public class DistanceCalculator
    {

        public static double CalculateDistanceBtw2Locales(string Latitude_1, string Longitude_1, string Latitude_2, string Longitude_2)
        {

            Location location1 = new Location() { Latitude = Convert.ToDouble(Latitude_1), Longitude = Convert.ToDouble(Longitude_1) };
            Location location2 = new Location() { Latitude = Convert.ToDouble(Latitude_2), Longitude = Convert.ToDouble(Longitude_2) };

            return CalculateDistance(location1, location2);
        }



        public static double CalculateDistance(Location point1, Location point2)
        {
            var d1 = point1.Latitude * (Math.PI / 180.0);
            var num1 = point1.Longitude * (Math.PI / 180.0);
            var d2 = point2.Latitude * (Math.PI / 180.0);
            var num2 = point2.Longitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
                     Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        
    }


    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
