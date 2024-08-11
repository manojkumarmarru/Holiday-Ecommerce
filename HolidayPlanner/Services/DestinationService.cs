using System.ComponentModel.DataAnnotations;

public class DestinationService
{
    private readonly IDestinationRepository _repository;

    public DestinationService(IDestinationRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Destination>> GetAllAsync(){ 
        return await _repository.GetAllAsync();
    }
    public async Task<Destination?> GetByIdAsync(string id)
    {
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("Destination ID cannot be null or empty.", nameof(id));
        return await _repository.GetByIdAsync(id);
    }
    public async Task AddAsync(Destination destination){
        ValidateDestination(destination);
        await _repository.AddAsync(destination);
    }
    public async Task UpdateAsync(Destination destination){
        ValidateDestination(destination);
        await _repository.UpdateAsync(destination);
    }
    public async Task DeleteAsync(string id){
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("Destination ID cannot be null or empty.", nameof(id));
        await _repository.DeleteAsync(id);
    }

    private void ValidateDestination(Destination destination){
        if(destination.DestinationId == null || destination.DestinationId == ""){
            throw new Exception("DestinationId cannot be empty");
        }
        if(destination.Name == null || destination.Name == ""){
            throw new Exception("Name cannot be empty");
        }
        var context = new ValidationContext(destination, serviceProvider: null, items: null);
        var results = new List<ValidationResult>();

        if (!Validator.TryValidateObject(destination, context, results, true))
        {
            throw new ValidationException("Destination validation failed.");
        }
    }
}