using System.Collections.Generic;
using System.Linq;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public class RepositorioSede : IRepositorioSede
    {
        private readonly AppContext _appContext = new AppContext();
        

        Sede IRepositorioSede.AddSede(Sede sede)
        {
            var sedeAdicionado = _appContext.Sedes.Add(sede);
            _appContext.SaveChanges();
            return sedeAdicionado.Entity;
        }

        void IRepositorioSede.DeleteSede(int idSede)
        {
            var sedeEncontrado = _appContext.Sedes.FirstOrDefault(s => s.Id == idSede);
            if (sedeEncontrado == null)
                return;
            _appContext.Sedes.Remove(sedeEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Sede> IRepositorioSede.GetAllSedes()
        {
            return _appContext.Sedes;
        }

        Sede IRepositorioSede.GetSede(int idSede)
        {
            return _appContext.Sedes.FirstOrDefault(s => s.Id == idSede);
        }

        Sede IRepositorioSede.UpdateSede(Sede sede)
        {
            var sedeEncontrado = _appContext.Sedes.FirstOrDefault(s => s.Id == sede.Id);
            if (sedeEncontrado != null)
            {
                sedeEncontrado.Nit = sede.Nit;
                sedeEncontrado.Ciudad = sede.Ciudad;
                sedeEncontrado.Direccion = sede.Direccion;
                sedeEncontrado.Telefono = sede.Telefono;
                sedeEncontrado.NombreSede = sede.NombreSede;
                sedeEncontrado.HorarioAtencion = sede.HorarioAtencion;
                
                _appContext.SaveChanges();
            }
            return sedeEncontrado;
        }
    }
}