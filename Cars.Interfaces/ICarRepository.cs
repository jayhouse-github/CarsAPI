using System.Collections.Generic;

namespace Cars.Interfaces
{
    public interface ICarsRepository
    {
        IEnumerable<IUser> GetUsers();
        IEnumerable<IUserCar> GetUserCars();
        IEnumerable<ICar> GetCars();
        IEnumerable<IManufacturer> GetManufacturers();
    }
}
