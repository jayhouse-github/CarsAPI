using Cars.Interfaces;
using Cars.StaticRepository;

namespace Cars.RepoFactory
{
    public static class Repos
    {
        public static ICarsRepository GetCarRepo()
        {
            return new CarsStaticRepository();
        }
    }
}
