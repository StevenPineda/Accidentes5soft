using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class EditarAgenteModel : PageModel
    {
        private readonly InterfaceRepositorioPersona irepositorioPersona;

        [BindProperty]
        public AgenteTransito AgenteTransito {get;set;}

        public EditarAgenteModel(InterfaceRepositorioPersona irepositorioPersona){
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
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                irepositorioPersona.UpdateAgente(AgenteTransito);
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
