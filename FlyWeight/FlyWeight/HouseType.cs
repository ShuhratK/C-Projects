namespace FlyWeight
{
    public class HouseType
    {
        public string material { get; private set;}
        public int floors { get; private set;}

        public HouseType(string material, int floors)
        {
            this.material = material;
            this.floors = floors;
        }
    }
}