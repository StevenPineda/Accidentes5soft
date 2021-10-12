using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccidenteTransito.App.Frontend.Pages
{
    public class DetalleVehiculoModel : PageModel
    {
        private readonly InterfaceRepositorioVehiculo irepositorioVehiculo;

        public Vehiculo Vehiculo {get;set;}

        public  DetalleVehiculoModel(InterfaceRepositorioVehiculo irepositorioVehiculo){
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
    }
}
