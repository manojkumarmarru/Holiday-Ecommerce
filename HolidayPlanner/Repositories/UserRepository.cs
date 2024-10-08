using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllAsync(){
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> GetByIdAsync(string id){
        return await _context.Users.FindAsync(id);
    }

    public async Task AddAsync(User user){
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user){
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id){
        var user = await _context.Users.FindAsync(id);
        if(user != null){
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}