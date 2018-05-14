using System.Collections.Generic;
using Cars.Interfaces;

namespace Cars.BL.Models
{
    public class UserWithCars : IUserWithCars
    {
        private int _id;
        private string _email;
        private string _name;
        private IEnumerable<ICarWithManufacturer> _ownedCars;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public IEnumerable<ICarWithManufacturer> OwnedCars
        {
            get => _ownedCars;
            set => _ownedCars = value;
        }
    }
}
