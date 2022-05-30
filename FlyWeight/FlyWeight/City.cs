using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FlyWeight
{
    public class City
    {
        private List<House> houses = new List<House>();
        
        public void planCity(float startLatitude, float endLatitude, float startLongitude, float endLongitude)
        {
            string[] materials = new string[] {"Кирпичный дом", "Панельный дом" };
            int[] floors = new int[] {5,9,16 };

            int matCount = 0;
            int floorCount = 0;

            for (float i = startLatitude; i <= endLatitude; i += 0.1f)
            {
                for (float j = startLongitude; j <= endLongitude; j += 0.1f)
                {
                    buildHouse(materials[matCount%(materials.Length)], floors[floorCount%(floors.Length)],i,j);
                    floorCount++;
                }

                matCount++;
            }


            foreach (var i in houses)
            {
                Console.WriteLine(i.getInfo());
            }
        }
        
        private void buildHouse(string material, int floors, float longitude, float latitude)
        {
            HouseType type = HouseFactory.getHouseType(material, floors);
            House house = new House(longitude,latitude,type);
            houses.Add(house);
        }
    }
}