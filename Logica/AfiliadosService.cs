using System;

namespace Logica
{
    public class AfiliadoService
    {
       private readonly AfiliadoService context;
       public AfiliadoService(AfiliadoService context) { this.context = context; }
       public AfiliadoService GuardarAfiliados(Afiliado afiliado){ 
           try
        {
            var afiliadoBuscado = context.Afiliados.Find(afiliado.AfiliadoId);
            if (afiliadoBuscado == null)
            {
            context.Afiliados.Add(afiliado);
            context.SaveChanges();
            return new AfiliadoResponse(afiliado);
            }
            return new AfiliadoResponse("El afiliado no fue agregado porque ya exixstía");
        }
        catch (Exception e)
        {
            return new AfiliadoResponse("HUbieron los siguientes errores:" + e.Message);
        }
        }
       public ListaPagosResponse BuscarPorEstado( string Estado){ 
         try
      {
        var afiliadosBuscado = context.Afiliados.Where(a => a.Estado == Estado).ToList();
        if (afiliadosBuscado == null)
        {
          return new AfiliadoResponse("No se encontraron los afiliados");
        }
        return new AfiliadoResponse(afiliadosBuscado);
      }
      catch (System.Exception ex)
      {
        return new AfiliadoResponse("Ocurrio el siguiente problema: " + ex.Message);
      }
    
        } 
    
      

    }
}
