using System.Collections.Generic;
using System.Linq;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public class RepositorioConvenio : IRepositorioConvenio
    {
        private readonly AppContext _appContext;

        public RepositorioConvenio(AppContext appContext)
        {
            _appContext = appContext;
        }

        Convenio IRepositorioConvenio.AddConvenio(Convenio convenio)
        {
            var convenioAdicionado = _appContext.Convenios.Add(convenio);
            _appContext.SaveChanges();
            return convenioAdicionado.Entity;
        }

        void IRepositorioConvenio.DeleteConvenio(int idConvenio)
        {
            var convenioEncontrado = _appContext.Convenios.FirstOrDefault(c => c.Id == idConvenio);
            if (convenioEncontrado == null)
                return;
            _appContext.Convenios.Remove(convenioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Convenio> IRepositorioConvenio.GetAllConvenios()
        {
            return _appContext.Convenios;
        }

        Convenio IRepositorioConvenio.GetConvenio(int idConvenio)
        {
            return _appContext.Convenios.FirstOrDefault(c => c.Id == idConvenio);
        }

        Convenio IRepositorioConvenio.UpdateConvenio(Convenio convenio)
        {
            var convenioEncontrado = _appContext.Convenios.FirstOrDefault(e => e.Id == convenio.Id);
            if (convenioEncontrado != null)
            {
                convenioEncontrado.NumConvenio = convenio.NumConvenio;
                convenioEncontrado.EPS = convenio.EPS;
                convenioEncontrado.Descuento = convenio.Descuento;
                _appContext.SaveChanges();
            }
            return convenioEncontrado;
        }
    }
}