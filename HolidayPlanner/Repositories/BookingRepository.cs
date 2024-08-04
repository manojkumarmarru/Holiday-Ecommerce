using Microsoft.EntityFrameworkCore;

public class BookingRepository : IBookingRepository
{
    private readonly ApplicationDbContext _context;

    public BookingRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Booking>> GetAllAsync(){
        return await _context.Bookings.ToListAsync();
    }

    public async Task<Booking?> GetByIdAsync(String id){
        return await _context.Bookings.FindAsync(id);
    }

    public async Task AddAsync(Booking booking){
        _context.Bookings.Add(booking);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Booking booking){
        _context.Bookings.Update(booking);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id){
        var booking = await _context.Bookings.FindAsync(id);
        if(booking != null){
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
    }
}