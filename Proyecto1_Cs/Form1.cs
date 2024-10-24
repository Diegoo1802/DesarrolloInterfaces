using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Cs
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            //Creamos un nuevo formulario que al llamarlo se abra pulsado el boton
            Formulario2 nuevoForm2 = new Formulario2();
            nuevoForm2.Show(); 
        }

        private void btn_form3_Click(object sender, EventArgs e)
        {
            Formulario3 nuevoForm3 = new Formulario3();
            nuevoForm3.Show();  
        }

        private void btn_form4_Click(object sender, EventArgs e)
        {
            Formulario4 nuevoForm4 = new Formulario4(); 
            nuevoForm4.Show();
        }

        private void btn_form5_Click(object sender, EventArgs e)
        {
            Formulario5 nuevoForm5 = new Formulario5();
            nuevoForm5.Show();
        }

        private void btn_cv_Click(object sender, EventArgs e)
        {

        }

        private void btn_web_Click(object sender, EventArgs e)
        {

        }

        private void btn_enlace_Click(object sender, EventArgs e)
        {

        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {

        }
    }
}
