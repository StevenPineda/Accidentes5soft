using System.Collections.Generic;
using System.Linq;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public class RepositorioAccidentePersonas:InterfaceRepositorioAccidentePersonas
    {
        private readonly AppContext _appContext;

        public RepositorioAccidentePersonas(AppContext appContext){
            _appContext=appContext;
        }

        AccidentePersonas InterfaceRepositorioAccidentePersonas.AddAccidentePersonas(AccidentePersonas accidentePersonas){
            var accidenteAdicionado=_appContext.AccidentePersonas.Add(accidentePersonas);
            _appContext.SaveChanges();
            return accidenteAdicionado.Entity;
        }

        void InterfaceRepositorioAccidentePersonas.DeleteAccidentePersonas(int Id){
            var accidentePersonasEncontrado=_appContext.AccidentePersonas.FirstOrDefault(a => a.Id==Id);
            if(accidentePersonasEncontrado==null)
            return;
            _appContext.Remove(accidentePersonasEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<AccidentePersonas> InterfaceRepositorioAccidentePersonas.GetAllAccidentePersonas(){
            return _appContext.AccidentePersonas;
        }

        AccidentePersonas InterfaceRepositorioAccidentePersonas.GetAccidentePersonas(int Id){
            return _appContext.AccidentePersonas.FirstOrDefault(a => a.Id==Id);
        }

        AccidentePersonas InterfaceRepositorioAccidentePersonas.UpdateAccidentePersonas(AccidentePersonas accidentePersonas){
            var accidentePersonasEncontrado=_appContext.AccidentePersonas.FirstOrDefault(a => a.Id==accidentePersonas.Id);
            if(accidentePersonasEncontrado!=null){
                accidentePersonasEncontrado.Accidente=accidentePersonas.Accidente;
                accidentePersonasEncontrado.Persona=accidentePersonas.Persona;
                _appContext.SaveChanges();
            }
            return accidentePersonasEncontrado;
        }
    }
}