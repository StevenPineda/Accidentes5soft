using System.Collections.Generic;
using System.Linq;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public class RepositorioAccidente:InterfaceRepositorioAccidente
    {
        private readonly AppContext _appContext;

        public RepositorioAccidente(AppContext appContext){
            _appContext=appContext;
        }

        Accidente InterfaceRepositorioAccidente.AddAccidente(Accidente accidente){
            var accidenteAdicionado=_appContext.Accidentes.Add(accidente);
            _appContext.SaveChanges();
            return accidenteAdicionado.Entity;
        }

        void InterfaceRepositorioAccidente.DeleteAccidente(int Id){
            var accidenteEncontrado=_appContext.Accidentes.FirstOrDefault(a => a.Id==Id);
            if(accidenteEncontrado==null)
            return;
            _appContext.Remove(accidenteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Accidente> InterfaceRepositorioAccidente.GetAllAccidentes(){
            return _appContext.Accidentes;
        }

        Accidente InterfaceRepositorioAccidente.GetAccidente(int Id){
            return _appContext.Accidentes.FirstOrDefault(a => a.Id==Id);
        }

        Accidente InterfaceRepositorioAccidente.UpdateAccidente(Accidente accidente){
            var accidenteEncontrado=_appContext.Accidentes.FirstOrDefault(a => a.Id==accidente.Id);
            if(accidenteEncontrado!=null){
                accidenteEncontrado.Direccion=accidente.Direccion;
                accidenteEncontrado.Latitud=accidente.Latitud;
                accidenteEncontrado.Longitud=accidente.Longitud;
                accidenteEncontrado.Barrio=accidente.Barrio;
                accidenteEncontrado.Fecha=accidente.Fecha;
                accidenteEncontrado.Hora=accidente.Hora;
                accidenteEncontrado.TipoAccidente=accidente.TipoAccidente;
                accidenteEncontrado.Involucrado=accidente.Involucrado;
                accidenteEncontrado.AgenteTransito=accidente.AgenteTransito;
                accidenteEncontrado.Vehiculo=accidente.Vehiculo;
                _appContext.SaveChanges();
            }
            return accidenteEncontrado;
        }
    }
}