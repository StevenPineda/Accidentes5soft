using System.Collections.Generic;
using AccidenteTransito.App.Dominio;

namespace AccidenteTransito.App.Persistencia
{
    public interface InterfaceRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculos();
 
        Vehiculo AddVehiculo(Vehiculo vehiculo);

        Vehiculo UpdateVehiculo(Vehiculo vehiculo);

        void DeleteVehiculo(int Id);

        Vehiculo GetVehiculo(int Id);
         
    }
}