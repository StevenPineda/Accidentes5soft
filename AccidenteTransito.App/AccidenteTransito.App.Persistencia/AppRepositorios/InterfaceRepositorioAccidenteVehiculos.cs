using System.Collections.Generic;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public interface InterfaceRepositorioAccidenteVehiculos{
        IEnumerable<AccidenteVehiculos> GetAllAccidenteVehiculos();
 
        AccidenteVehiculos AddAccidenteVehiculos(AccidenteVehiculos AccidenteVehiculos);

        AccidenteVehiculos UpdateAccidenteVehiculos(AccidenteVehiculos AccidenteVehiculos);

        void DeleteAccidenteVehiculos(int Id);

        AccidenteVehiculos GetAccidenteVehiculos(int Id);   
    }
}