using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cars.Interfaces
{
    public interface ICarsService
    {
        Task<IEnumerable<object>> GetUsersAsync();
        Task<IEnumerable<IManufacturerWithCars>> GetManufacturersAsync();
        Task<IUserWithCars> GetUserDetailsByIdAsync(int id);
    }
}
