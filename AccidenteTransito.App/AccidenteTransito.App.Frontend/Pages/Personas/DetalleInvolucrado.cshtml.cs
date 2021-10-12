using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class DetalleInvolucradoModel : PageModel
    {
         private readonly InterfaceRepositorioPersona irepositorioPersona;

        public Involucrado Involucrado {get;set;}

        public DetalleInvolucradoModel(InterfaceRepositorioPersona irepositorioPersona){
            this.irepositorioPersona=irepositorioPersona;
        }

        public IActionResult OnGet(int involucradoId)
        {
            Involucrado=irepositorioPersona.GetInvolucrado(involucradoId);
            if(Involucrado==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }            
        }
    }
}
