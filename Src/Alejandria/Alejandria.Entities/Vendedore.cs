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
    
    public partial class Vendedore
    {
        public Vendedore()
        {
            this.Clientes = new HashSet<Cliente>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cuit { get; set; }
        public string Mail { get; set; }
        public Nullable<int> ProvinciaId { get; set; }
        public Nullable<int> LocalidadId { get; set; }
        public Nullable<int> TipoDocumentoId { get; set; }
        public Nullable<bool> Activo { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual Localidad Localidade { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual Sucursal Sucursale1 { get; set; }
        public virtual TiposDocumentosIdentidad TiposDocumentosIdentidad { get; set; }
        public virtual Operador Operadore { get; set; }
        public virtual Operador Operadore1 { get; set; }
    }
}