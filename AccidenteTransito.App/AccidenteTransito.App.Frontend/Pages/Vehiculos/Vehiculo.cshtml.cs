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
    public class VehiculoModel : PageModel
    {
        private readonly InterfaceRepositorioVehiculo irepositorioVehiculo;

        public IEnumerable<Vehiculo> Vehiculos {get; set;}

       
        [BindProperty]
        public Vehiculo Vehiculo {get;set;}

        public VehiculoModel(InterfaceRepositorioVehiculo irepositorioVehiculo){
            this.irepositorioVehiculo=irepositorioVehiculo;
        }

        public void OnGet()
        {
            Vehiculos=irepositorioVehiculo.GetAllVehiculos();            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                irepositorioVehiculo.AddVehiculo(Vehiculo);
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
