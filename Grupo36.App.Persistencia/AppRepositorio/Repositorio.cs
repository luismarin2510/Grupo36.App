using System.Collections.Generic;
using System.Linq;
using Grupo36.App.Dominio;

namespace Grupo36.App.Persistencia
{
    public class Repositorio : IRepositorio
    {
        private readonly AppContext appcox;
        public Repositorio(AppContext appContext)
        {
            appcox = appContext;
        }

        Persona IRepositorio.AddPersona(Grupo36.App.Dominio.Persona perso){

            var agregarpersona = appcox.personas.Add(perso);
            appcox.SaveChances();

            return agregarpersona.Entity;
        }

        // eliminar
        void IRepositorio.DeletePesona(int idPersona){
            var  encontrarPersona = appcox.personas.FirstOrDefault(p => p.Id == idPersona);
            if (encontrarPersona == null){
                return;

            }
            appcox.personas.Remove(encontrarPersona);
            appcox.SaveChange();
        }

        // Llamar todos los datos de l tabla 

        IEnumerable<Persona> IRepositorio.GetAllPersona(){
             return appcox.personas;
        }
        // Llamar a una sola persona en especifico

        Persona IRepositorio.GetPersona(int idPersona){
            return appcox.personas.FirstOrDefault(p => p.Id == idPersona);
        }
        // Actualizar
        Persona IRepositorio.UpdatePersona(Grupo36.App.Dominio.Persona perso){
            var PersonaEncontrada = appcox.FirtsOrDefault(perso => perso.Id == perso.Id);

            if(PersonaEncontrada != null){
                PersonaEncontrada.nombre = perso.nombre;
                appcox.SaveChanges();
            }
            return PersonaEncontrada;
        }
        
    }

}