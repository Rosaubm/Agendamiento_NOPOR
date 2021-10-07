using System.Collections.Generic;
using System.Linq;
using AgendamientoIPS.App.Dominio;

namespace AgendamientoIPS.App.Persistencia
{
    public class RepositorioFactura : IRepositorioFactura
    {
        private readonly AppContext _appContext = new AppContext();


        Factura IRepositorioFactura.AddFactura(Factura factura)
        {
            var facturaAdicionado = _appContext.Facturas.Add(factura);
            _appContext.SaveChanges();
            return facturaAdicionado.Entity;
        }

        void IRepositorioFactura.DeleteFactura(int idFactura)
        {
            var facturaEncontrado = _appContext.Facturas.FirstOrDefault(f => f.Id == idFactura);
            if (facturaEncontrado == null)
                return;
            _appContext.Facturas.Remove(facturaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Factura> IRepositorioFactura.GetAllFacturas()
        {
            return _appContext.Facturas;
        }

        Factura IRepositorioFactura.GetFactura(int idFactura)
        {
            return _appContext.Facturas.FirstOrDefault(f => f.Id == idFactura);
        }

        Factura IRepositorioFactura.UpdateFactura(Factura factura)
        {
            var facturaEncontrado = _appContext.Facturas.FirstOrDefault(f => f.Id == factura.Id);
            if (facturaEncontrado != null)
            {
                facturaEncontrado.Cita = factura.Cita;
                facturaEncontrado.NumFactura = factura.NumFactura;
                facturaEncontrado.FechaFactura = factura.FechaFactura;
                facturaEncontrado.Concepto = factura.Concepto;
                facturaEncontrado.TarifaAplicada = factura.TarifaAplicada;
                facturaEncontrado.ValorPagado = factura.ValorPagado;
                facturaEncontrado.FormadePago = factura.FormadePago;
                
                _appContext.SaveChanges();
            }
            return facturaEncontrado;
        }

        Convenio IRepositorioFactura.AsignarConvenioFactura(int idFactura, int idConvenio)
        { 
            var facturaEncontrado = _appContext.Facturas.FirstOrDefault(f => f.Id == idFactura);
            if (facturaEncontrado != null)
            { 
                var convenioEncontrado = _appContext.Convenios.FirstOrDefault(c => c.Id == idConvenio);
                if (convenioEncontrado != null)
                { 
                    facturaEncontrado.IdConvenio = convenioEncontrado;
                    _appContext.SaveChanges();
                }
            return convenioEncontrado;
            }
        return null;
        }

        Cita IRepositorioFactura.AsignarCitaFactura(int idFactura, int idCita)
        { 
            var facturaEncontrado = _appContext.Facturas.FirstOrDefault(f => f.Id == idFactura);
            if (facturaEncontrado != null)
            { 
                var citaEncontrado = _appContext.Citas.FirstOrDefault(c => c.Id == idCita);
                if (citaEncontrado != null)
                { 
                    facturaEncontrado.Cita = citaEncontrado;
                    _appContext.SaveChanges();
                }
            return citaEncontrado;
            }
        return null;
        }
    }
}