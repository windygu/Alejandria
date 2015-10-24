//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alejandria.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientesMovimiento
    {
        public int Id { get; set; }
        public System.Guid IdCliente { get; set; }
        public Nullable<int> IdTipoComprobante { get; set; }
        public Nullable<System.Guid> IdComprobante { get; set; }
        public string Concepto { get; set; }
        public Nullable<decimal> Debe { get; set; }
        public Nullable<decimal> Haber { get; set; }
        public string Observaciones { get; set; }
        public Nullable<System.DateTime> FechaGeneracion { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual TiposComprobante TiposComprobante { get; set; }
        public virtual Operador Operadore { get; set; }
        public virtual Operador Operadore1 { get; set; }
    }
}
