using System;
using AccidenteTransito.App.Dominio;
using AccidenteTransito.App.Persistencia;


namespace AccidenteTransito.App.Consola
{
    class Program
    {
        private static InterfaceRepositorioPersona _repoPersona=new RepositorioPersona(new Persistencia.AppContext());
        private static InterfaceRepositorioVehiculo _repoVehiculo=new RepositorioVehiculo(new Persistencia.AppContext());
        private static InterfaceRepositorioAccidente _repoAccidente=new RepositorioAccidente(new Persistencia.AppContext());
        private static InterfaceRepositorioAccidentePersonas _repoAccidentePersonas=new RepositorioAccidentePersonas(new Persistencia.AppContext());
        private static InterfaceRepositorioAccidenteVehiculos _repoAccidenteVehiculos=new RepositorioAccidenteVehiculos(new Persistencia.AppContext());
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World desde Accidente de Transito!");
            var Accidente=AddAccidente();
            var Vehiculo=AddVehiculo();
            var Persona=AddPersona();
            var Agente=AddAgente();
            

            Console.WriteLine("Accidente Id "+Accidente.Id);
            Console.WriteLine("Accidente Id "+Persona.Id);
            AddAccidentePersonas(Accidente.Id,Persona.Id);
            AddAccidentePersonas(Accidente.Id,Agente.Id);
            AddAccidenteVehiculo(Accidente.Id,Vehiculo.Id);
            //AddPersona();
            BuscarPersona(1);
        }

        private static void AddAccidenteVehiculo(int accidente, int vehiculo){
            var accidenteVehiculo=new AccidenteVehiculos(){
               accidenteId=accidente,
               vehiculoId=vehiculo
            };
            _repoAccidenteVehiculos.AddAccidenteVehiculos(accidenteVehiculo);
        }

        private static void AddAccidentePersonas(Accidente accidente, Persona persona){
            var accidentePersonas=new AccidentePersonas(){
                Accidente=accidente,
                Persona=persona
            };
            _repoAccidentePersonas.AddAccidentePersonas(accidentePersonas);
        }

        private static void AddAccidentePersonas(int accidente, int persona){
            var accidentePersonas=new AccidentePersonas(){
               accidenteId=accidente,
               personaId=persona
            };
            _repoAccidentePersonas.AddAccidentePersonas(accidentePersonas);
        }

        private static Accidente AddAccidente(){
            var accidente=new Accidente(){
                Direccion="Calle 158 # 20-58",
                Latitud=12658,
                Longitud=12536,
                Barrio="El campin",
                Fecha=new DateTime(2021, 8, 10, 12, 30, 1),
                Hora=new DateTime(2021, 8, 10, 12, 30, 1),
                TipoAccidente=TipoAccidente.Vehicular,
                Descripcion="Accidente de transito en avenida"
            };
            return _repoAccidente.AddAccidente(accidente);
            
        }
        private static Persona AddPersona(){
            var persona=new Involucrado(){
                Documento="14327",
                Nombres="Enrique",
                Apellidos="Romero",
                Edad=35,
                Genero=Genero.Masculino,
                Telefono="314258",
                Email="enrique@c#.com.co",
                FechaExpedicionDocumento=new DateTime(2021, 8, 10, 12, 30, 1),
                DireccionCasa="Calle 152 # 15 - 58",
                AgenteVial=AgenteVial.Conductor,
                Alcoholemia="Si 14°",
                PresentaLicencia="No"
            };
            return _repoPersona.AddPersona(persona);             
        }

        private static Persona AddAgente(){
            var persona=new AgenteTransito(){
                Documento="125698745",
                Nombres="Patricio",
                Apellidos="Gonzales",
                Edad=38,
                Genero=Genero.Masculino,
                Telefono="31458963",
                Email="patricioe@c#.com.co",
                NumeroPlaca=25898968,
                Rango="Patrullero"
            };
            return _repoPersona.AddPersona(persona);             
        }

        private static Vehiculo AddVehiculo(){
            var vehiculo=new Vehiculo(){
                TipoVehiculo=TipoVehiculo.Furgoneta,
                TipoServicio="Urbano",
                Placa="MHG 145",
                Marca="Mazda",
                Modelo="SEDAM",
                Color="Azul",
                Anio=2010,
                Soat="Si 125896"    
            };
            return _repoVehiculo.AddVehiculo(vehiculo);
            
        }

        private static void BuscarPersona(int idPersona){
            var persona=_repoPersona.GetPersona(idPersona);
            Console.WriteLine(persona.Nombres+" "+persona.Apellidos);
        }
    }
}
