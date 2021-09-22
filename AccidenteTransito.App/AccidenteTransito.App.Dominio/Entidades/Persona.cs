using System;

namespace AccidenteTransito.App.Dominio{

    public class Persona{
        
        public int Id {get;set;}
        public string Documento {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public int Edad {get;set;}
        public Genero Genero {get;set;}
        public string Telefono {get;set;}
        public string Email {get;set;}

    }
}