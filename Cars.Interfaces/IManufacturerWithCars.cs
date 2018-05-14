using System.Collections.Generic;

namespace Cars.Interfaces
{
    public interface IManufacturerWithCars
    {
        int Id { get; set; }
        string Name { get; set; }
        string Country { get; set; }
        IEnumerable<ICar> AvailableCars { get; set; }
    }
}
