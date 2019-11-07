using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Interfaces;
using Cars.BL.Models;

namespace Cars.Services
{
    public class CarsService : ICarsService
    {
        private readonly ICarsRepository _repo;

        public CarsService(ICarsRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<object>> GetUsersAsync()
        {
            return await Task.Run(() => GetUsers());
        }

        public async Task<IEnumerable<IManufacturerWithCars>> GetManufacturersAsync()
        {
            return await Task.Run(() => GetManufacturers());
        }

        public async Task<IUserWithCars> GetUserDetailsByIdAsync(int id)
        {
            return await Task.Run(() => GetUserDetailsById(id));
        }

        private IEnumerable<IUser> GetUsers()
        {
            return _repo.GetUsers();
        }

        private IEnumerable<IManufacturerWithCars> GetManufacturers()
        {
            var manufacturers = _repo.GetManufacturers();
            var cars = _repo.GetCars();

            return (manufacturers
                    .Select(manufacturerData => new
                    {
                        manufacturerData,
                        carModels = cars.Where(c => c.ManufacturerId == manufacturerData.Id)
                    })
                    .Select(@t => new ManufacturerWithCars
                    {
                        Id = @t.manufacturerData.Id,
                        Name = @t.manufacturerData.Name,
                        Country = @t.manufacturerData.Country,
                        AvailableCars = @t.carModels
                    })).Cast<IManufacturerWithCars>()
                .ToList();
        }

        private IUserWithCars GetUserDetailsById(int id)
        {
            var user = _repo.GetUsers().FirstOrDefault(u => u.Id == id);
            var userCars = _repo.GetUserCars();
            var cars = _repo.GetCars();
            var manufacturers = _repo.GetManufacturers();
            var ownedCarsWithManufacturer = new List<ICarWithManufacturer>();

            if (user == null) return null;

            var ownedUserCars = user.OwnedCarsIds.Select(plateNumber => userCars.FirstOrDefault(c => c.PlateNumber == plateNumber)).ToList();

            foreach (var car in ownedUserCars)
            {
                var carDetail = cars.FirstOrDefault(c => c.Id == car.CarId);
                var manufacturerDetail = manufacturers.FirstOrDefault(m => carDetail != null && m.Id == carDetail.ManufacturerId);
                if (carDetail != null)
                    ownedCarsWithManufacturer.Add(new CarWithManufacturer
                    {
                        PlateNumber = car.PlateNumber,
                        Id = car.CarId,
                        Model = carDetail.Model,
                        Year = carDetail.Year,
                        Manufacturer = manufacturerDetail
                    });
            }

            IUserWithCars userDetails = new UserWithCars
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                OwnedCars = ownedCarsWithManufacturer
            };

            return userDetails;
        }
    }
}

