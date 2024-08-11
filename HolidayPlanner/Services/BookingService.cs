using System.ComponentModel.DataAnnotations;

public class BookingService{
    private readonly IBookingRepository _repository;

    public BookingService(IBookingRepository repository){
        _repository = repository;
    }

    public async Task<List<Booking>> GetAllAsync(){
        return await _repository.GetAllAsync();
    }
    public async Task<Booking?> GetByIdAsync(string id){
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("Booking ID cannot be null or empty.", nameof(id));
        return await _repository.GetByIdAsync(id);
    }
    public async Task AddAsync(Booking booking){
        ValidateBooking(booking);
        await _repository.AddAsync(booking);
    }
    public async Task UpdateAsync(Booking booking){
        ValidateBooking(booking);
        await _repository.UpdateAsync(booking);
    }
    public async Task DeleteAsync(string id){
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("Booking ID cannot be null or empty.", nameof(id));
        await _repository.DeleteAsync(id);
    }

    private void ValidateBooking(Booking booking){
        if(booking.BookingId == null || booking.BookingId == ""){
            throw new Exception("BookingId cannot be empty");
        }
        if(booking.DestinationName == null || booking.DestinationName == ""){
            throw new Exception("DestinationName cannot be empty");
        }
        var context = new ValidationContext(booking, serviceProvider: null, items: null);
        var results = new List<ValidationResult>();

        if (!Validator.TryValidateObject(booking, context, results, true))
        {
            throw new ValidationException("Booking validation failed.");
        }
    }
}