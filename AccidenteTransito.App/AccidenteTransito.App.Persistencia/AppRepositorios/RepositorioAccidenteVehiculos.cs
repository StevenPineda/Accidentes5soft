using System.Collections.Generic;
using System.Linq;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public class RepositorioAccidenteVehiculos:InterfaceRepositorioAccidenteVehiculos
    {
       private readonly AppContext _appContext;

        public RepositorioAccidenteVehiculos(AppContext appContext){
            _appContext=appContext;
        }

        AccidenteVehiculos InterfaceRepositorioAccidenteVehiculos.AddAccidenteVehiculos(AccidenteVehiculos accidenteVehiculos){
            var accidenteVehiculosEncontrado=_appContext.AccidenteVehiculos.Add(accidenteVehiculos);
            _appContext.SaveChanges();
            return accidenteVehiculosEncontrado.Entity;
        }

        void InterfaceRepositorioAccidenteVehiculos.DeleteAccidenteVehiculos(int Id){
            var accidenteVehiculosEncontrado=_appContext.AccidenteVehiculos.FirstOrDefault(a => a.Id==Id);
            if(accidenteVehiculosEncontrado==null)
            return;
            _appContext.Remove(accidenteVehiculosEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<AccidenteVehiculos> InterfaceRepositorioAccidenteVehiculos.GetAllAccidenteVehiculos(){
            return _appContext.AccidenteVehiculos;
        }

         AccidenteVehiculos InterfaceRepositorioAccidenteVehiculos.GetAccidenteVehiculos(int Id){
            return _appContext.AccidenteVehiculos.FirstOrDefault(a => a.Id==Id);
        }

         AccidenteVehiculos InterfaceRepositorioAccidenteVehiculos.UpdateAccidenteVehiculos(AccidenteVehiculos accidenteVehiculos){
            var accidenteVehiculosEncontrado=_appContext.AccidenteVehiculos.FirstOrDefault(a => a.Id==accidenteVehiculos.Id);
            if(accidenteVehiculosEncontrado!=null){
                accidenteVehiculosEncontrado.Accidente=accidenteVehiculos.Accidente;
                accidenteVehiculosEncontrado.Vehiculo=accidenteVehiculos.Vehiculo;
                _appContext.SaveChanges();
            }
            return accidenteVehiculosEncontrado;
        } 
        
    }
}