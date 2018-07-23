using Contracts;
using Entities;
using Entities.Modelos;

namespace Repository
{
    public class PantallaRepository : RepositoryBase<Pantalla>, IPantallaRepository
    {
        public PantallaRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
