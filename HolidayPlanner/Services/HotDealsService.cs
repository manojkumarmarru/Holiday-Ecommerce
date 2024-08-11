using System.ComponentModel.DataAnnotations;

public class HotDealsService {
    private readonly IHotDealsRepository _repository;

    public HotDealsService(IHotDealsRepository repository){
        _repository = repository;
    }

    public async Task<List<HotDeals>> GetAllAsync(){
        return await _repository.GetHotDealsAsync();
    }

    public async Task<HotDeals?> GetByIdAsync(string id){
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("Hot Deal ID cannot be null or empty.", nameof(id));
        return await _repository.GetHotDealByIdAsync(id);
    }

    public async Task AddAsync(HotDeals hotDeal){
        ValidateHotDeal(hotDeal);
        await _repository.CreateHotDealAsync(hotDeal);
    }

    public async Task UpdateAsync(string id, HotDeals hotDeal){
        ValidateHotDeal(hotDeal);
        await _repository.UpdateHotDealAsync(id, hotDeal);
    }

    public async Task DeleteAsync(string id){
        if(string.IsNullOrEmpty(id))
            throw new ArgumentException("Hot Deal ID cannot be null or empty.", nameof(id));
        await _repository.DeleteHotDealAsync(id);
    }

    private void ValidateHotDeal(HotDeals hotDeal){
        if(hotDeal.DestinationId == null || hotDeal.DestinationId == ""){
            throw new Exception("DestinationId cannot be empty");
        }
        if(hotDeal.Name == null || hotDeal.Name == ""){
            throw new Exception("Name cannot be empty");
        }
        var context = new ValidationContext(hotDeal, serviceProvider: null, items: null);
        var results = new List<ValidationResult>();

        if (!Validator.TryValidateObject(hotDeal, context, results, true))
        {
            throw new ValidationException("Hot Deal validation failed.");
        }
    }
}