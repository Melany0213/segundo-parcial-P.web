using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class LiquidacionIndiv    
    {
        [Key]
        public int mes { get; set; }
        public int año { get; set; }
        public string Tipo { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaAfiliacion { get; set; }
        public int daisAfiliados { get; set; }
        public decimal valor { get; set; }

        public LiquidacionIndiv()
        {}
        public LiquidacionIndiv(int mes, int año, string Tipo,int Id,string Name, DateTime fechaNacimiento, DateTime fechaAfiliacion)
        {
         mes = mes;
         año = año;
         Tipo = Tipo;
         Id = Id;
         Name = Name;
         fechaNacimiento = fechaNacimiento;
         fechaAfiliacion = fechaAfiliacion;
         daisAfiliados = daisAfiliados;
         valor = valor;


        }
         }
}