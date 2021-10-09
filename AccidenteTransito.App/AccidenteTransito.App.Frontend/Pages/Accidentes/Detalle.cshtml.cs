using System.Collections.Generic;
using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class DetalleModel : PageModel
    {
        private readonly InterfaceRepositorioAccidente irepositorioAccidente;

        public Accidente Accidente {get;set;}

        public DetalleModel(InterfaceRepositorioAccidente irepositorioAccidente){
            this.irepositorioAccidente=irepositorioAccidente;
        }

        public IActionResult OnGet(int accidenteId)
        {
            Accidente=irepositorioAccidente.GetAccidente(accidenteId);
            if(Accidente==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }            
        }
    }
}
