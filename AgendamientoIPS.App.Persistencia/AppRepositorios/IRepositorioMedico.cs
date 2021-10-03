using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public interface IRepositorioMedico 
    {
        IEnumerable<Medico> GetAllMedicos();
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        void DeleteMedico(int idMedico);
        Medico GetMedico(int idMedico);
    }
}