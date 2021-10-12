using System.Collections.Generic;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public interface InterfaceRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();

        IEnumerable<AgenteTransito> GetAllAgentes();
 
        IEnumerable<Involucrado> GetAllInvolucrados();
        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);

        AgenteTransito UpdateAgente(AgenteTransito agente);

        Involucrado UpdateInvolucrado(Involucrado involucrado);

        void DeletePersona(int Id);

        Persona GetPersona(int Id);

        AgenteTransito GetAgente(int Id);

        Involucrado GetInvolucrado(int Id);
         
    }
}