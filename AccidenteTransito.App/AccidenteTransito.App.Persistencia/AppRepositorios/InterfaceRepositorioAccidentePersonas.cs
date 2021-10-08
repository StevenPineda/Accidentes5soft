using System.Collections.Generic;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public interface InterfaceRepositorioAccidentePersonas{
        IEnumerable<AccidentePersonas> GetAllAccidentePersonas();
 
        AccidentePersonas AddAccidentePersonas(AccidentePersonas AccidentePersonas);

        AccidentePersonas UpdateAccidentePersonas(AccidentePersonas AccidentePersonas);

        void DeleteAccidentePersonas(int Id);

        AccidentePersonas GetAccidentePersonas(int Id);         
    }
}