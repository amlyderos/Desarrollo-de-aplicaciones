﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Factura: Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_de_venta2DataSetamly.sp_GenerarUltimaFactura2' Puede moverla o quitarla según sea necesario.
            this.sp_GenerarUltimaFactura2TableAdapter1.Fill(this.sistema_de_venta2DataSetamly.sp_GenerarUltimaFactura2);
            // TODO: esta línea de código carga datos en la tabla 'sistema_de_venta2DataSetDefinitivo3.sp_GenerarUltimaFactura2' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'sistema_de_venta2DataSetDefinitivo3.Detalle' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void sistemadeventa2DataSetamlyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
