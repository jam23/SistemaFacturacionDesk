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
    
    public partial class CATEGORIA
    {
        public CATEGORIA()
        {
            this.ARTICULOS = new HashSet<ARTICULOS>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<ARTICULOS> ARTICULOS { get; set; }
    }
}
