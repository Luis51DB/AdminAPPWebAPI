using Contracts;
using Entities;
using Entities.Modelos;
 
namespace Repository
{
    public class ProveedorRepository : RepositoryBase<Proveedor>, IProveedorRepository
    {
        public ProveedorRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
