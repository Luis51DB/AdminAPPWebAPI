using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IUsuarioRepository _usuario;
        private IRolRepository _rol;
        private IPantallaRepository _pantalla;
        private IOrdenCompraRepository _ordenCompra;
        private IOrdenCompraDetalleRepository _ordenCompraDetalle;

        public IUsuarioRepository Usuario
        {
            get
            {
                if (_usuario == null)
                {
                    _usuario = new UsuarioRepository(_repoContext);
                }

                return _usuario;
            }
        }

        public IRolRepository Rol
        {
            get
            {
                if (_rol == null)
                {
                    _rol = new RolRepository(_repoContext);
                }

                return _rol;
            }
        }

        public IPantallaRepository Pantalla
        {
            get
            {
                if (_pantalla == null)
                {
                    _pantalla = new PantallaRepository(_repoContext);
                }

                return _pantalla;
            }
        }

        public IOrdenCompraRepository OrdenCompra
        {
            get
            {
                if (_ordenCompra == null)
                {
                    _ordenCompra = new OrdenCompraRepository(_repoContext);
                }

                return _ordenCompra;
            }
        }

        public IOrdenCompraDetalleRepository OrdenCompraDetalle
        {
            get
            {
                if (_ordenCompraDetalle == null)
                {
                    _ordenCompraDetalle = new OrdenCompraDetalleRepository(_repoContext);
                }

                return _ordenCompraDetalle;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}