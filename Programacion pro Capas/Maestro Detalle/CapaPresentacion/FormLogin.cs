using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CapaNegocio;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {

        private CN_Usuarios cn_usuarios = new CN_Usuarios();

        public FormLogin()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            try
            {
                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text;
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text;

                if (string.IsNullOrEmpty(usuario))
                {
                    MessageBox.Show("Por favor ingrese un nombre de usuario");
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Por favor ingrese una contraseña");
                    txtContraseña.Focus();
                    return;
                }

                if (cn_usuarios.Login(usuario, contraseña))
                {
                    string rol = cn_usuarios.ObtenerRol(usuario);

                    if (rol == "Administrador")
                    {
                        MessageBox.Show("Bienvenido Administrador");

                        Principalxd principal = new Principalxd();
                        principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else if (rol == "Viewer")
                    {
                        MessageBox.Show("Bienvenido");

                        Principalxd principal = new Principalxd();
                        principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else if (rol == "Usuario")
                    {
                        MessageBox.Show("Bienvenido Usuario");

                        Principalxd principal = new Principalxd();
                        principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                        principal.Show();
                        principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Rol no reconocido");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    txtContraseña.Text = "CONTRASEÑA";
                    txtContraseña.ForeColor = Color.DimGray;
                    txtContraseña.UseSystemPasswordChar = false;
                    txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Text = "USUARIO";
            txtUsuario.ForeColor = Color.DimGray;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.UseSystemPasswordChar = false;

            this.Show();
            txtUsuario.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormAgregarLogin nuevoFormulario = new FormAgregarLogin();
            nuevoFormulario.FormClosed += (s, args) => this.Close();
            nuevoFormulario.Show();
        }
    }
    
}
