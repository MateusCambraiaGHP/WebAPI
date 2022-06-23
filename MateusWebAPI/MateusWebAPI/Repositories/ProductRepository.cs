using MateusWebAPI.Interfaces;
using MateusWebAPI.Model;

namespace MateusWebAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IApplicationDbContext _db;
        public ProductRepository(IApplicationDbContext db)
        {
            _db = db;
        }

        public Task<Product> Create(Product product)
        {
            _db.product.Add(product);
            _db.Save();
            return Ok();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
