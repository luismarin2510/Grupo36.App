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
        }
        private static AddPerson(){
            
            var pers = new Persona{
                
                nombre = "Maria",
                apellido ="Rojas",
                edad = 26,
                telefono = "3175622"
            };
        }
    }
}


