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
    public partial class Cuerdas4 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //The code shown so far only declares the Cuerdas4 class and the
        //dtgvGuitarrasAcusticas field, but it does not show its complete implementation.
        public Cuerdas4(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //The constructor of Cuerdas4 allows assigning a DataGridView object to the instance
        //of the class, which is useful for accessing and manipulating the data displayed in
        //the table from the methods and events of the class.
        private void Cuerdas4_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarCuerdas4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Cuerdas4 form will be
        //automatically closed.
        private void btnAddCarritoArpa_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de Arpas
            int APSelvi = (int)nudArpaSelvi.Value;
            int APSelta = (int)nudArpaSelta.Value;
            


            //calculr precio total de cada Arpa
            long APSelviPrecioTotal = allPrecios.CalcularprecioGE(APSelvi, allPrecios.precioAPSelvi);
            long APSeltaPrecioTotal = allPrecios.CalcularprecioGE(APSelta, allPrecios.precioAPSelta);

            if (APSelvi > 0) { dtgvGuitarrasAcusticas.Rows.Add("AP Selvi", APSelvi, APSelviPrecioTotal); }
            if (APSelta > 0) { dtgvGuitarrasAcusticas.Rows.Add("AP Selta", APSelta, APSeltaPrecioTotal); }
            dtgvGuitarrasAcusticas.Visible = true;

        }
        //This method is responsible for adding the selected harps to the shopping cart,
        //displaying the corresponding information in the dtgvGuitarrasAcusticas DataGridView.
        private void btnCASelvi_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas del Arpa Selvi
            string[] CASelvi = { "Pintura con el Acabado que buscas", "Cuerdas de Buena cálidad", "Gran dispersión de Sónido del Instrumento" };

            // Mostrar las Caracteristicas del Arpa Selvi en un MessageBox
            MessageBox.Show("El Arpa Selvi tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CASelvi));
        }
        //This method displays the characteristics of the Selvi harp in a MessageBox when the
        //"Ver Características" button is clicked.
        private void btnCASelta_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas del Arpa Selta
            string[] CASelta = { "Acabado en madera natural", "La más resistente del mercado","La mejor para conocer el instrumento" };

            // Mostrar las Caracteristicas del Arpa Selta en un MessageBox
            MessageBox.Show("El Arpa Selta tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CASelta));
        }
        //This method displays the characteristics of the Selta harp in a MessageBox when the
        //"Ver Características" button is clicked.
    }
}
