using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public interface IRepositorioConvenio 
    {
        IEnumerable<Convenio> GetAllConvenios();
        Convenio AddConvenio(Convenio convenio);
        Convenio UpdateConvenio(Convenio convenio);
        void DeleteConvenio(int idConvenio);
        Convenio GetConvenio(int idConvenio);
    }
}