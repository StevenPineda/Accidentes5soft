using System;

namespace AccidenteTransito.App.Dominio
{
    public class Involucrado:Persona
    {
        public DateTime FechaExpedicionDocumento {get;set;}
        public string DireccionCasa {get;set;}
        public AgenteVial AgenteVial {get;set;}
        public string Alcoholemia {get;set;}
        public string PresentaLicencia {get;set;}
    }
}