﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Alejandria.Data.Interfaces;
using Alejandria.Win.Forms.Clientes;
using Alejandria.Win.Forms.Cobradores;
using Alejandria.Win.Forms.Ventas;
using Telerik.WinControls;

namespace Alejandria.Win.Forms
{
    public partial class FrmPrincipal : FormBase
    {

        public FrmPrincipal(IFormFactory formFactory, IAlejandriaUow uow)//, IUowFactory uowFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
           // UowFactory = uowFactory;
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmClienteListado>();
            frm.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmVentas>();
            frm.ShowDialog();
        }

        private void BtnCobradores_Click(object sender, EventArgs e)
        {
            var frm = FormFactory.Create<FrmCrearEditarCobrador>();
            frm.ShowDialog();
        }

      
    }
}
