using System.Collections.Generic;

namespace Cars.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Email { get; set; }
        string Name { get; set; }
        IEnumerable<string> OwnedCarsIds { get; set; }
    }
}
