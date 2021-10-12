using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class InvolucradoModel : PageModel
    {
        private readonly InterfaceRepositorioPersona irepositorioPersona;

        public IEnumerable<Involucrado> Involucrados {get; set;}
       
        [BindProperty]
        public Involucrado Involucrado {get;set;}

        public InvolucradoModel(InterfaceRepositorioPersona irepositorioPersona){
            this.irepositorioPersona=irepositorioPersona;
        }

        public void OnGet()
        {
            Involucrados=irepositorioPersona.GetAllInvolucrados();          
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                irepositorioPersona.AddPersona(Involucrado);
                if(Involucrado!=null){

                }
                return RedirectToPage("../Personas/Involucrado");
            }
            else
            {
                return Page();
            }
        }
    }
}
