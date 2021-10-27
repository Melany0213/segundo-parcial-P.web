using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class LiquidacionMes    
    {
        [Key]
        public int mes { get; set; }
        public int año { get; set; }
        public int Id { get; set; }
        public decimal valor { get; set; }

        public LiquidacionMes()
        {}
        public LiquidacionMes(int mes, int año, int Id, DateTime fechaAfiliacion)
        {
         mes = mes;
         año = año;
         Id = Id;
         valor = valor;


        }
         }
}