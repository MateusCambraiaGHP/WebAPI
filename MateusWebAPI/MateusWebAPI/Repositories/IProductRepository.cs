using MateusWebAPI.Model;

namespace MateusWebAPI.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> Get();
        Task<Product> Get(int id);
        Task<Product> Create(Product product);
        Task Update(Product product);
        Task Delete(int id); 

    }
}
