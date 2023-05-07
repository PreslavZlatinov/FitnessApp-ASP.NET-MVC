using FitnessApp_PreslavZlatinov_19621621.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public class AthletesService : IAthletesService
    {
        private readonly AppDbContext _context;

        public AthletesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Athlete athlete)
        {
           await _context.Athletes.AddAsync(athlete);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Athletes.FirstOrDefaultAsync(n => n.Id == id);
            _context.Athletes.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Athlete>> GetAllAsync()
        {
            var result = await _context.Athletes.ToListAsync();
            return result;
        }

        public async Task<Athlete> GetByIdAsync(int id)
        {
            var result = await _context.Athletes.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Athlete> UpdateAsync(int id, Athlete newAthlete)
        {
            _context.Update(newAthlete);
            await _context.SaveChangesAsync();
            return newAthlete;
        }
    }
}
