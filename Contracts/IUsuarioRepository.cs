﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Modelos;

namespace Contracts
{
    public interface IUsuarioRepository: IRepositoryBase<Usuario>
    {
        Usuario GetUsuarioByEmail(Usuario user);
    }
}
