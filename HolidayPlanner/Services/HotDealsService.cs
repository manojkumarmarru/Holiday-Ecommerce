public class HotDealsService {
    private readonly IHotDealsRepository _repository;

    public HotDealsService(IHotDealsRepository repository){
        _repository = repository;
    }

    public async Task<List<HotDeals>> GetAllAsync(){
        return await _repository.GetHotDealsAsync();
    }

    public async Task<HotDeals?> GetByIdAsync(string id){
        return await _repository.GetHotDealByIdAsync(id);
    }

    public async Task AddAsync(HotDeals hotDeal){
        await _repository.CreateHotDealAsync(hotDeal);
    }

    public async Task UpdateAsync(string id, HotDeals hotDeal){
        await _repository.UpdateHotDealAsync(id, hotDeal);
    }

    public async Task DeleteAsync(string id){
        await _repository.DeleteHotDealAsync(id);
    }
}