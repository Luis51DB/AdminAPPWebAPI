using Contracts;
using Entities;
using Entities.Modelos;
using System.Linq;

namespace Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public Usuario GetUsuarioByEmail(Usuario user)
        {
            return FindByCondition(u => u.email.Equals(user.email) && u.password.Equals(user.password)).DefaultIfEmpty(new Usuario()).FirstOrDefault();
        }
    }
}
