using System;
using System.IO;

namespace FlyWeight
{
    public class House
    {
        public float longitude;
        public float latitude;
        public HouseType type;
        
        public House(float longitude, float latitude, HouseType type)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.type = type;
        }

        public string getInfo()
        {
            return ($"{type.material} {type.floors.ToString()}, " +
                    $"широта {longitude.ToString("0.00")}, долгота {latitude.ToString("0.00")}");
        }
    }
}