using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class DetalleAgenteModel : PageModel
    {
        private readonly InterfaceRepositorioPersona irepositorioPersona;

        public AgenteTransito AgenteTransito {get;set;}

        public DetalleAgenteModel(InterfaceRepositorioPersona irepositorioPersona){
            this.irepositorioPersona=irepositorioPersona;
        }

        public IActionResult OnGet(int agenteId)
        {
            AgenteTransito=irepositorioPersona.GetAgente(agenteId);
            if(AgenteTransito==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }            
        }
    }
}
