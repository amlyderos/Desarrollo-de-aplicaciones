using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Capa_Presentacion.Forms;
using static System.Net.Mime.MediaTypeNames;
using CapaNegocio;

namespace CapaPresentacion
{
   
    public partial class Principalxd: Form
    {

        public string RolUsuario { get; set; }

        CN_Usuarios objetoCN = new CN_Usuarios();
        private string idProducto = null;
        private bool Editar = false;

        public Principalxd()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelDesboard.Controls.Count > 0)
                this.panelDesboard.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelDesboard.Controls.Add(fh);
            this.panelDesboard.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clientes fm = new Clientes();
            pictureBox2.Hide();
            label2.Hide();
            AbrirFormEnPanel(fm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articulos fm = new Articulos();
            pictureBox2.Hide();
            label2.Hide();
            AbrirFormEnPanel(fm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmFacturacion nuevoFormulario = new FrmFacturacion();
            nuevoFormulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Articulos nuevoFormulario = new Articulos();
            nuevoFormulario.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (RolUsuario == "Usuario")
            {
                btnClientes.Enabled = false;
                btnVentas.Enabled = false;
                btnArticulos.Enabled = false;
                btnUsuarios.Enabled = false;
               

            }
            else if (RolUsuario == "Viewer")
            {
                btnClientes.Enabled = false;
                btnUsuarios.Enabled = true;
                btnVentas.Enabled=false;
            }
            
        }


        
        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmFacturacion fm = new FrmFacturacion();
            pictureBox2.Hide();
            label2.Hide();
            AbrirFormEnPanel(fm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void panelDesboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
