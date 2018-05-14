using Cars.Interfaces;

namespace Cars.BL.Models
{
    public class CarWithManufacturer : ICarWithManufacturer
    {
        private int _id;
        private string _model;
        private int _year;
        private IManufacturer _manufacturer;
        private string _plateNumber;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string PlateNumber
        {
            get => _plateNumber;
            set => _plateNumber = value;
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

        public IManufacturer Manufacturer
        {
            get => _manufacturer;
            set => _manufacturer = value;
        }
    }
}
