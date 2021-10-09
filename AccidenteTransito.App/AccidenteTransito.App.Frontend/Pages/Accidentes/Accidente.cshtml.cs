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

        public IEnumerable<Accidente> Accidentes {get; set;}
        public Accidente AccidenteId {get;set;}

        public AccidenteModel(InterfaceRepositorioAccidente irepositorioAccidente){
            this.irepositorioAccidente=irepositorioAccidente;
        }

        public void OnGet()
        {
            Accidentes=irepositorioAccidente.GetAllAccidentes();            
        }

        //public void OnPost(){
        //    irepositorioAccidente.UpdateAccidente
        //}
    }
}



