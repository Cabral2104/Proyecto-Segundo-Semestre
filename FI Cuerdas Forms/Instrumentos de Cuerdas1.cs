using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Proyecto_Segundo_Semestre
{
    public partial class Instrumentos_de_Cuerdas1 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //Declare a variable of type DataGridView named dtgvGuitarrasAcusticas.
        public Instrumentos_de_Cuerdas1(DataGridView dataGridView)
        {
            InitializeComponent();

            dtgvGuitarrasAcusticas = dataGridView;

        }
        //This constructor is used to create an instance of the Instrumentos_de_Cuerdas1 class
        //and assign a specified DataGridView object to the dtgvGuitarrasAcusticas field.
        //This allows the Instrumentos_de_Cuerdas1 class to work with the dataGridView object
        //and perform operations on it, such as displaying data or performing specific
        //manipulations related to string instruments.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //When this button is pressed, the current form automatically closes.
        private void Instrumentos_de_Cuerdas1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarCuerdas1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //When this button is pressed, the current form automatically closes.
        protected void btnAddCarritoGA_Click(object sender, EventArgs e)
        {

            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de Guitarras Acusticas
            int GAMartin = (int)nudGAMartin.Value;
            int GAGibson = (int)nudGAGibson.Value;
            int GATaylor = (int)nudGATaylor.Value;
           

            
            //calculr precio total de cada GA
            long GAMartinPrecioTotal = allPrecios.CalcularprecioGA(GAMartin, allPrecios.precioGAMartin);
            long GAGibsonPrecioTotal = allPrecios.CalcularprecioGA(GAGibson, allPrecios.precioGAGibson);
            long GATaylorPrecioTotal = allPrecios.CalcularprecioGA(GATaylor, allPrecios.precioGATaylor);


            
            if (GAMartin > 0) { dtgvGuitarrasAcusticas.Rows.Add("GA Martin", GAMartin, GAMartinPrecioTotal); }
            if (GAGibson > 0) { dtgvGuitarrasAcusticas.Rows.Add("GA Gibson", GAGibson, GAGibsonPrecioTotal); }
            if (GATaylor > 0) { dtgvGuitarrasAcusticas.Rows.Add("GA Taylor", GATaylor, GATaylorPrecioTotal); }
            /*
            
            this.Controls.Add(dtgvGuitarrasAcusticas);*/
            dtgvGuitarrasAcusticas.Visible = true;

            
        }
        //This method is used to add rows to the DataGridView control dtgvGuitarrasAcusticas
        //with information about the acoustic guitars selected by the user and their calculated
        //total prices. Depending on the selected quantities, rows corresponding to the Martin,
        //Gibson, and Taylor acoustic guitar types are added.
        private void btnVCGAMartin_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas de la guitarra Martin
            string[] CGAMartin = { "Cuerpo de madera", "Cuerdas resistentes", "Durabilidad de afinación", "Incluye 2 puas" };

            // Mostrar las Caracteristicas de la Guitarra Martin en un MessageBox
            MessageBox.Show("La Guitarra Martin tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CGAMartin));
        }
        //When clicking the button "btnVCGAMartin," a message box is displayed listing the
        //features of the Martin guitar stored in the CGAMartin array. This allows the user to
        //obtain information about the characteristics of that particular type of guitar.
        private void btnVCGAGibson_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas de la guitarra Gibson
            string[] CGAGibson = { "Cuerpo de madera", "Cuerdas con alta Durabilidad", "Fácilidad de uso", "Incluye afinador" };

            // Mostrar las Caracteristicas de la Guitarra Gibson en un MessageBox
            MessageBox.Show("La Guitarra Gibson tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CGAGibson));
        }
        //When clicking the button "btnVCGAGibson," a message box is displayed listing the
        //features of the Gibson guitar stored in the CGAGibson array. This allows the user to
        //obtain information about the characteristics of that particular type of guitar.
        private void btnVGATaylor_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas de la guitarra Taylor
            string[] CGATaylor = { "Cuerpo de madera", "Peso ligero", "Fácilidad de uso", "Incluye Curso para Aprender Acordes" };

            // Mostrar las Caracteristicas de la Guitarra Taylor en un MessageBox
            MessageBox.Show("La Guitarra Taylor tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CGATaylor));
        }
        //When clicking the button "btnVGATaylor," a message box is displayed listing the
        //features of the Taylor guitar stored in the CGATaylor array. This allows the user to
        //obtain information about the characteristics of that particular type of guitar.
    }
}
