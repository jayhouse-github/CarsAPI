using System.Collections.Generic;
using Cars.Interfaces;
using Cars.BL;

namespace Cars.StaticRepository
{
    public class CarsStaticRepository : ICarsRepository
    {
        public IEnumerable<IUser> GetUsers()
        {
            return new List<IUser>
            {
                new User
                {
                    Id = 1,
                    Email = "email1@email.com",
                    Name = "Jamie",
                    OwnedCarsIds = new List<string>
                    {
                        "M31 JMS",
                        "HA51 XON"
                    }
                },
                new User
                {
                    Id = 2,
                    Email = "email2@email.com",
                    Name = "Bob",
                    OwnedCarsIds = new List<string>
                    {
                        "M10 JHG",
                        "HA1 DFU",
                        "YH23 4VC"
                    }
                },
                new User
                {
                    Id = 3,
                    Email = "email3@email.com",
                    Name = "Steve",
                    OwnedCarsIds = new List<string>
                    {
                        "I31 OKN",
                        "J32 HGF"
                    }
                },
                new User
                {
                    Id = 4,
                    Email = "email4@email.com",
                    Name = "Helen",
                    OwnedCarsIds = new List<string>
                    {
                        "Y12 MCD"
                    }
                },
                new User
                {
                    Id = 5,
                    Email = "email5@email.com",
                    Name = "Sarah",
                    OwnedCarsIds = new List<string>
                    {
                        "W23 DFR"
                    }
                },
                new User
                {
                    Id = 6,
                    Email = "email6@email.com",
                    Name = "Jane",
                    OwnedCarsIds = new List<string>
                    {
                        "R23 EFC"
                    }
                }
            };
        }

        public IEnumerable<IUserCar> GetUserCars()
        {
            return new List<IUserCar>
            {
                new UserCar
                {
                    PlateNumber = "M31 JMS",
                    CarId = 1
                },
                new UserCar
                {
                    PlateNumber = "HA51 XON",
                    CarId = 2
                },
                new UserCar
                {
                    PlateNumber = "M10 JHG",
                    CarId = 1
                },
                new UserCar
                {
                    PlateNumber = "HA1 DFU",
                    CarId = 3
                },
                new UserCar
                {
                    PlateNumber = "YH23 4VC",
                    CarId = 4
                },
                new UserCar
                {
                    PlateNumber = "I31 OKN",
                    CarId = 4
                },
                new UserCar
                {
                    PlateNumber = "J32 HGF",
                    CarId = 2
                },
                new UserCar
                {
                    PlateNumber = "Y12 MCD",
                    CarId = 1
                },
                new UserCar
                {
                    PlateNumber = "W23 DFR",
                    CarId = 1
                },
                new UserCar
                {
                    PlateNumber = "R23 EFC",
                    CarId = 1
                }
            };
        }

        public IEnumerable<ICar> GetCars()
        {
            return new List<ICar>
            {
                new Car
                {
                    Id = 1,
                    Model = "Fiesta",
                    Year = 2007,
                    ManufacturerId = 1
                },
                new Car
                {
                    Id = 2,
                    Model = "Ka",
                    Year = 2014,
                    ManufacturerId = 1
                },
                new Car
                {
                    Id = 3,
                    Model = "911",
                    Year = 2004,
                    ManufacturerId = 2
                },
                new Car
                {
                    Id = 4,
                    Model = "Megane",
                    Year = 2015,
                    ManufacturerId = 3
                },
                new Car
                {
                    Id = 5,
                    Model = "Punto",
                    Year = 2014,
                    ManufacturerId = 4
                },
                new Car
                {
                    Id = 6,
                    Model = "Panda",
                    Year = 2005,
                    ManufacturerId = 4
                }
            };
        }

        public IEnumerable<IManufacturer> GetManufacturers()
        {
            return new List<IManufacturer>
            {
                new Manufacturer
                {
                    Id = 1,
                    Country = "USA",
                    Name = "Ford"
                },
                new Manufacturer
                {
                    Id = 2,
                    Country = "UK",
                    Name = "Porche"
                },
                new Manufacturer
                {
                    Id = 3,
                    Country = "France",
                    Name = "Renault"
                },
                new Manufacturer
                {
                    Id = 4,
                    Country = "Italy",
                    Name = "Fiat"
                }
            };
        }
    }
}

