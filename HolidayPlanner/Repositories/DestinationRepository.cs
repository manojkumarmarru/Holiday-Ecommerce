using Microsoft.EntityFrameworkCore;

public class DestinationRepository : IDestinationRepository
{
    private readonly ApplicationDbContext _context;

    public DestinationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Destination>> GetAllAsync() => await _context.Destinations.ToListAsync();
    public async Task<Destination?> GetByIdAsync(string id)
    {
        return await _context.Destinations.FindAsync(id);
    }

    public async Task AddAsync(Destination destination) { _context.Destinations.Add(destination); await _context.SaveChangesAsync(); }
    public async Task UpdateAsync(Destination destination) { _context.Destinations.Update(destination); await _context.SaveChangesAsync(); }
    public async Task DeleteAsync(string id)
    {
        var destination = await _context.Destinations.FindAsync(id);
        if (destination != null)
        {
            _context.Destinations.Remove(destination);
            await _context.SaveChangesAsync();
        }
    }
}