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
    using System.Collections.Generic;
    
    public partial class FACTURAS
    {
        public FACTURAS()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
        }
    
        public int id { get; set; }
        public int idCondicionPago { get; set; }
        public int idVendedor { get; set; }
        public int idCliente { get; set; }
        public int PorcentajeDescuento { get; set; }
        public int ITBIS { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public string comentario { get; set; }
    
        public virtual CLIENTES CLIENTES { get; set; }
        public virtual CONDICIONESPAGO CONDICIONESPAGO { get; set; }
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        public virtual VENDEDORES VENDEDORES { get; set; }
    }
}
