public class BookingService{
    private readonly IBookingRepository _repository;

    public BookingService(IBookingRepository repository){
        _repository = repository;
    }

    public async Task<List<Booking>> GetAllAsync(){
        return await _repository.GetAllAsync();
    }
    public async Task<Booking?> GetByIdAsync(string id){
        return await _repository.GetByIdAsync(id);
    }
    public async Task AddAsync(Booking booking){
        await _repository.AddAsync(booking);
    }
    public async Task UpdateAsync(Booking booking){
        await _repository.UpdateAsync(booking);
    }
    public async Task DeleteAsync(string id){
        await _repository.DeleteAsync(id);
    }
}