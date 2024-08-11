using System.ComponentModel.DataAnnotations;

public class UserService{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository){
        _repository = repository;
    }

    public async Task<List<User>> GetAllAsync(){
        return await _repository.GetAllAsync();
    }
    public async Task<User?> GetByIdAsync(string id){
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("User ID cannot be null or empty.", nameof(id));
        return await _repository.GetByIdAsync(id);
    }
    public async Task AddAsync(User user){
        ValidateUser(user);
        await _repository.AddAsync(user);
    }
    public async Task UpdateAsync(User user){
        ValidateUser(user);
        await _repository.UpdateAsync(user);
    }
    public async Task DeleteAsync(string id){
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("User ID cannot be null or empty.", nameof(id));
        await _repository.DeleteAsync(id);
    }

    private void ValidateUser(User user){
        if(user.UserId == null || user.UserId == ""){
            throw new Exception("UserId cannot be empty");
        }
        if(user.Name == null || user.Name == ""){
            throw new Exception("Name cannot be empty");
        }
        if(user.EmailId == null || user.EmailId == ""){
            throw new Exception("EmailId cannot be empty");
        }
        if(user.ContactNo == 0){
            throw new Exception("ContactNo cannot be empty");
        }
        if(user.Password == null || user.Password == ""){
            throw new Exception("Password cannot be empty");
        }
        
        var context = new ValidationContext(user, serviceProvider: null, items: null);
        var results = new List<ValidationResult>();

        if (!Validator.TryValidateObject(user, context, results, true))
        {
            throw new ValidationException("User validation failed.");
        }
    }
}