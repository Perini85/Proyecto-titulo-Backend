using Microsoft.EntityFrameworkCore;
using ProyectoTituloBackend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTituloBackend.Persistence.Context
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Documento> Documentos { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext>options): base(options)
        {

        }


    }
}
