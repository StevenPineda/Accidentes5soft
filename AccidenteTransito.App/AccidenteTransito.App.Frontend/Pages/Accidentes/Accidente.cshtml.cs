using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;

namespace AccidenteTransito.App.Frontend.Pages
{
    
    public class AccidenteModel : PageModel
    {
        private readonly InterfaceRepositorioAccidente irepositorioAccidente;
        private readonly InterfaceRepositorioVehiculo irepositorioVehiculo;

        public IEnumerable<Accidente> Accidentes {get; set;}
        public IEnumerable<Vehiculo> Vehiculos {get; set;}

       
        [BindProperty]
        public Accidente Accidente {get;set;}

        public AccidenteModel(InterfaceRepositorioAccidente irepositorioAccidente,
        InterfaceRepositorioVehiculo irepositorioVehiculo){
            this.irepositorioAccidente=irepositorioAccidente;
            this.irepositorioVehiculo=irepositorioVehiculo;
        }

        public void OnGet()
        {
            Accidentes=irepositorioAccidente.GetAllAccidentes();
            Vehiculos=irepositorioVehiculo.GetAllVehiculos();            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                irepositorioAccidente.AddAccidente(Accidente);
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



