using USTest.Common.Models.Domain;

namespace USTest.BLL.Services.Interfaces;

public interface IEpisodeService
{
    public Task<IEnumerable<Episode>> GetEpisode(string name);
}