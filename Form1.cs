using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Segundo_Semestre.FI_Percusion_Forms;
using System.IO;
using static Proyecto_Segundo_Semestre.Comentarios;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Security.Policy;
using System.Security.Cryptography;

namespace Proyecto_Segundo_Semestre
{
    public partial class Form1 : Form
    {
        private List<string> comentarios = new List<string>();
        private string archivoComentarios = "comentarios.txt";
        //The code creates an empty list called "comments" that will be used to store comments,
        //and sets the file name in which the comments will be saved as "comments.txt".
        public Form1()
        {
            InitializeComponent();
            diseñoCharly();
            dtgCompra.Visible = false;
            
        }
        //The constructor of Form1 initializes the visual components of the form,
        //applies a custom design, and sets the visibility of the dtgCompra control to false.

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComentarios();
            btnTotalCompra.Visible = false;
            if(dtgCompra.Visible = true)
            {
                btnTotalCompra.Visible = true;
            }
        }
        //Here we instruct Form 1 that when it is opened, the btnCompraTotal button should
        //automatically become invisible, and this will change until the Carrito button is
        //instantiated.
        private void diseñoCharly()
        {
            panelSubMenúCuerdas.Visible= false;
            panelSubMenúPercusion.Visible= false;
            panelSubMenúAire.Visible= false;
            //otras formas de personalizar mi diseño
            
        }
        //Inside the "diseñocharly" method, we indicate that the panels where the instrument
        //buttons are located should be hidden and then activated later.

        private void ocultarSubMenú()
        {
            if (panelSubMenúCuerdas.Visible == true) 
            { 
            panelSubMenúCuerdas.Visible = false;
            }
            if (panelSubMenúPercusion.Visible== true)
            {
                panelSubMenúPercusion.Visible = false;
            }
            if (panelSubMenúAire.Visible == true)
            {
                panelSubMenúAire.Visible = false;
            }
        }
        //The "ocultarSubMenú" method is used to hide the sub-menu panels corresponding to
        //string, percussion, and wind instruments if they are visible in the graphical
        //interface.
        private void mostrarSubMenú(Panel SubMenú)
        {
            if (SubMenú.Visible == false)
            {
                ocultarSubMenú();
                SubMenú.Visible= true;
            }
            else
            {
                SubMenú.Visible = false;
            }
        }
        //This method is used to show or hide a sub-menu panel based on its current state.
        //If the sub-menu panel is not visible, other sub-menu panels are hidden, and the
        //current panel is shown.If the sub-menu panel is already visible, it is hidden.
        #region instrumentosdecuerdas
        //We create the "instrumentosdecuerdas" region to have a bit more control over the
        //order of our code.
        private void btnInstrumentosCuerdas_Click(object sender, EventArgs e)
        {
            mostrarSubMenú(panelSubMenúCuerdas);
        }
        //Within this button, we instruct it to display the submenu of string instruments.
        private void button1_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Instrumentos_de_Cuerdas1 cuerdas1 = new Instrumentos_de_Cuerdas1(dtgCompra);
            cuerdas1.Show();
        }
        //We instruct it that when the "guitarras acústicas" button is pressed, it should
        //hide the submenu and, at the same time, open the "Instrumentos_de_Cuerdas1" form,
        //passing the parameter of our DataGridView where we want the items to be added that
        //the user wants to purchase.
        private void button2_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas2 cuerdas2 = new Cuerdas2(dtgCompra);
            cuerdas2.Show();
        }
        //We follow the same process as before, changing the form to be displayed to
        //"cuerdas2" so that we can view the electric guitars.
        private void button3_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas3 cuerdas3 = new Cuerdas3(dtgCompra);
            cuerdas3.Show();
        }
        //We continue following the same path as before, but now to display "cuerdas3,"
        //which is used to view electric bass guitars.
        private void button4_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas4 cuerdas4 = new Cuerdas4(dtgCompra);
            cuerdas4.Show();
        }
        //We repeat the process to display "cuerdas4" where harps will be shown.
        private void button5_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas5 cuerdas5 = new Cuerdas5(dtgCompra);
            cuerdas5.Show();
        }
        //In the same way, we do it with "cuerdas5" to display violins.
        #endregion
        #region instrumentosdepercusion
        //Once again, we create a region for organization, and this time it is called
        //"Instrumentosdepercusión" (Percussion Instruments).
        private void btnInstrumentosPercusión_Click(object sender, EventArgs e)
        {
            mostrarSubMenú(panelSubMenúPercusion);
        }
        //We instruct the code that when the click event occurs on the
        //"btnInstrumentosdePercusión" button, it should display the "PanelSubMenúPercusión"
        //submenu to show all the buttons.
        private void button11_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones1 percusiones1 = new Percusiones1(dtgCompra);
            percusiones1.Show();
        }
        //In the same way as we did with the string instrument buttons, now for each button,
        //we will indicate that it opens the respective percussion form.Additionally, when
        //the user adds something to the cart using the button, it will be directly added to
        //the same DataGridView.This will allow us to calculate a total at the end.
        private void button10_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones2 percusiones2 = new Percusiones2(dtgCompra);
            percusiones2.Show();
        }
        //Here, we instruct it to open the "percusiones2" form to display the corresponding
        //electric drums.If something is added to the cart, it should be added to the total
        //count.
        private void button9_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones3 percusiones3 = new Percusiones3(dtgCompra);
            percusiones3.Show();
        }
        //We repeat the procedure from before to display the section for timpani instruments.
        private void button8_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones4 percusiones4 = new Percusiones4(dtgCompra);
            percusiones4.Show();
        }
        //In this case, it will now show the section for triangle instruments, following the same process as the previous buttons.
        private void button7_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones5 percusiones5 = new Percusiones5(dtgCompra);
            percusiones5.Show();
        }
        //We repeat the process for the last one to display the section for bass drum
        //instruments, and it can be added to the total if desired.
        #endregion
        #region instrumentosdeaire  
        //We create our last region, which is "instrumentosdeaire" (Wind Instruments),
        //where in this case, only one button will be displayed with its respective form.
        private void btnInstrumentosAire_Click(object sender, EventArgs e)
        {
            
            ocultarSubMenú();
            Aire5 aire5 = new Aire5(dtgCompra);
            aire5.Show();
        }
        //In this button, we instruct that when the click event occurs, the different panels
        //that have been opened should be hidden, and the "aire5" form should be displayed,
        //where all the different wind instruments that can be purchased are located.
        #endregion
        #region extras
        private void btnExtras_Click(object sender, EventArgs e)
        {
            //código para lo que quiera mostrar en cada botón
            dtgCompra.Visible = true;
            btnTotalCompra.Visible = true;
            
        }
        //In the button corresponding to the shopping cart, we indicate that it should
        //display the DataGridView where all the items to be purchased are
        //stored.Additionally, a button should be shown to calculate the total purchase
        //amount.
        #endregion



        private void btnComentarios_Click(object sender, EventArgs e)
        {
            panelVerInstrumentos.Visible = true;
            dtgCompra.Visible = false;
            
        }

        private void btnMostrarComentario_Click(object sender, EventArgs e)
        {
            lblMostrarComentarios.Text = comentarios.Count > 0 ? string.Join(Environment.NewLine, comentarios) : "No hay comentarios.";
        
        }
        //This method updates the text of the label control "lblMostrarComentarios" with the
        //comments stored in the "comentarios" list, displaying the comments on separate
        //lines. If there are no comments in the list, the message "No hay comentarios."
        //(No comments) is displayed.
        private void CargarComentarios()
        {
            if (File.Exists(archivoComentarios))
            {
                comentarios = File.ReadAllLines(archivoComentarios).ToList();
            }
        }
        //This method checks if the comments file exists, and if it does, it loads the
        //comments from the file into the "comentarios" list. This allows reading previously
        //stored comments and making them available in the list for future use.
        private void GuardarComentarios()
        {
            File.WriteAllLines(archivoComentarios, comentarios);
        }
        //This method saves the comments stored in the "comentarios" list to a text file.Each
        //comment is saved as a separate line in the file.
        private void button6_Click(object sender, EventArgs e)
        {
            string comentario = txtComentarios.Text;

            if (string.IsNullOrWhiteSpace(comentario))
            {
                lblMSJ.Text = "Comentario inválido. Por favor, escribe algo.";
            }
            else
            {
                comentarios.Add(comentario);
                GuardarComentarios();
                txtComentarios.Clear();
                lblMSJ.Text = "Comentario guardado correctamente.";
            }
        }
        //This method retrieves the text from the "txtComentarios" text box control and adds
        //it as a new comment to the "comentarios" list. Then, it saves the comments to a
        //text file and displays a success message in the "lblMSJ" label control. If the
        //entered comment is not valid, an error message is displayed.
        private void btnTotalCompra_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;

            // Recorre cada fila del DataGridView
            foreach (DataGridViewRow fila in dtgCompra.Rows)
            {
                // Verifica si la fila no está vacía
                if (!fila.IsNewRow)
                {
                    // Obtiene el valor de la celda en la columna deseada
                    // Asegúrate de especificar la columna correcta (por ejemplo, si es la segunda columna, usa Cells[1])
                    int valorCelda = Convert.ToInt32(fila.Cells["CPrecioTotal"].Value);

                    // Suma el valor al total
                    sumaTotal += valorCelda;
                }
            }

            // Muestra el resultado en un MessageBox o cualquier otro control
            MessageBox.Show("La suma total es: " + sumaTotal.ToString());
        }
        //This method iterates through the rows of a DataGridView and adds up the values of a
        //specific column (total price). Then, it displays the result of the total sum in a
        //message box. Make sure to adjust the column name and behavior according to your
        //specific needs.
        private void btnCerrarForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
