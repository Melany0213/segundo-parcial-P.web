using System;
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    public class Afiliado    
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }        
        public DateTime fecha { get; set; }
        public DateTime fechaAfiliacion { get; set;}
        public String Estado { get; set; }
    
    public Afiliado()
    {

    }

    public Afiliado(int Id,String name, DateTime fecha, DateTime fechaAfiliacion, String Estado)
    {
    Id = Id;
    Name = Name;
    fecha = fecha;
    fechaAfiliacion = fechaAfiliacion;
    Estado = Estado;
    }

    }
}
