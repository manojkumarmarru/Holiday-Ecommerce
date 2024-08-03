public class DestinationService
{
    private readonly IDestinationRepository _repository;

    public DestinationService(IDestinationRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Destination>> GetAllAsync() => await _repository.GetAllAsync();
    public async Task<Destination?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task AddAsync(Destination destination) => await _repository.AddAsync(destination);
    public async Task UpdateAsync(Destination destination) => await _repository.UpdateAsync(destination);
    public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
}