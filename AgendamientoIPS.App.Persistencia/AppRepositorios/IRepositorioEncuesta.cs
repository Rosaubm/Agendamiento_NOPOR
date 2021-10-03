using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public interface IRepositorioEncuesta 
    {
        IEnumerable<Encuesta> GetAllEncuestas();
        Encuesta AddEncuesta(Encuesta encuesta);
        Encuesta UpdateEncuesta(Encuesta encuesta);
        void DeleteEncuesta(int idEncuesta);
        Encuesta GetEncuesta(int idEncuesta);
    }
}