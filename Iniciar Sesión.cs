using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;

namespace Proyecto_Segundo_Semestre
{
    public partial class Iniciar_Sesión : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Usuarios;Integrated Security = True";
        //This code stores a connection string that will be used to connect to a local
        //database called "Usuarios" using the integrated security of the operating system.
        public Iniciar_Sesión()
    {
        InitializeComponent();
    }

        private void Iniciar_Sesión_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarIS_Click(object sender, EventArgs e)
        {
            string email = txbCorreoIS.Text;
            string contraseña = txbContraseñaIS.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                lblMensajeIS.Text = "Por favor, ingrese su email y contraseña.";
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM UsuariosPS2 WHERE Correo=@Correo AND Contraseña=@Contraseña";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Correo", email);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            lblMensajeIS.Text = "Inicio de sesión exitoso.";
                            Form1 tienda = new Form1();
                            tienda.Show();
                        }
                        else
                        {
                            lblMensajeIS.Text = "Email o contraseña incorrectos.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMensajeIS.Text = "Error al iniciar sesión: " + ex.Message;
                }
            }
            //Form1 tienda = new Form1();
            //tienda.Show();
        }
        //This code verifies if the entered email and password match the records in the
        //database and displays a corresponding success or error message based on the result.
        //Afterwards, it displays the main form.
        private void btnCerrarIS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This button automatically closes the program when pressed.

    }

}
