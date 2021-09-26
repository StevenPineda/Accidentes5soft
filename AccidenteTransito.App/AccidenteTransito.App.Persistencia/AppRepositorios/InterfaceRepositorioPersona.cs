using System.Collections.Generic;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public interface InterfaceRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
 
        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        void DeletePersona(int Id);

        Persona GetPersona(int Id);
         
    }
}