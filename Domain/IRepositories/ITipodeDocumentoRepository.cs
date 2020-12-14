using ProyectoTituloBackend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTituloBackend.Domain.IRepositories
{
   public interface ITipodeDocumentoRepository
    {

        Task <List<TipoDocumento>> GetListTipoDocumento();
    }
}
