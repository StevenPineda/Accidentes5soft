using System.Collections.Generic;
using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class EditarVehiculoModel : PageModel
    {
        private readonly InterfaceRepositorioVehiculo irepositorioVehiculo;

        public IEnumerable<TipoVehiculo> TipoVehiculo {get; set;}

        [BindProperty]
        public Vehiculo Vehiculo {get;set;}

        public EditarVehiculoModel(InterfaceRepositorioVehiculo irepositorioVehiculo){
            this.irepositorioVehiculo=irepositorioVehiculo;
        }

        public IActionResult OnGet(int vehiculoId)
        {
            Vehiculo=irepositorioVehiculo.GetVehiculo(vehiculoId); 
            if(Vehiculo==null){
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
                irepositorioVehiculo.UpdateVehiculo(Vehiculo);
                if(Vehiculo!=null){

                }
                return RedirectToPage("../Vehiculos/Vehiculo");
            }
            else
            {
                return Page();
            }
        }
    }
}
