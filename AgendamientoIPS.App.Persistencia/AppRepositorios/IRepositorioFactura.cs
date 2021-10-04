using System.Collections.Generic;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public interface IRepositorioFactura 
    {
        IEnumerable<Factura> GetAllFacturas();
        Factura AddFactura(Factura factura);
        Factura UpdateFactura(Factura factura);
        void DeleteFactura(int idFactura);
        Factura GetFactura(int idFactura);
        Convenio AsignarConvenioFactura(int idFactura, int idConvenio);
        Cita AsignarCitaFactura(int idFactura, int idCita);             
    }
}