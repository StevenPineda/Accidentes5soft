using System.Collections.Generic;
using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class EditarModel : PageModel
    {
        private readonly InterfaceRepositorioAccidente irepositorioAccidente;
        private readonly InterfaceRepositorioVehiculo irepositorioVehiculo;

        public IEnumerable<Accidente> Accidentes {get; set;}
        public IEnumerable<Vehiculo> Vehiculos {get; set;}
       
        [BindProperty]
        public Accidente Accidente {get;set;}

        public EditarModel(InterfaceRepositorioAccidente irepositorioAccidente,
        InterfaceRepositorioVehiculo irepositorioVehiculo){
            this.irepositorioAccidente=irepositorioAccidente;
            this.irepositorioVehiculo=irepositorioVehiculo;
        }

        public IActionResult OnGet(int accidenteId)
        {
            Accidente=irepositorioAccidente.GetAccidente(accidenteId);
            Vehiculos=irepositorioVehiculo.GetAllVehiculos(); 
            if(Accidente==null){
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
                irepositorioAccidente.UpdateAccidente(Accidente);
                if(Accidente!=null){

                }
                return RedirectToPage("../Accidentes/Accidente");
            }
            else
            {
                return Page();
            }
        }
    }
}
