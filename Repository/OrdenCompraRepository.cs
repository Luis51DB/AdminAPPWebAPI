using Contracts;
using Entities;
using Entities.Modelos;
 
namespace Repository
{
    public class OrdenCompraRepository : RepositoryBase<OrdenCompra>, IOrdenCompraRepository
    {
        public OrdenCompraRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
