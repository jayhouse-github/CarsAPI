namespace Cars.Interfaces
{
    public interface ICarWithManufacturer
    {
        int Id { get; set; }
        string PlateNumber { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        IManufacturer Manufacturer { get; set; }
    }
}
