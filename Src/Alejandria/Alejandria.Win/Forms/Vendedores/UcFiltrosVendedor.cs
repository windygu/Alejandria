﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;

namespace Alejandria.Win.Forms.Vendedores
{
    public partial class UcFiltrosVendedor : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosVendedor()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IAlejandriaUow>();
            }

            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        public event EventHandler<List<Entities.Vendedor>> BuscarFinished;
        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        //public int? ProvinciaId
        //{
        //    get { return (int?)(CbxProvincia.SelectedIndex != 0 ? CbxProvincia.SelectedValue : null); }
        //    set { CbxProvincia.SelectedValue = value ?? 0; }
        //}

        //public int? LocalidadId
        //{
        //    get { return (int?)(CbxLocalidad.SelectedIndex != 0 ? CbxLocalidad.SelectedValue : null); }
        //    set { CbxLocalidad.SelectedValue = value ?? 0; }
        //}

        #endregion

        #region Metodos

       private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;
            TxtTextoBuscar.Text = string.Empty;
            TxtCuit.Text = string.Empty;
            _limpiandoFiltros = false;

           // OnFiltered();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            var textBuscarNombre = TxtTextoBuscar.Text;
            var textBuscarCuit = TxtCuit.Text.PadLeft(11, '0');

            //Expression<Func<Cliente, bool>> where =
            //    x => SqlFunctions.PatIndex(textBuscarCuit, x.Cuit) > 0 || SqlFunctions.PatIndex(textBuscarDenominacion, x.Denominacion) > 0;

            Expression<Func<Entities.Vendedor, bool>> where =
            x =>
            (string.IsNullOrEmpty(textBuscarNombre)
             || x.Nombre.Contains(textBuscarNombre)
            )
           && (string.IsNullOrEmpty(textBuscarCuit)
           || x.Cuit.Contains(textBuscarCuit)
           )
            ;

            Cursor.Current = Cursors.WaitCursor;

            var vendedor = Uow.Vendedores.Listado(x => x.Localidad, x => x.Provincia)
                                       .Where(where)
                                       .ToList();

           

            Cursor.Current = Cursors.Default;

            OnBuscarFinished(vendedor);
            OnFiltered();
        }

        private void OnBuscarFinished(List<Entities.Vendedor> vendedores)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, vendedores);
            }
        }


        #endregion

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtCuit_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }
        }



    }
}
