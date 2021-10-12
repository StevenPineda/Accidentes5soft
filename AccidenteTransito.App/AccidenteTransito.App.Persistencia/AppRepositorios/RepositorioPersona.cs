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

        public RepositorioPersona(){
            _appContext=new AppContext();
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

        IEnumerable<AgenteTransito> InterfaceRepositorioPersona.GetAllAgentes(){
            return _appContext.Agente;
        }

        IEnumerable<Involucrado> InterfaceRepositorioPersona.GetAllInvolucrados(){
            return _appContext.Involucrados;
        }

        Persona InterfaceRepositorioPersona.GetPersona(int Id){
            return _appContext.Personas.FirstOrDefault(a => a.Id==Id);
        }
        AgenteTransito InterfaceRepositorioPersona.GetAgente(int Id){
            return _appContext.Agente.FirstOrDefault(a => a.Id==Id);
        }

        Involucrado InterfaceRepositorioPersona.GetInvolucrado(int Id){
            return _appContext.Involucrados.FirstOrDefault(a => a.Id==Id);
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

        AgenteTransito InterfaceRepositorioPersona.UpdateAgente(AgenteTransito agente){
            var agenteEncontrado=_appContext.Agente.FirstOrDefault(a => a.Id==agente.Id);
            if(agenteEncontrado!=null){
                agenteEncontrado.Documento=agente.Documento;
                agenteEncontrado.Nombres=agente.Nombres;
                agenteEncontrado.Apellidos=agente.Apellidos;
                agenteEncontrado.Edad=agente.Edad;
                agenteEncontrado.Genero=agente.Genero;
                agenteEncontrado.Telefono=agente.Telefono;
                agenteEncontrado.Email=agente.Email;
                agenteEncontrado.NumeroPlaca=agente.NumeroPlaca;
                agenteEncontrado.Rango=agente.Rango;
                _appContext.SaveChanges();
            }
            return agenteEncontrado;
        }

        Involucrado InterfaceRepositorioPersona.UpdateInvolucrado(Involucrado involucrado){
            var involucradoEncontrado=_appContext.Involucrados.FirstOrDefault(a => a.Id==involucrado.Id);
            if(involucradoEncontrado!=null){
                involucradoEncontrado.Documento=involucrado.Documento;
                involucradoEncontrado.Nombres=involucrado.Nombres;
                involucradoEncontrado.Apellidos=involucrado.Apellidos;
                involucradoEncontrado.Edad=involucrado.Edad;
                involucradoEncontrado.Genero=involucrado.Genero;
                involucradoEncontrado.Telefono=involucrado.Telefono;
                involucradoEncontrado.Email=involucrado.Email;
                involucradoEncontrado.FechaExpedicionDocumento=involucrado.FechaExpedicionDocumento;
                involucradoEncontrado.DireccionCasa=involucrado.DireccionCasa;
                involucradoEncontrado.AgenteVial=involucrado.AgenteVial;
                involucradoEncontrado.Alcoholemia=involucrado.Alcoholemia;
                involucradoEncontrado.PresentaLicencia=involucrado.PresentaLicencia;
                _appContext.SaveChanges();
            }
            return involucradoEncontrado;
        }
    }
}