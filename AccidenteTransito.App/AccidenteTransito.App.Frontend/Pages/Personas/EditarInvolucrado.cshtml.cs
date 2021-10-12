using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class EditarInvolucradoModel : PageModel
    {
        private readonly InterfaceRepositorioPersona irepositorioPersona;

        [BindProperty]
        public Involucrado Involucrado {get;set;}

        public EditarInvolucradoModel(InterfaceRepositorioPersona irepositorioPersona){
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
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                irepositorioPersona.UpdateInvolucrado(Involucrado);
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
