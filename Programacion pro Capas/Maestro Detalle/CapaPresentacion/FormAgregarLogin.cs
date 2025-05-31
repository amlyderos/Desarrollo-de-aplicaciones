using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormAgregarLogin : Form
    {

        private CN_Usuarios cn_usuarios = new CN_Usuarios();
        public FormAgregarLogin()
        {
            InitializeComponent();
        }

        CN_Usuarios objetoCN = new CN_Usuarios();
        private string idProducto = null;
        private bool Editar = false;
        public string RolUsuario { get; set; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
             FormLogin nuevoFormulario = new FormLogin();
            nuevoFormulario.FormClosed += (s, args) => this.Close();
            nuevoFormulario.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text == "USUARIO" ? "" : txtUsuario.Text;
                string contraseña = txtContraseña.Text == "CONTRASEÑA" ? "" : txtContraseña.Text;
                string confirmacion = txtConfirmarContraseña.Text == "CONFIRMAR CONTRASEÑA" ? "" : txtConfirmarContraseña.Text;
                string rol = cbx_rol.SelectedItem?.ToString() ?? "";

                // Validación de campos
                if (string.IsNullOrEmpty(usuario))
                {
                    MessageBox.Show("Ingrese un nombre de usuario");
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Ingrese una contraseña");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña.Length < 4)
                {
                    MessageBox.Show("La contraseña debe tener al menos 4 caracteres");
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña != confirmacion)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    txtConfirmarContraseña.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(rol))
                {
                    MessageBox.Show("Seleccione un rol");
                    cbx_rol.Focus();
                    return;
                }

                int nuevoId = cn_usuarios.RegistrarUsuario(usuario, contraseña, rol);

                MessageBox.Show("Usuario registrado exitosamente");

                // Limpiar campos después de registrar
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
                txtConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmarContraseña.ForeColor = Color.DimGray;
                txtConfirmarContraseña.UseSystemPasswordChar = false;


                this.Hide();

                if (rol == "admin")
                {

                    Principalxd principal = new Principalxd();
                    principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                    principal.FormClosed += (s, args) => this.Close();
                    principal.Show();
                }
                if (rol == "viewer")
                {

                    Principalxd principal = new Principalxd();
                    principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                    principal.FormClosed += (s, args) => this.Close();
                    principal.Show();
                }
                else
                {

                    Principalxd principal = new Principalxd();
                    principal.RolUsuario = cn_usuarios.ObtenerRol(usuario);
                    principal.FormClosed += (s, args) => this.Close();
                    principal.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
