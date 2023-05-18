using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Proyecto_Segundo_Semestre
{
    public partial class Cuerdas2 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //The statement "DataGridView dtgvGuitarrasAcusticas;" in the Cuerdas2 class indicates
        //that a variable named dtgvGuitarrasAcusticas of type DataGridView has been declared.
        public Cuerdas2(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //When constructing an instance of the Cuerdas2 class and passing a DataGridView
        //object as an argument to the constructor, that object is assigned to the instance
        //variable dtgvGuitarrasAcusticas. This allows you to use that control in other methods
        //or events of the class.
        private void Cuerdas2_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarCuerdas2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //We instruct the program that when this button is pressed, the "cuerdas2" form should
        //automatically close.
        private void btnCarritoGE_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de Guitarras Acusticas
            int GEFender = (int)nudGEFender.Value;
            int GEIbanez = (int)nudGEIbanez.Value;
            int GEGibson = (int)nudGEGibson.Value;


            //calculr precio total de cada GA
            long GEFenderPrecioTotal = allPrecios.CalcularprecioGE(GEFender, allPrecios.precioGEFender);
            long GEIbanezPrecioTotal = allPrecios.CalcularprecioGE(GEIbanez, allPrecios.precioGEIbanez);
            long GEGibsonPrecioTotal = allPrecios.CalcularprecioGE(GEGibson, allPrecios.precioGEGibson);


            if (GEFender > 0) { dtgvGuitarrasAcusticas.Rows.Add("GE Fender", GEFender, GEFenderPrecioTotal); }
            if (GEIbanez > 0) { dtgvGuitarrasAcusticas.Rows.Add("GE Ibanez", GEIbanez, GEIbanezPrecioTotal); }
            if (GEGibson > 0) { dtgvGuitarrasAcusticas.Rows.Add("GE Gibson", GEGibson, GEGibsonPrecioTotal); }
        }
        //When clicking the button "btnCarritoGE," the quantities of Fender, Ibanez, and
        //Gibson electric guitars selected by the user are obtained. The total price is
        //calculated for each type of guitar, and a row is added to the DataGridView control
        //with the corresponding information.
        private void btnCGEFender_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas de la guitarra Fender
            string[] CGEFender = { "Cuerpo de madera", "Cuerdas Gruesas", "Resistente a caidas y golpes", "Incluye CD de Práctica" };

            // Mostrar las Caracteristicas de la Guitarra Fender en un MessageBox
            MessageBox.Show("La Guitarra Fender tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine,CGEFender));
        }
        //When clicking the button "btnCGEFender," a message box is displayed with the
        //characteristics of the Fender guitar.
        private void btnCGEIbanez_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas de la guitarra Ibanez
            string[] CGEIbanez = { "Cuerpo de madera", "Pintura brillante y duradera", "Excelente Sónido" };

            // Mostrar las Caracteristicas de la Guitarra Ibanez en un MessageBox
            MessageBox.Show("La Guitarra Ibanez tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CGEIbanez));
        }
        //When clicking the button "btnCGEIbanez," a message box is displayed with the
        //characteristics of the Ibanez guitar.
        private void btnCGEGibson_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas de la guitarra Gibson
            string[] CGEGibson = { "Cuerpo de madera", "Cuerdas Resistentes a largo plazo", "Perfecta para empezar a Prácticar", "Incluye Amplificador" };

            // Mostrar las Caracteristicas de la Guitarra Gibson en un MessageBox
            MessageBox.Show("La Guitarra Gibson tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CGEGibson));
        }
        //When clicking the button "btnCGEGibson," a message box is displayed with the
        //characteristics of the Gibson guitar.
    }
}
