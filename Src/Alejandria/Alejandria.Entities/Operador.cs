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
    
    public partial class Operador
    {
        public Operador()
        {
            this.Cajas = new HashSet<Caja>();
            this.Cajas1 = new HashSet<Caja>();
            this.Cajas2 = new HashSet<Caja>();
            this.CajasMovimientos = new HashSet<CajasMovimiento>();
            this.CajasMovimientos1 = new HashSet<CajasMovimiento>();
            this.CategoriasOperadores = new HashSet<CategoriaOperador>();
            this.CategoriasOperadores1 = new HashSet<CategoriaOperador>();
            this.Clientes = new HashSet<Cliente>();
            this.Clientes1 = new HashSet<Cliente>();
            this.ClientesCuentasCorrientes = new HashSet<ClientesCuentasCorriente>();
            this.ClientesCuentasCorrientes1 = new HashSet<ClientesCuentasCorriente>();
            this.ClientesMovimientoes = new HashSet<ClientesMovimiento>();
            this.ClientesMovimientoes1 = new HashSet<ClientesMovimiento>();
            this.Cobradores = new HashSet<Cobrador>();
            this.Cobradores1 = new HashSet<Cobrador>();
            this.CondicionesIVAs = new HashSet<CondicionesIVA>();
            this.CondicionesIVAs1 = new HashSet<CondicionesIVA>();
            this.Especialidades = new HashSet<Especialidad>();
            this.Especialidades1 = new HashSet<Especialidad>();
            this.EstadosVentas = new HashSet<EstadosVenta>();
            this.EstadosVentas1 = new HashSet<EstadosVenta>();
            this.Localidades = new HashSet<Localidad>();
            this.Localidades1 = new HashSet<Localidad>();
            this.Operadores1 = new HashSet<Operador>();
            this.Operadores11 = new HashSet<Operador>();
            this.Personals = new HashSet<Personal>();
            this.Personals1 = new HashSet<Personal>();
            this.Profesiones = new HashSet<Profesion>();
            this.Profesiones1 = new HashSet<Profesion>();
            this.Provincias = new HashSet<Provincia>();
            this.Provincias1 = new HashSet<Provincia>();
            this.Sucursales = new HashSet<Sucursal>();
            this.Sucursales1 = new HashSet<Sucursal>();
            this.TiposComprobantes = new HashSet<TiposComprobante>();
            this.TiposComprobantes1 = new HashSet<TiposComprobante>();
            this.TiposDocumentosIdentidads = new HashSet<TiposDocumentosIdentidad>();
            this.TiposDocumentosIdentidads1 = new HashSet<TiposDocumentosIdentidad>();
            this.Vendedores = new HashSet<Vendedore>();
            this.Vendedores1 = new HashSet<Vendedore>();
            this.Ventas = new HashSet<Venta>();
            this.Ventas1 = new HashSet<Venta>();
            this.Ventas2 = new HashSet<Venta>();
            this.Zonas = new HashSet<Zona>();
            this.Zonas1 = new HashSet<Zona>();
        }
    
        public System.Guid Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Nullable<System.DateTime> VigenteDesde { get; set; }
        public Nullable<System.DateTime> VigenteHasta { get; set; }
        public Nullable<System.Guid> PersonalId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public bool Habilitado { get; set; }
    
        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<Caja> Cajas1 { get; set; }
        public virtual ICollection<Caja> Cajas2 { get; set; }
        public virtual ICollection<CajasMovimiento> CajasMovimientos { get; set; }
        public virtual ICollection<CajasMovimiento> CajasMovimientos1 { get; set; }
        public virtual ICollection<CategoriaOperador> CategoriasOperadores { get; set; }
        public virtual ICollection<CategoriaOperador> CategoriasOperadores1 { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Cliente> Clientes1 { get; set; }
        public virtual ICollection<ClientesCuentasCorriente> ClientesCuentasCorrientes { get; set; }
        public virtual ICollection<ClientesCuentasCorriente> ClientesCuentasCorrientes1 { get; set; }
        public virtual ICollection<ClientesMovimiento> ClientesMovimientoes { get; set; }
        public virtual ICollection<ClientesMovimiento> ClientesMovimientoes1 { get; set; }
        public virtual ICollection<Cobrador> Cobradores { get; set; }
        public virtual ICollection<Cobrador> Cobradores1 { get; set; }
        public virtual ICollection<CondicionesIVA> CondicionesIVAs { get; set; }
        public virtual ICollection<CondicionesIVA> CondicionesIVAs1 { get; set; }
        public virtual ICollection<Especialidad> Especialidades { get; set; }
        public virtual ICollection<Especialidad> Especialidades1 { get; set; }
        public virtual ICollection<EstadosVenta> EstadosVentas { get; set; }
        public virtual ICollection<EstadosVenta> EstadosVentas1 { get; set; }
        public virtual ICollection<Localidad> Localidades { get; set; }
        public virtual ICollection<Localidad> Localidades1 { get; set; }
        public virtual ICollection<Operador> Operadores1 { get; set; }
        public virtual Operador Operadore1 { get; set; }
        public virtual ICollection<Operador> Operadores11 { get; set; }
        public virtual Operador Operadore2 { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Sucursal Sucursale { get; set; }
        public virtual Sucursal Sucursale1 { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
        public virtual ICollection<Personal> Personals1 { get; set; }
        public virtual ICollection<Profesion> Profesiones { get; set; }
        public virtual ICollection<Profesion> Profesiones1 { get; set; }
        public virtual ICollection<Provincia> Provincias { get; set; }
        public virtual ICollection<Provincia> Provincias1 { get; set; }
        public virtual ICollection<Sucursal> Sucursales { get; set; }
        public virtual ICollection<Sucursal> Sucursales1 { get; set; }
        public virtual ICollection<TiposComprobante> TiposComprobantes { get; set; }
        public virtual ICollection<TiposComprobante> TiposComprobantes1 { get; set; }
        public virtual ICollection<TiposDocumentosIdentidad> TiposDocumentosIdentidads { get; set; }
        public virtual ICollection<TiposDocumentosIdentidad> TiposDocumentosIdentidads1 { get; set; }
        public virtual ICollection<Vendedore> Vendedores { get; set; }
        public virtual ICollection<Vendedore> Vendedores1 { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
        public virtual ICollection<Venta> Ventas1 { get; set; }
        public virtual ICollection<Venta> Ventas2 { get; set; }
        public virtual ICollection<Zona> Zonas { get; set; }
        public virtual ICollection<Zona> Zonas1 { get; set; }
    }
}
