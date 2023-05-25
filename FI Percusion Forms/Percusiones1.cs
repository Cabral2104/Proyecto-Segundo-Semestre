using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Segundo_Semestre.FI_Percusion_Forms
{
    public partial class Percusiones1 : Form
    { 
        DataGridView dtgvGuitarrasAcusticas;
        //The purpose of this instance is to display and manipulate tabular data in the form
        //of a table within the form.
        public Percusiones1(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //This constructor allows setting the reference to a DataGridView object in the
        //Percusiones1 class, which can be useful for performing operations on the
        //DataGridView from other methods in the class.
        private void btnCerrarPercusiones1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Percusiones1 form will be
        //automatically closed.
        private void Percusiones1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddCarritoBA_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de las Baterias Acusticas
            int BACrush = (int)nudBACrush.Value;
            int BAYamaha = (int)nudBAYamaha.Value;
            int BAMapex = (int)nudBAMapex.Value;
            int BATama = (int)nudBATama.Value;



            //calculr precio total de cada Arpa
            long BACrushPrecioTotal = allPrecios.CalcularprecioGE(BACrush, allPrecios.precioBACrush);
            long BAYamahaPrecioTotal = allPrecios.CalcularprecioGE(BAYamaha, allPrecios.precioBAYamaha);
            long BAMapexPrecioTotal = allPrecios.CalcularprecioGE(BAMapex, allPrecios.precioBAMapex);
            long BATamaPrecioTotal = allPrecios.CalcularprecioGE(BATama, allPrecios.precioBATama);

            if (BACrush > 0) { dtgvGuitarrasAcusticas.Rows.Add("BA Crush", BACrush, BACrushPrecioTotal); }
            if (BAYamaha > 0) { dtgvGuitarrasAcusticas.Rows.Add("BA Yamaha", BAYamaha, BAYamahaPrecioTotal); }
            if (BAMapex > 0) { dtgvGuitarrasAcusticas.Rows.Add("BA Mapex", BAMapex, BAMapexPrecioTotal); }
            if (BATama > 0) { dtgvGuitarrasAcusticas.Rows.Add("BA Tama", BATama, BATamaPrecioTotal); }
            dtgvGuitarrasAcusticas.Visible = true;

        }
        //This method adds the selected Acoustic Drums to the shopping cart, displaying the
        //name, quantity, and total price in the DataGridView.
    }
}
