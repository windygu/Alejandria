﻿using System;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Threading.Tasks;
using Alejandria.Data.Helpers;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;

namespace Alejandria.Data
{
    public class AlejandriaUow : IAlejandriaUow
    {
        public AlejandriaUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        public IRepository<CategoriaOperador> CategoriaOperadores { get { return GetStandardRepo<CategoriaOperador>(); } }
        public IRepository<CondicionesIVA> CondicionesIVAs { get { return GetStandardRepo<CondicionesIVA>(); } }
        public IRepository<CondicionesVenta> CondicionesVentas { get { return GetStandardRepo<CondicionesVenta>(); } }
        public IRepository<Especialidad> Especialidades { get { return GetStandardRepo<Especialidad>(); } }
        public IRepository<EstadosCliente> EstadosClientes { get { return GetStandardRepo<EstadosCliente>(); } }
        public IRepository<Localidad> Localidades { get { return GetStandardRepo<Localidad>(); } }
        public IRepository<Operador> Operadores { get { return GetStandardRepo<Operador>(); } }
        public IRepository<Personal> Personales { get { return GetStandardRepo<Personal>(); } }
        public IRepository<Profesion> Profesiones { get { return GetStandardRepo<Profesion>(); } }
        public IRepository<Provincia> Provincias { get { return GetStandardRepo<Provincia>(); } }
        public IRepository<Sucursal> Sucursales { get { return GetStandardRepo<Sucursal>(); } }
        public IRepository<TiposDocumentosIdentidad> TiposDocumentosIdentidades { get { return GetStandardRepo<TiposDocumentosIdentidad>(); } }
        public IRepository<Venta> Ventas {get { return GetStandardRepo<Venta>(); } }
        public IRepository<Cliente> Clientes { get { return GetStandardRepo<Cliente>(); } }
        public IRepository<ClientesCuentasCorriente> ClientesCuentasCorrientes { get { return GetStandardRepo<ClientesCuentasCorriente>(); } }
        public IRepository<TiposComprobante> TiposComprobantes { get { return GetStandardRepo<TiposComprobante>(); } }
        public IRepository<EstadosVenta> EstadosVentas { get { return GetStandardRepo<EstadosVenta>(); } }
        public IRepository<Caja> Cajas { get { return GetStandardRepo<Caja>(); } }
        public IRepository<CajasMovimiento> CajasMovimientos { get { return GetStandardRepo<CajasMovimiento>(); } }
        public IRepository<TiposMovimientosCaja> TiposMovimientosCajas { get { return GetStandardRepo<TiposMovimientosCaja>(); } }
        public IRepository<Cobrador> Cobradores { get { return GetStandardRepo<Cobrador>(); } }
        public IRepository<ClientesMovimiento> ClientesMovimientos { get { return GetStandardRepo<ClientesMovimiento>(); } }
        public IRepository<Vendedor> Vendedores { get { return GetStandardRepo<Vendedor>(); } }

        public IReporteRepository Reportes { get { return GetRepo<IReporteRepository>(); } }


        public string ConnectionString
        {
            get
            {
                var builder = new EntityConnectionStringBuilder();
                builder.Metadata = @"res://*/OfficeModel.csdl|res://*/OfficeModel.ssdl|res://*/OfficeModel.msl";
                builder.Provider = "System.Data.SqlClient";
                builder.ProviderConnectionString = ConfigurationManager.ConnectionStrings["OfficeEntities"].ConnectionString;
                return builder.ToString();
            }
        }

        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public Task CommitAsync()
        {
            return DbContext.SaveChangesAsync();
        }

        protected void CreateDbContext()
        {
            DbContext = new AlejandriaDbContext();  

            // Do NOT enable proxied entities, else serialization fails
            DbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            DbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IRepository<T> GetStandardRepo<T>() where T : class
        {
            //return RepositoryProvider.GetRepositoryForEntityType<T>();
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        public AlejandriaDbContext DbContext { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion
    }
}
