public interface IBookingRepository{
    Task<List<Booking>> GetAllAsync();
    Task<Booking?> GetByIdAsync(string id);
    Task AddAsync(Booking booking);
    Task UpdateAsync(Booking booking);
    Task DeleteAsync(string id);
}