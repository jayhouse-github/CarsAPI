using Cars.Interfaces;

namespace Cars.BL
{
    public class Manufacturer : IManufacturer
    {
        private int _id;
        private string _name;
        private string _country;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }
    }
}
