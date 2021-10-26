using System;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class ServiciosSalud : DbContext

    {
       public ServiciosSalud( DbContextOptions options) : base(options)
    {
    }
    public DbSet<Afiliado> Afiliados { get; set; }
    
    }
}
