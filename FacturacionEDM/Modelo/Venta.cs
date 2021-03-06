//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturacionEDM.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.DetalleVentas = new HashSet<DetalleVenta>();
        }
    
        public string IdVenta { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string IdCliente { get; set; }
        public string IdTipo_Venta { get; set; }
        public string IdTipoVenta { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetalleVentas { get; set; }
        public virtual Tipo_Venta Tipo_Venta { get; set; }
        public virtual TipoPagoVenta TipoPagoVenta { get; set; }
    }
}
