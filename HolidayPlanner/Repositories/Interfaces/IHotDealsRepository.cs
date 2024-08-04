public interface IHotDealsRepository{
    Task<List<HotDeals>> GetHotDealsAsync();
    Task<HotDeals?> GetHotDealByIdAsync(string id);
    Task CreateHotDealAsync(HotDeals hotDeal);
    Task UpdateHotDealAsync(string id, HotDeals hotDeal);
    Task DeleteHotDealAsync(string id);
}