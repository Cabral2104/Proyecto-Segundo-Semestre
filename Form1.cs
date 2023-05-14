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

namespace Proyecto_Segundo_Semestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            diseñoCharly();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void diseñoCharly()
        {
            panelSubMenúCuerdas.Visible= false;
            panelSubMenúPercusion.Visible= false;
            panelSubMenúAire.Visible= false;
            //otras formas de personalizar mi diseño
            
        }

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
        #region instrumentosdecuerdas
        private void btnInstrumentosCuerdas_Click(object sender, EventArgs e)
        {
            mostrarSubMenú(panelSubMenúCuerdas);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Instrumentos_de_Cuerdas1 cuerdas1 = new Instrumentos_de_Cuerdas1();
            cuerdas1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas2 cuerdas2 = new Cuerdas2();
            cuerdas2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas3 cuerdas3 = new Cuerdas3();
            cuerdas3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas4 cuerdas4 = new Cuerdas4();
            cuerdas4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Cuerdas5 cuerdas5 = new Cuerdas5();
            cuerdas5.Show();
        }
        #endregion
        #region instrumentosdepercusion
        private void btnInstrumentosPercusión_Click(object sender, EventArgs e)
        {
            mostrarSubMenú(panelSubMenúPercusion);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones1 percusiones1 = new Percusiones1();
            percusiones1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones2 percusiones2 = new Percusiones2();
            percusiones2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones3 percusiones3 = new Percusiones3();
            percusiones3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones4 percusiones4 = new Percusiones4();
            percusiones4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Percusiones5 percusiones5 = new Percusiones5();
            percusiones5.Show();
        }
        #endregion
        #region instrumentosdeaire     
        private void btnInstrumentosAire_Click(object sender, EventArgs e)
        {
            
            ocultarSubMenú();
            Aire5 aire5 = new Aire5();
            aire5.Show();
        }

       

      
        #endregion
        #region extras
        private void btnExtras_Click(object sender, EventArgs e)
        {
            //código para lo que uiera mostrar en cada botón
            ocultarSubMenú();
            Extras1 extras1 = new Extras1();
            extras1.Show();
        }
        #endregion


        private Form FormularioActivo = null;

        private void abrirFormularioInstrumentos(Form FormularioInstrumentos)
        {
            //if(FormularioActivo!= null)
            //{
            //    FormularioActivo.Close();
            //    FormularioActivo = FormularioInstrumentos;
            //    FormularioInstrumentos.TopLevel = false;
            //    FormularioInstrumentos.FormBorderStyle= FormBorderStyle.None;
            //    FormularioInstrumentos.Dock = DockStyle.Fill;
            //    panelVerInstrumentos.Controls.Add(FormularioInstrumentos);
            //    panelVerInstrumentos.Tag = FormularioInstrumentos;
            //    panelVerInstrumentos.BringToFront();
            //    panelVerInstrumentos.Show();
            //}
        }

        //private void panelVerInstrumentos_Paint(object sender, PaintEventArgs e , Form FormularioInstrumentos)
        //{
        //    if (FormularioActivo != null)
        //    {
        //        FormularioActivo.Close();
        //        FormularioActivo = FormularioInstrumentos;
        //        FormularioInstrumentos.TopLevel = false;
        //        FormularioInstrumentos.FormBorderStyle = FormBorderStyle.None;
        //        FormularioInstrumentos.Dock = DockStyle.Fill;
        //        panelVerInstrumentos.Controls.Add(FormularioInstrumentos);
        //        panelVerInstrumentos.Tag = FormularioInstrumentos;
        //        panelVerInstrumentos.BringToFront();
        //        panelVerInstrumentos.Show();
        //    }
        //}
    }
}
