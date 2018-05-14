using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Cars.Interfaces;
using Cars.Services;

namespace Cars.Tests
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public async System.Threading.Tasks.Task WhenGetUsersAsyncIsCalled_RepositoryGetUsersShouldBeCalledAsync()
        {
            //Arrange         
            var fakeRepository = new Mock<ICarsRepository>();
            var service = new CarsService(fakeRepository.Object);

            //Act
            var result = await service.GetUsersAsync();

            //Assert
            fakeRepository.Verify(x => x.GetUsers());
        }

        [TestMethod]
        public async System.Threading.Tasks.Task WhenGetManufacturersAsyncIsCalled_RepositoryGetManufacturersShouldBeCalledAsync()
        {
            //Arrange         
            var fakeRepository = new Mock<ICarsRepository>();
            var service = new CarsService(fakeRepository.Object);

            //Act
            var result = await service.GetManufacturersAsync();

            //Assert
            fakeRepository.Verify(x => x.GetManufacturers());
        }

        [TestMethod]
        public async System.Threading.Tasks.Task WhenGetUserAsyncIsCalled_RepositoryGetUsersShouldBeCalledAsync()
        {
            //Arrange         
            var fakeRepository = new Mock<ICarsRepository>();
            var service = new CarsService(fakeRepository.Object);

            //Act
            var result = await service.GetUserDetailsByIdAsync(It.IsAny<int>());

            //Assert
            fakeRepository.Verify(x => x.GetUsers());
        }

        [TestMethod]
        public async System.Threading.Tasks.Task WhenGetUserAsyncIsCalled_RepositoryGetManufacturersShouldBeCalledAsync()
        {
            //Arrange         
            var fakeRepository = new Mock<ICarsRepository>();
            var service = new CarsService(fakeRepository.Object);

            //Act
            var result = await service.GetUserDetailsByIdAsync(It.IsAny<int>());

            //Assert
            fakeRepository.Verify(x => x.GetManufacturers());
        }

        [TestMethod]
        public async System.Threading.Tasks.Task WhenGetUserAsyncIsCalled_RepositoryGetCarsShouldBeCalledAsync()
        {
            //Arrange         
            var fakeRepository = new Mock<ICarsRepository>();
            var service = new CarsService(fakeRepository.Object);

            //Act
            var result = await service.GetUserDetailsByIdAsync(It.IsAny<int>());

            //Assert
            fakeRepository.Verify(x => x.GetCars());
        }
    }
}
