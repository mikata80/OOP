using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other_Types_in_OOP
{
    public enum Planet
    {
        Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
    }
    class GalacticGPS
    {

        static void Main()
        {

            Location location = new Location(18.037986, 28.870097, Planet.Earth);
            Location location2 = new Location(18.037986, 28.870097, Planet.Mars);
            Console.WriteLine(location.ToString());
            Console.WriteLine(location2.ToString());
        }

        struct Location
        {
            private double latitude;
            private double longitude;
            private Planet planet;

            public Location(double latitude, double longitude, Planet planet)
            {
                this.latitude = latitude;
                this.longitude = longitude;
                this.planet = planet;
            }


            public override string ToString()
            {
                return String.Format("{0} {1} - {2}", latitude, longitude, planet);
            }
        }
    }
}
