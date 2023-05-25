using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Segundo_Semestre
{
    public partial class Crear_cuenta : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=Usuarios;Integrated Security = True";
        //This code stores a connection string that will be used to connect to a local
        //database called "Usuarios" using the integrated security of the operating system.
        public Crear_cuenta()
        {
            InitializeComponent();
        }

        private void Crear_cuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarCC_Click(object sender, EventArgs e)
        {
            string nombre = txbUsuarioCC.Text;
            string email = txbCorreoCC.Text;
            string contraseña = txbContraseñaCC.Text;
            string confirmarcontraseña = txbConfirmarContraseñaCC.Text;
            if (contraseña == confirmarcontraseña)
            {

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
                {
                    lblMensajeCC.Text = "Por favor, complete todos los campos.";
                    return;
                }
                if (contraseña == confirmarcontraseña)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "INSERT INTO UsuariosPS2 (Usuario, Correo, Contraseña) VALUES (@Usuario, @Correo, @Contraseña)";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Usuario", nombre);
                            command.Parameters.AddWithValue("@Correo", email);
                            command.Parameters.AddWithValue("@Contraseña", contraseña);
                            command.ExecuteNonQuery();

                            lblMensajeCC.Text = "Registro exitoso.";

                            // Limpia los campos del formulario después del registro exitoso
                            txbUsuarioCC.Text = "";
                            txbCorreoCC.Text = "";
                            txbContraseñaCC.Text = "";
                            txbConfirmarContraseñaCC.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMensajeCC.Text = "Error al registrar: " + ex.Message;
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Las Contraseñas no coinciden");
            }
        }
        //This code performs the insertion of a new user into a database, verifying that the
        //fields are filled out and that the passwords match before performing the insertion.
        private void btnCerrarCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This button automatically closes the program when pressed.



        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            Iniciar_Sesión iniciarsesion = new Iniciar_Sesión();
            iniciarsesion.Show();
        }

        private void txbConfirmarContraseñaCC_TextChanged(object sender, EventArgs e)
        {

        }
        //This button opens the login form if the client already has a previously registered
        //account.





    }
}
