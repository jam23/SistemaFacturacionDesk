//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaFacturacionDesk
{
    using System;
    
    public partial class ObtenerFacturasIdClienteRangoFecha_Result
    {
        public int idFactura { get; set; }
        public int idVendedor { get; set; }
        public string nombreVendedor { get; set; }
        public int idCliente { get; set; }
        public string razonSocial { get; set; }
        public string nombreComercial { get; set; }
        public string RNC_CED { get; set; }
        public string cuentaContable { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string comentarioFactura { get; set; }
        public System.DateTime fechaRegistroFactura { get; set; }
        public int itbisFactura { get; set; }
        public int descuentoFactura { get; set; }
        public string condicionPago { get; set; }
        public Nullable<int> cantidadDias { get; set; }
        public Nullable<int> idArticulo { get; set; }
        public string descripcionArticulo { get; set; }
        public Nullable<double> costoUnitarioArticulo { get; set; }
        public Nullable<double> precioUnitarioArticulo { get; set; }
        public Nullable<int> cantidadFacturado { get; set; }
        public Nullable<double> precioUnitarioFacturado { get; set; }
        public string descripcionCategoriaArticulo { get; set; }
        public Nullable<int> idCategoria { get; set; }
    }
}
