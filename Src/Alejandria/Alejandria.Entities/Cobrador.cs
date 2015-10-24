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
    
    public partial class Cobrador
    {
        public Cobrador()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public int SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cuit { get; set; }
        public string Mail { get; set; }
        public Nullable<int> ProvinciaId { get; set; }
        public Nullable<int> LocalidadId { get; set; }
        public Nullable<int> TipoDocumentoId { get; set; }
        public bool Activo { get; set; }
    
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual TiposDocumentosIdentidad TiposDocumentosIdentidad { get; set; }
        public virtual Sucursal SucursaleModificacion { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
        public virtual Operador Operadore { get; set; }
        public virtual Operador Operadore1 { get; set; }
    }
}
