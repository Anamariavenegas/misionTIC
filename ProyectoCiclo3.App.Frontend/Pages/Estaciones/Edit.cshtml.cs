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
    public class EditEstacionModel : PageModel
    {
       private readonly RepositorioEstaciones repositorioEstaciones;
            [BindProperty]
            public Estaciones Estacion {get;set;}
 
        public EditEstacionModel(RepositorioEstaciones repositorioEstaciones)
       {
            this.repositorioEstaciones=repositorioEstaciones;
       }
 
        public IActionResult OnGet(int estacionId)
        {
                Estacion=repositorioEstaciones.GetEstacionWithId(estacionId);
                return Page();
 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Estacion.id>0)
            {
            Estacion = repositorioEstaciones.Update(Estacion);
            }
            return RedirectToPage("./List");
        }

    }
}