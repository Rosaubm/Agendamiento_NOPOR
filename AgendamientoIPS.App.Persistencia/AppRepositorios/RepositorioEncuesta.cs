using System.Collections.Generic;
using System.Linq;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public class RepositorioEncuesta : IRepositorioEncuesta
    {
        private readonly AppContext _appContext;

        public RepositorioEncuesta(AppContext appContext)
        {
            _appContext = appContext;
        }

        Encuesta IRepositorioEncuesta.AddEncuesta(Encuesta encuesta)
        {
            var encuestaAdicionado = _appContext.Encuestas.Add(encuesta);
            _appContext.SaveChanges();
            return encuestaAdicionado.Entity;
        }

        void IRepositorioEncuesta.DeleteEncuesta(int idEncuesta)
        {
            var encuestaEncontrado = _appContext.Encuestas.FirstOrDefault(p => p.Id == idEncuesta);
            if (encuestaEncontrado == null)
                return;
            _appContext.Encuestas.Remove(encuestaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Encuesta> IRepositorioEncuesta.GetAllEncuestas()
        {
            return _appContext.Encuestas;
        }

        Encuesta IRepositorioEncuesta.GetEncuesta(int idEncuesta)
        {
            return _appContext.Encuestas.FirstOrDefault(p => p.Id == idEncuesta);
        }

        Encuesta IRepositorioEncuesta.UpdateEncuesta(Encuesta encuesta)
        {
            var encuestaEncontrado = _appContext.Encuestas.FirstOrDefault(p => p.Id == encuesta.Id);
            if (encuestaEncontrado != null)
            {
                encuestaEncontrado.AntecedentesMedicos = encuesta.AntecedentesMedicos;
                encuestaEncontrado.MotivoConsulta = encuesta.MotivoConsulta;
                encuestaEncontrado.Observaciones = encuesta.Observaciones;
                _appContext.SaveChanges();
            }
            return encuestaEncontrado;
        }
    }
}