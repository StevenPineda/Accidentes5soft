using System;
namespace AccidenteTransito.App.Dominio{

    public class Accidente{
        public int Id {get;set;}
        public string Direccion {get;set;}
        public double Latitud {get;set;}
        public double Longitud {get;set;}
        public string Barrio {get;set;}
        public DateTime Fecha {get;set;}
        public DateTime Hora {get;set;}
        public TipoAccidente TipoAccidente {get;set;}

        public Involucrado Involucrado {get;set;}
        public AgenteTransito AgenteTransito {get;set;}
        public Vehiculo Vehiculo {get;set;}
    }
}