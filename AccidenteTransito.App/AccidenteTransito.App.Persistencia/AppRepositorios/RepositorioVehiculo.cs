using System.Collections.Generic;
using System.Linq;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public class RepositorioVehiculo:InterfaceRepositorioVehiculo
    {
        private readonly AppContext _appContext;

        public RepositorioVehiculo(AppContext appContext){
            _appContext=appContext;
        }

        Vehiculo InterfaceRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo){
            var vehiculoAdicionado=_appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionado.Entity;
        }

        void InterfaceRepositorioVehiculo.DeleteVehiculo(int Id){
            var vehiculoEncontrado=_appContext.Vehiculos.FirstOrDefault(a => a.Id==Id);
            if(vehiculoEncontrado==null)
            return;
            _appContext.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Vehiculo> InterfaceRepositorioVehiculo.GetAllVehiculos(){
            return _appContext.Vehiculos;
        }

        Vehiculo InterfaceRepositorioVehiculo.GetVehiculo(int Id){
            return _appContext.Vehiculos.FirstOrDefault(a => a.Id==Id);
        }

        Vehiculo InterfaceRepositorioVehiculo.UpdateVehiculo(Vehiculo vehiculo){
            var vehiculoEncontrado=_appContext.Vehiculos.FirstOrDefault(a => a.Id==vehiculo.Id);
            if(vehiculoEncontrado!=null){
                vehiculoEncontrado.TipoVehiculo=vehiculo.TipoVehiculo;
                vehiculoEncontrado.TipoServicio=vehiculo.TipoServicio;
                vehiculoEncontrado.Placa=vehiculo.Placa;
                vehiculoEncontrado.Marca=vehiculo.Marca;
                vehiculoEncontrado.Modelo=vehiculo.Modelo;
                vehiculoEncontrado.Color=vehiculo.Color;
                vehiculoEncontrado.Anio=vehiculo.Anio;
                vehiculoEncontrado.Soat=vehiculo.Soat;
                _appContext.SaveChanges();
            }
            return vehiculoEncontrado;
        }

    }
}