using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Segundo_Semestre
{
    public partial class Percusiones4 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //The Percusiones4 class is a form that displays information about percussion
        //instruments and uses a DataGridView object to interact with the data in a tabular
        //form.
        public Percusiones4(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //The constructor of Percusiones4 initializes the Percusiones4 form and sets up the
        //DataGridView object to be used by the form in its percussion-related operations.
        private void btnCerrarPercusiones4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Percusiones4 form will be
        //automatically closed.
        private void lblTimbalAdams32_Click(object sender, EventArgs e)
        {

        }

        private void lblGuitarrasElectricas_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCarritoTriangulo_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de los Triángulos
            int TACharls = (int)nudTrianguloCharls.Value;
            int TAXO = (int)nudTrianguloXO.Value;




            //calculr precio total de cada Arpa
            long TACharlsPrecioTotal = allPrecios.CalcularprecioGE(TACharls, allPrecios.precioTACharls);
            long TAXOPrecioTotal = allPrecios.CalcularprecioGE(TAXO, allPrecios.precioTAXO);

            if (TACharls > 0) { dtgvGuitarrasAcusticas.Rows.Add("Triángulo Charls", TACharls, TACharlsPrecioTotal); }
            if (TAXO > 0) { dtgvGuitarrasAcusticas.Rows.Add("Triángulo XO", TAXO, TAXOPrecioTotal); }
            dtgvGuitarrasAcusticas.Visible = true;


        }

        private void Percusiones4_Load(object sender, EventArgs e)
        {

        }
        //The method adds the selected triangles to the shopping cart, displaying them in the
        //DataGridView with their quantity and total price.
    }
}
