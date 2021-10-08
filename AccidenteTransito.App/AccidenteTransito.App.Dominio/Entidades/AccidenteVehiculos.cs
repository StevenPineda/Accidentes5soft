using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccidenteTransito.App.Dominio{
    public class AccidenteVehiculos{

        public int Id {get;set;}

        [ForeignKey("Accidente")]
        public int accidenteId {get;set;}
        public Accidente Accidente {get;set;}

        [ForeignKey("Vehiculo")]
        public int vehiculoId {get;set;}
        public Vehiculo Vehiculo {get; set;}
    }
}