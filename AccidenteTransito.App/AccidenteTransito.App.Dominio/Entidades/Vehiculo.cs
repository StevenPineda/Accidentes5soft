using System;
namespace AccidenteTransito.App.Dominio{
    public class Vehiculo{
        public int Id {get;set;}
        public TipoVehiculo TipoVehiculo {get;set;}
        public string TipoServicio {get;set;}
        public string Placa {get;set;}
        public string Marca {get;set;}
        public string Modelo {get;set;}
        public string Color {get;set;}
        public int Anio {get;set;}
        public string Soat {get;set;}
    }
}