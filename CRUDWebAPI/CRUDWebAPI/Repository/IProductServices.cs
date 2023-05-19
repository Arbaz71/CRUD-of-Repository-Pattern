using CRUDWebAPI.Model;
using WireMock.Admin.Mappings;

namespace CRUDWebAPI.Repository
{
    public interface IProductServices
    {
        //public ResponseModel Get(int id);
        //public IEnumerable<ProductServices> GetAll();
        //public ResponseModel Post(ProductServices products);
        //public ResponseModel Put(ProductServices products);
        //public ResponseModel Delete(int id);
       public Task<IEnumerable<Product>> GetAll();
        public Task<Product> GetByIdAsync(int id);
        public Task AddAsync(Product product);
        public void Update(Product product);
        public void Delete(Product product);
    }
}
