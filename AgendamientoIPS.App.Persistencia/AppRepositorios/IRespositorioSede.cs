using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public interface IRepositorioSede 
    {
        IEnumerable<Sede> GetAllSedes();
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede(int idSede);
        Sede GetSede(int idSede);           
    }
}