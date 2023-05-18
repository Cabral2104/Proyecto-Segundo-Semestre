using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Segundo_Semestre
{
    public partial class Cuerdas5 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //In the Cuerdas5 class, a variable dtgvGuitarrasAcusticas of type DataGridView is
        //declared. This variable is used to store a reference to the DataGridView control
        //that displays the product details in the form.
        public Cuerdas5(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //This constructor initializes the visual components of the form and assigns the
        //dataGridView object to the dtgvGuitarrasAcusticas field. This allows access and
        //manipulation of the DataGridView from other methods in the class.
        private void Cuerdas5_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarCuerdas5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Cuerdas5 form will be
        //automatically closed.
        private void lblArpaSelvi_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCarritoViolonchelos_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de Violonchelos
            int VStenor = (int)nudVStentor.Value;
            int VSinfonie24 = (int)nudSinfonie24.Value;



            //calculr precio total de cada Arpa
            long VStenorPrecioTotal = allPrecios.CalcularprecioGE(VStenor, allPrecios.precioVStenorStudent);
            long VSinfonie24PrecioTotal = allPrecios.CalcularprecioGE(VSinfonie24, allPrecios.precioVSinfonie24);

            if (VStenor > 0) { dtgvGuitarrasAcusticas.Rows.Add("V Stenor Student II", VStenor, VStenorPrecioTotal); }
            if (VSinfonie24 > 0) { dtgvGuitarrasAcusticas.Rows.Add("V Sinfonie24 Basic II", VSinfonie24, VSinfonie24PrecioTotal); }


        }
        //This code handles the logic to add the selected cellos to the shopping cart
        //represented by the DataGridView.
        private void btnVCVStenor_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas del Violonchelo Stenor
            string[] CVStenor = { "Cuerdas duraderas", "Buen Sónido" };

            // Mostrar las Caracteristicas del Violonchelo Stenor en un MessageBox
            MessageBox.Show("El Violonchelo Stenor tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CVStenor));
        }
        //This code displays the characteristics of the Stenor cello in a MessageBox when the
        //corresponding button is clicked.
        private void btnVCVSinfonie24_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas del Violonchelo Stenor
            string[] CVSinfonie24 = { "Cuerdas duraderas", "Buen Sónido", "Diseño Amigable", "Excelente pra aprender a tocar el Violonchelo" };

            // Mostrar las Caracteristicas del Violonchelo Sinfonie24 en un MessageBox
            MessageBox.Show("El Violonchelo Sinfonie24 tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CVSinfonie24));
        }
        //This code displays the characteristics of the Sinfonie24 cello in a MessageBox when
        //the corresponding button is clicked.
    }
}
