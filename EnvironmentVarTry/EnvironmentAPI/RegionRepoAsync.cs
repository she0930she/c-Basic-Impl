using Microsoft.EntityFrameworkCore;

namespace EnvironmentAPI;

public class RegionRepoAsync: IRegionRepoAsync<Region>
{
    private readonly EShopDbContext _eShopDb;

    public RegionRepoAsync(EShopDbContext eShopDb)
    {
        _eShopDb = eShopDb;
    }

    public async Task<int> Insert(Region entity)
    {
        await _eShopDb.Set<Region>().AddAsync(entity);
        return await _eShopDb.SaveChangesAsync();
    }

    public async Task<IEnumerable<Region>> GetAll()
    {
        return await _eShopDb.Set<Region>().ToListAsync();
    }
}