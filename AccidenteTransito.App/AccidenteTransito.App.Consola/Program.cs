using System;
using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;

namespace AccidenteTransito.App.Consola
{
    class Program
    {
        private static InterfaceRepositorioPersona _repoPersona=new RepositorioPersona(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World desde Accidente de Transito!");
            //AddPersona();
            BuscarPersona(1);
        }

        private static void AddPersona(){
            var persona=new Persona(){
                Documento="14327",
                Nombres="Enrique",
                Apellidos="Romero",
                Edad=35,
                Genero=Genero.Masculino,
                Telefono="314258",
                Email="enrique@c#.com.co"
            };
            _repoPersona.AddPersona(persona);
        }

        private static void BuscarPersona(int idPersona){
            var persona=_repoPersona.GetPersona(idPersona);
            Console.WriteLine(persona.Nombres+" "+persona.Apellidos);
        }
    }
}
