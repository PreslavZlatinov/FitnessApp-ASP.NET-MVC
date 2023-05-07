using FitnessApp_PreslavZlatinov_19621621.Models;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public interface IAthletesService
    {
        Task<IEnumerable<Athlete>> GetAllAsync();
        Task<Athlete> GetByIdAsync(int id);
        Task AddAsync(Athlete athlete);
        Task<Athlete> UpdateAsync(int id, Athlete newAthlete);
        Task DeleteAsync(int id);
    }
}
