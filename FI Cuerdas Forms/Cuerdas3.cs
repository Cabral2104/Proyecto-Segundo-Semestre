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

    public partial class Cuerdas3 : Form
    {
        DataGridView dtgvGuitarrasAcusticas;
        //The dtgvGuitarrasAcusticas object is used to display information related to electric
        //bass guitars in some type of graphical interface.
        public Cuerdas3(DataGridView dataGridView)
        {
            InitializeComponent();
            dtgvGuitarrasAcusticas = dataGridView;
        }
        //The Cuerdas3 constructor is used to initialize an instance of the Cuerdas3 class and
        //assign the provided DataGridView object to the dtgvGuitarrasAcusticas object of the
        //class. This allows the use and manipulation of the DataGridView object in other
        //methods and events of the Cuerdas3 class.
        private void Cuerdas3_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarCuerdas3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method indicates that when the button is clicked, the Cuerdas3 form will be
        //automatically closed.
        private void button1_Click(object sender, EventArgs e)
        {
            //crear instancia de la clase AllPrecios
            AllPrecios allPrecios = new AllPrecios();
            //obtener cantidad de numericdown de Guitarras Acusticas
            int BEYamaha = (int)nudBEYamaha.Value;
            int BEFender = (int)nudBEFender.Value;
            int BERedSub = (int)nudBERedSub.Value;


            //calculr precio total de cada GA
            long BEYamahaPrecioTotal = allPrecios.CalcularprecioBE(BEYamaha, allPrecios.precioBEYamaha);
            long BEFenderPrecioTotal = allPrecios.CalcularprecioBE(BEFender, allPrecios.precioBEFender);
            long BERedSubPrecioTotal = allPrecios.CalcularprecioBE(BERedSub, allPrecios.precioBERedSub);

            if (BEYamaha > 0) { dtgvGuitarrasAcusticas.Rows.Add("BE Yamaha", BEYamaha, BEYamahaPrecioTotal); }
            if (BEFender > 0) { dtgvGuitarrasAcusticas.Rows.Add("BE Fender", BEFender, BEFenderPrecioTotal); }
            if (BERedSub > 0) { dtgvGuitarrasAcusticas.Rows.Add("BE Red Sub", BERedSub, BERedSubPrecioTotal); }
        }
        //This method is responsible for retrieving the quantities from the NumericUpDown
        //controls corresponding to certain instruments, calculating the total prices using
        //an instance of the AllPrecios class, and adding the corresponding rows to the
        //DataGridView to display the information of the selected instruments and their
        //total prices.
        private void btnCBEYamaha_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas del Bajo Yamaha
            string[] CBEYamaha = { "Cuerpo de madera", "Cuerdas Gruesas", "Pintura de la mejor cálidad" };

            // Mostrar las Caracteristicas del Bajo Yamaha en un MessageBox
            MessageBox.Show("El Bajo Eléctrico Yamaha tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CBEYamaha));
        }
        //This method is responsible for displaying the characteristics of the Yamaha electric
        //bass in a MessageBox when the corresponding button is clicked.
        private void btnCBEFender_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas del Bajo Fender
            string[] CBEFender = { "Pintura brillante y relusiente", "La mejor cálidad de Audio del Mercado", "Incluye 3 puas" };

            // Mostrar las Caracteristicas del Bajo Fender en un MessageBox
            MessageBox.Show("El Bajo Eléctrico Fender tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CBEFender));
        }
        //This method is responsible for displaying the characteristics of the Fender electric
        //bass in a MessageBox when the corresponding button is clicked.
        private void btnCBERedSub_Click(object sender, EventArgs e)
        {
            // Declarar el arreglo de caracteristicas del Bajo RedSub
            string[] CBERedSub = { "Cuerpo de madera", "Perfecta Combinación de Colores", "Excelente Sistema de Sónido Envolvente"};

            // Mostrar las Caracteristicas del Bajo RedSub en un MessageBox
            MessageBox.Show("El Bajo Eléctrico RedSub tiene las siguientes Características:" + Environment.NewLine + string.Join(Environment.NewLine, CBERedSub));
        }
        //This method is responsible for displaying the characteristics of the RedSub electric
        //bass in a MessageBox when the corresponding button is clicked.
    }
}
