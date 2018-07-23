using Contracts;
using Entities;
using Entities.Modelos;
 
namespace Repository
{
    public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
    {
        public ProductoRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
