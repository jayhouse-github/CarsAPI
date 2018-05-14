using System.Collections.Generic;
using Cars.Interfaces;
using Newtonsoft.Json;

namespace Cars.BL
{
    public class User : IUser
    {
        private string _email;
        private string _name;
        private IEnumerable<string> _ownedCars;
        private int _id;

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

        [JsonIgnore]
        public IEnumerable<string> OwnedCarsIds
        {
            get => _ownedCars;
            set => _ownedCars = value;
        }
    }
}
