using System.Collections.Generic;
using Grupo36.App.Dominio;
using Grupo36.App.Persistencia;

namespace Grupo36.App.Persistencia
{
    public interface IRepositorio {

        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona perso);
        Persona UpdatePersona (Persona perso);
        void DeletePesona(int idPersona);
        Persona GetPersona(int idPersona);
        


    }
}