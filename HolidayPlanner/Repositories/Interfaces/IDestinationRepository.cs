public interface IDestinationRepository
{
    Task<List<Destination>> GetAllAsync();
    Task<Destination?> GetByIdAsync(string id);
    Task AddAsync(Destination destination);
    Task UpdateAsync(Destination destination);
    Task DeleteAsync(string id);
}