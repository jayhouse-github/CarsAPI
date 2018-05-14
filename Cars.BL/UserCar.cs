using Cars.Interfaces;

namespace Cars.BL
{
    public class UserCar : IUserCar
    {
        private string _plateNumber;
        private int _car;

        public string PlateNumber
        {
            get => _plateNumber;
            set => _plateNumber = value;
        }

        public int CarId
        {
            get => _car;
            set => _car = value;
        }
    }
}
