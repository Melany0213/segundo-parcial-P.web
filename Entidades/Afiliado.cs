using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Afiliado    
    {
        [Key]
        public String TipoId { get; set; }
        public String Name { get; set; }
        
        public DateTime fecha { get; set; }

        public DateTime fechaAfiliacion { get; set;}

        public String Estado { get; set; }
    

    public Afiliado()
    {

    }

    public Afiliado(String tipoId, String name, DateTime fecha, DateTime fechaAfiliacion, String Estado)
    {
    tipoId = tipoId;
    Name = Name;
    fecha = fecha;
    fechaAfiliacion = fechaAfiliacion;
    Estado = Estado;

    }

    }
}
