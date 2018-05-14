using Cars.Interfaces;
using Newtonsoft.Json;

namespace Cars.BL
{
    public class Car : ICar
    {
        private int _id;
        private string _model;
        private int _year;
        private int _manufacturer;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        [JsonIgnore]
        public int ManufacturerId
        {
            get => _manufacturer;
            set => _manufacturer = value;
        }
    }
}
