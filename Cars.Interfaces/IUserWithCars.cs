using System.Collections.Generic;

namespace Cars.Interfaces
{
    public interface IUserWithCars
    {
        int Id { get; set; }
        string Email { get; set; }
        string Name { get; set; }
        IEnumerable<ICarWithManufacturer> OwnedCars { get; set; }
    }
}
