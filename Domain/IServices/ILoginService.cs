﻿using ProyectoTituloBackend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTituloBackend.Domain.IServices
{
   public interface ILoginService
    {

        Task<Usuario> ValidateUser(Usuario usuario);

    }
}
