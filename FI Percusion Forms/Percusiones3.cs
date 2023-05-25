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
    public partial class Percusiones3 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //The class Percusiones3 represents a user interface form that is designed to display
        //and allow manipulation of percussion data in a DataGridView. The DataGridView object
        //is used to store and display the data in a tabular form.
        public Percusiones3(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //This constructor is responsible for initializing an instance of the Percusiones3
        //class and assigning the provided DataGridView object to the dtgvGuitarrasAcusticas
        //field for further use in manipulating percussion data in the form.
        private void btnCerrarPercusiones3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Percusiones3 form will be
        //automatically closed.
        private void btnAddCarritoTimbal_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de las Baterias Eléctricas
            int TAdams32 = (int)nudTimbalAdams32.Value;
            int TMajestic32 = (int)nudTimbalMajestic32.Value;




            //calculr precio total de cada Arpa
            long TAdams32PrecioTotal = allPrecios.CalcularprecioGE(TAdams32, allPrecios.precioTAdams32);
            long TMajestic32PrecioTotal = allPrecios.CalcularprecioGE(TMajestic32, allPrecios.precioTMajestic32);

            if (TAdams32 > 0) { dtgvGuitarrasAcusticas.Rows.Add("Timbal Adams32", TAdams32, TAdams32PrecioTotal); }
            if (TMajestic32 > 0) { dtgvGuitarrasAcusticas.Rows.Add("Timbal Majestic32", TMajestic32, TMajestic32PrecioTotal); }
            dtgvGuitarrasAcusticas.Visible = true;


        }

        private void Percusiones3_Load(object sender, EventArgs e)
        {

        }
        //This event is responsible for adding the selected timpani to the shopping cart,
        //calculating the total price for each type, and displaying the information in the
        //DataGridView.
    }
}
