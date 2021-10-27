using System;

namespace Datos
{
    public class ServiciosSalud : DbContext

    {
       public ServiciosSalud( DbContextOptions options) : base(options)
    {}
    public DbSet<Afiliado> Afiliados { get; set; }
    public DbSet<LiquidacionIndiv> LiquidacionIndivS { get; set; }
    public DbSet<LiquidacionMes> LiquidacionMesS { get; set; }
    
    }
}
