using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    [Authorize]
    public class DetailsRutaModel : PageModel
    {
       private readonly RepositorioRutas repositorioRutas;
              public Rutas Ruta {get;set;}
 
        public DetailsRutaModel(RepositorioRutas repositorioRutas)
       {
            this.repositorioRutas=repositorioRutas;
       }
 
        public IActionResult OnGet(int rutaId)
        {
                Ruta=repositorioRutas.GetRutaWithId(rutaId);
                return Page();
 
        }
    }
}