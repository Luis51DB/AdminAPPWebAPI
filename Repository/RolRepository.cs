using Contracts;
using Entities;
using Entities.Modelos;

namespace Repository
{
    public class RolRepository : RepositoryBase<Rol>, IRolRepository
    {
        public RolRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
