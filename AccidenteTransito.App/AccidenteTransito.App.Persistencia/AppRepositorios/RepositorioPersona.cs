using System.Collections.Generic;
using System.Linq;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public class RepositorioPersona:InterfaceRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext){
            _appContext=appContext;
        }

        Persona InterfaceRepositorioPersona.AddPersona(Persona persona){
            var personaAdicionado=_appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }

        void InterfaceRepositorioPersona.DeletePersona(int Id){
            var personaEncontrado=_appContext.Personas.FirstOrDefault(a => a.Id==Id);
            if(personaEncontrado==null)
            return;
            _appContext.Remove(personaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> InterfaceRepositorioPersona.GetAllPersonas(){
            return _appContext.Personas;
        }

        Persona InterfaceRepositorioPersona.GetPersona(int Id){
            return _appContext.Personas.FirstOrDefault(a => a.Id==Id);
        }

        Persona InterfaceRepositorioPersona.UpdatePersona(Persona persona){
            var personaEncontrado=_appContext.Personas.FirstOrDefault(a => a.Id==persona.Id);
            if(personaEncontrado!=null){
                personaEncontrado.Documento=persona.Documento;
                personaEncontrado.Nombres=persona.Nombres;
                personaEncontrado.Apellidos=persona.Apellidos;
                personaEncontrado.Edad=persona.Edad;
                personaEncontrado.Genero=persona.Genero;
                personaEncontrado.Telefono=persona.Telefono;
                personaEncontrado.Email=persona.Email;
                
                _appContext.SaveChanges();
            }
            return personaEncontrado;
        }
    }
}