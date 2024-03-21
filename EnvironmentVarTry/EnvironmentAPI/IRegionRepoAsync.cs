namespace EnvironmentAPI;

public interface IRegionRepoAsync<T> where T: class
{
    Task<int> Insert(T entity);
    Task<IEnumerable<T>> GetAll();
}