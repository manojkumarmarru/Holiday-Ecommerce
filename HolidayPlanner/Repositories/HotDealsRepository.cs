using Microsoft.EntityFrameworkCore;
public class HotDealsRepository : IHotDealsRepository
{
    private readonly ApplicationDbContext _context;

    public HotDealsRepository(ApplicationDbContext context){
        _context = context;
    }

    public async Task<List<HotDeals>> GetHotDealsAsync(){
        return await _context.HotDeals.ToListAsync();
    }

    public async Task<HotDeals?> GetHotDealByIdAsync(string id){
        return await _context.HotDeals.FindAsync(id);
    }

    public async Task CreateHotDealAsync(HotDeals hotDeal){
        _context.HotDeals.Add(hotDeal);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateHotDealAsync(string id, HotDeals hotDeal){
        _context.HotDeals.Update(hotDeal);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteHotDealAsync(string id){
        var hotDeal = await _context.HotDeals.FindAsync(id);
        if(hotDeal != null){
            _context.HotDeals.Remove(hotDeal);
            await _context.SaveChangesAsync();
        }
    }
}