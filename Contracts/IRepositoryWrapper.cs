using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IUsuarioRepository Usuario { get; }
        IRolRepository Rol { get; }
        IPantallaRepository Pantalla { get; }
        IOrdenCompraRepository OrdenCompra { get; }
        IOrdenCompraDetalleRepository OrdenCompraDetalle { get; }
    }
}
