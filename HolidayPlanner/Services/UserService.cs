public class UserService{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository){
        _repository = repository;
    }

    public async Task<List<User>> GetAllAsync(){
        return await _repository.GetAllAsync();
    }
    public async Task<User?> GetByIdAsync(string id){
        return await _repository.GetByIdAsync(id);
    }
    public async Task AddAsync(User user){
        await _repository.AddAsync(user);
    }
    public async Task UpdateAsync(User user){
        await _repository.UpdateAsync(user);
    }
    public async Task DeleteAsync(string id){
        await _repository.DeleteAsync(id);
    }
}