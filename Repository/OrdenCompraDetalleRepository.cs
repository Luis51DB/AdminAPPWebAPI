using Contracts;
using Entities;
using Entities.Modelos;
 
namespace Repository
{
    public class OrdenCompraDetalleRepository : RepositoryBase<OrdenCompraDetalle>, IOrdenCompraDetalleRepository
    {
        public OrdenCompraDetalleRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
