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
    public partial class Percusiones2 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //Percusiones2 is a form that displays percussion data in a DataGridView and uses the
        //dtgvGuitarrasAcusticas object to interact with the control from different methods.
        public Percusiones2(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //This constructor initializes the percussion form and sets the DataGridView object
        //that will be used to display and manipulate percussion data in the form.
        private void btnCerrarPercusiones2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Percusiones2 form will be
        //automatically closed.
        private void btnAddCarritoBEL_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de las Baterias Eléctricas
            int BELYamaha = (int)nudBEYamaha.Value;
            int BELRonald = (int)nudBERonald.Value;
            



            //calculr precio total de cada Arpa
            long BELYamahaPrecioTotal = allPrecios.CalcularprecioGE(BELYamaha, allPrecios.precioBELYamaha);
            long BELRonaldPrecioTotal = allPrecios.CalcularprecioGE(BELRonald, allPrecios.precioBELRonald);

            if (BELYamaha > 0) { dtgvGuitarrasAcusticas.Rows.Add("BEL Yamaha", BELYamaha, BELYamahaPrecioTotal); }
            if (BELRonald > 0) { dtgvGuitarrasAcusticas.Rows.Add("BEL Ronald", BELRonald, BELRonaldPrecioTotal); }



        }
        //This method is responsible for adding the selected electric drums to the shopping
        //cart, calculating the total price, and displaying the information in the DataGridView.
    }
}
