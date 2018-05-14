namespace Cars.Interfaces
{
    public interface ICar
    {
        int Id { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        int ManufacturerId { get; set; }
    }
}
