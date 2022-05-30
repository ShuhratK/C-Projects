using System.Collections.Generic;

namespace FlyWeight
{
    public static class HouseFactory
    {
        private static List<HouseType> HouseTypes = new List<HouseType>();

        public static HouseType getHouseType(string material, int floors)
        {
            HouseType type = findHouseType(material, floors);

            if (type == null)
            {
                HouseTypes.Add(new HouseType(material, floors));
                type = HouseTypes[HouseTypes.Count - 1];
            }
            return type;
        }

        private static HouseType findHouseType (string material, int floors)
        {
            HouseType type = null;
            for (int i = 0; i < HouseTypes.Count; i++)
            {
                if (HouseTypes[i].floors == floors && HouseTypes[i].material == material)
                {
                    type = HouseTypes[i];
                }
            }
            return type;
        }
    }
}