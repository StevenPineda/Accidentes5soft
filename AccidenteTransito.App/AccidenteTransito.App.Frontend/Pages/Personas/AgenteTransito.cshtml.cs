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
    public class AgenteTransitoModel : PageModel
    {

        private readonly InterfaceRepositorioPersona irepositorioPersona;

        public IEnumerable<AgenteTransito> AgentesTransito {get; set;}
       
        [BindProperty]
        public AgenteTransito AgenteTransito {get;set;}

        public AgenteTransitoModel(InterfaceRepositorioPersona irepositorioPersona){
            this.irepositorioPersona=irepositorioPersona;
        }

        public void OnGet()
        {
            AgentesTransito=irepositorioPersona.GetAllAgentes();          
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                irepositorioPersona.AddPersona(AgenteTransito);
                if(AgenteTransito!=null){

                }
                return RedirectToPage("../Personas/AgenteTransito");
            }
            else
            {
                return Page();
            }
        }
    }
}
