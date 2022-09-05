// See https://aka.ms/new-console-template for more information
using System;
using Grupo36.App.Dominio;
using Grupo36.App.Persistencia;
namespace Grupo36.App.Consola
{
    class program{
        private static IRepositorio _repoPersona =  new Repositorio(new Grupo36.App.Persistencia.AppContext());

        static void Main (string[] args)
        {
            Console.WriteLine("Hello, World!");
                // AddPerson();
                buscarPersona(1);
        }
        private static void AddPerson(){
            
            var pers = new Persona{

                nombre = "Juan",
                apellido ="Alvarez",
                edad = 36,
                telefono = "300345"
            };
            _repoPersona.AddPersona(pers);
            ////////////////////////////////////////////////////////////

        }
        private static void buscarPersona(int idp){
             var person = _repoPersona.GetPersona(idp);

             if (person != null)
             {
                Console.WriteLine("nombre: "+ person.nombre+" "+person.apellido+"\n edad: "+person.edad+"\n telefono: "+person.telefono);
             }
            }
    }
}


