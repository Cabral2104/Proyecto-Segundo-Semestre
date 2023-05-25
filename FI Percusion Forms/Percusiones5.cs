using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Segundo_Semestre
{
    public partial class Percusiones5 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //This class represents a percussion form and uses a DataGridView to display and
        //manipulate data related to the percussions in the application.
        public Percusiones5(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //This constructor creates an instance of the Percusiones5 form and sets up the
        //associated DataGridView object, enabling interaction with that object from the form.
        private void btnCerrarPercusiones5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        //This method indicates that when the button is clicked, the Percusiones5 form will be
        //automatically closed.
        private void btnAddCarritoBombo_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de los Triángulos
            int BAudiotek = (int)nudBomboAudiotek.Value;
           


            //calculr precio total de cada Arpa
            long BAudiotekPrecioTotal = allPrecios.CalcularprecioGE(BAudiotek, allPrecios.precioBAudiotek);

            if (BAudiotek > 0) { dtgvGuitarrasAcusticas.Rows.Add("Bombo Audiotek", BAudiotek, BAudiotekPrecioTotal); }

            dtgvGuitarrasAcusticas.Visible = true;


        }

        private void Percusiones5_Load(object sender, EventArgs e)
        {

        }
        //This event handler adds the Audiotek bass drum to the shopping cart if at least one
        //unit has been selected, calculates the total price, and displays the information
        //in the DataGridView.
    }
}
