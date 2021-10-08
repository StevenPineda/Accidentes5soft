using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccidenteTransito.App.Dominio{
    public class AccidentePersonas{

        public int Id {get;set;}
        [ForeignKey("Accidente")]
        public int accidenteId {get;set;}
        public Accidente Accidente {get;set;}

        [ForeignKey("Persona")]
        public int personaId {get;set;}
        public Persona Persona {get; set;}
        
    }
}