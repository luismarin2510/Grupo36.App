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

            {
                
            }
        }
    }
}