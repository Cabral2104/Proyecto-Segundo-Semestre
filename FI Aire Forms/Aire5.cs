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
    public partial class Aire5 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //The class Aire5 represents a form related to "Aire" and uses a DataGridView to
        //display and manipulate tabular data within it. The variable dtgvGuitarrasAcusticas
        //is used to store a reference to the DataGridView provided through the class
        //constructor.
        public Aire5(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //The Aire5 constructor is responsible for initializing the form and assigning the
        //provided DataGridView to the dtgvGuitarrasAcusticas variable, allowing it to be
        //accessed and manipulated within the context of the Aire5 class.
        private void btnCerrarAire5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Aire5 form will be
        //automatically closed.
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCarritoIA_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de los Triángulos
            int ATrompeta = (int)nudTrompeta.Value;
            int AXilófono = (int)nudXilófono.Value;
            int AAcordeón = (int)nudAcordeón.Value;
            int AFlauta = (int)nudFlauta.Value;


            //calculr precio total de cada Arpa
            long ATrompetaPrecioTotal = allPrecios.CalcularprecioGE(ATrompeta, allPrecios.precioATrompeta);
            long AXilófonoPrecioTotal = allPrecios.CalcularprecioGE(AXilófono, allPrecios.precioAXilófono);
            long AAcordeónPrecioTotal = allPrecios.CalcularprecioGE(AAcordeón, allPrecios.precioAAcordeón);
            long AFlautaPrecioTotal = allPrecios.CalcularprecioGE(AFlauta, allPrecios.precioAFlauta);

            if (ATrompeta > 0) { dtgvGuitarrasAcusticas.Rows.Add("Trompeta", ATrompeta, ATrompetaPrecioTotal); }
            if (AXilófono > 0) { dtgvGuitarrasAcusticas.Rows.Add("Xilófono", AXilófono, AXilófonoPrecioTotal); }
            if (AAcordeón > 0) { dtgvGuitarrasAcusticas.Rows.Add("Acordeón", AAcordeón, AAcordeónPrecioTotal); }
            if (AFlauta > 0) { dtgvGuitarrasAcusticas.Rows.Add("Flauta", AFlauta, AFlautaPrecioTotal); }



        }

        private void Aire5_Load(object sender, EventArgs e)
        {

        }
        //The btnAddCarritoIA_Click event calculates the total price of the selected air
        //instruments and adds them to the shopping cart in the DataGridView.
    }
}
