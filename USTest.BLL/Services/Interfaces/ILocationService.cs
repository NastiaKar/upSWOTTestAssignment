using USTest.Common.Models.Domain;

namespace USTest.BLL.Services.Interfaces;

public interface ILocationService
{
    Task<Location> GetLocation(int id);
}