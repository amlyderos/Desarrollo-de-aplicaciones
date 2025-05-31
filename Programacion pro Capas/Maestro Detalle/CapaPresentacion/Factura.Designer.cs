namespace CapaPresentacion
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spGenerarUltimaFactura2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemadeventa2DataSetamlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_de_venta2DataSetamly = new CapaPresentacion.Sistema_de_venta2DataSetamly();
            this.spGenerarUltimaFactura2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGenerarUltimaFactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGenerarUltimaFactura2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_de_venta2DataSetFACTURA = new CapaPresentacion.Sistema_de_venta2DataSetFACTURA();
            this.sistemadeventa2DataSetFACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_de_venta2DataSetFactura2 = new CapaPresentacion.Sistema_de_venta2DataSetFactura2();
            this.sistemadeventa2DataSetFactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GenerarUltimaFactura2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_GenerarUltimaFactura2TableAdapter1 = new CapaPresentacion.Sistema_de_venta2DataSetamlyTableAdapters.sp_GenerarUltimaFactura2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetamlyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetamly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFACTURA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFactura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFactura2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GenerarUltimaFactura2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spGenerarUltimaFactura2BindingSource3
            // 
            this.spGenerarUltimaFactura2BindingSource3.DataMember = "sp_GenerarUltimaFactura2";
            this.spGenerarUltimaFactura2BindingSource3.DataSource = this.sistemadeventa2DataSetamlyBindingSource;
            // 
            // sistemadeventa2DataSetamlyBindingSource
            // 
            this.sistemadeventa2DataSetamlyBindingSource.DataSource = this.sistema_de_venta2DataSetamly;
            this.sistemadeventa2DataSetamlyBindingSource.Position = 0;
            this.sistemadeventa2DataSetamlyBindingSource.CurrentChanged += new System.EventHandler(this.sistemadeventa2DataSetamlyBindingSource_CurrentChanged);
            // 
            // sistema_de_venta2DataSetamly
            // 
            this.sistema_de_venta2DataSetamly.DataSetName = "Sistema_de_venta2DataSetamly";
            this.sistema_de_venta2DataSetamly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistema_de_venta2DataSetFACTURA
            // 
            this.sistema_de_venta2DataSetFACTURA.DataSetName = "Sistema_de_venta2DataSetFACTURA";
            this.sistema_de_venta2DataSetFACTURA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemadeventa2DataSetFACTURABindingSource
            // 
            this.sistemadeventa2DataSetFACTURABindingSource.DataSource = this.sistema_de_venta2DataSetFACTURA;
            this.sistemadeventa2DataSetFACTURABindingSource.Position = 0;
            // 
            // sistema_de_venta2DataSetFactura2
            // 
            this.sistema_de_venta2DataSetFactura2.DataSetName = "Sistema_de_venta2DataSetFactura2";
            this.sistema_de_venta2DataSetFactura2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemadeventa2DataSetFactura2BindingSource
            // 
            this.sistemadeventa2DataSetFactura2BindingSource.DataSource = this.sistema_de_venta2DataSetFactura2;
            this.sistemadeventa2DataSetFactura2BindingSource.Position = 0;
            // 
            // sp_GenerarUltimaFactura2BindingSource
            // 
            this.sp_GenerarUltimaFactura2BindingSource.DataMember = "sp_GenerarUltimaFactura2";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "amly";
            reportDataSource1.Value = this.spGenerarUltimaFactura2BindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(827, 769);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // sp_GenerarUltimaFactura2TableAdapter1
            // 
            this.sp_GenerarUltimaFactura2TableAdapter1.ClearBeforeFill = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 769);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetamlyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetamly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarUltimaFactura2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFACTURA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_de_venta2DataSetFactura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemadeventa2DataSetFactura2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GenerarUltimaFactura2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sistemadeventa2DataSetFACTURABindingSource;
        private Sistema_de_venta2DataSetFACTURA sistema_de_venta2DataSetFACTURA;
        private System.Windows.Forms.BindingSource sistemadeventa2DataSetFactura2BindingSource;
        private Sistema_de_venta2DataSetFactura2 sistema_de_venta2DataSetFactura2;


        private System.Windows.Forms.BindingSource detalleBindingSource;
     
        private System.Windows.Forms.BindingSource spGenerarUltimaFactura2BindingSource;

    
        private System.Windows.Forms.BindingSource sp_GenerarUltimaFactura2BindingSource;
        private System.Windows.Forms.BindingSource spGenerarUltimaFactura2BindingSource1;
    
        private System.Windows.Forms.BindingSource spGenerarUltimaFactura2BindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Sistema_de_venta2DataSetamly sistema_de_venta2DataSetamly;
        private System.Windows.Forms.BindingSource sistemadeventa2DataSetamlyBindingSource;
        private System.Windows.Forms.BindingSource spGenerarUltimaFactura2BindingSource3;
        private Sistema_de_venta2DataSetamlyTableAdapters.sp_GenerarUltimaFactura2TableAdapter sp_GenerarUltimaFactura2TableAdapter1;
    }
}