using System.Collections.Generic;
using Cars.Interfaces;

namespace Cars.BL.Models
{
    public class ManufacturerWithCars : IManufacturerWithCars
    {
        private int _id;
        private string _name;
        private string _country;
        private IEnumerable<ICar> _availableCars;

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


        public IEnumerable<ICar> AvailableCars
        {
            get => _availableCars;
            set => _availableCars = value;
        }
    }
}
