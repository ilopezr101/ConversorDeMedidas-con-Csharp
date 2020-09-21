using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMedidas
{
    public partial class Form1 : Form
    {
        Miligramos miligramos = new Miligramos();
        Gramos gramos = new Gramos();
        Decagramos decagramos = new Decagramos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (cbUnidadDeMedida.SelectedIndex == 0)
            {
                miligramos.setNumero(double.Parse(txtNumero.Text));
                textBox2.Text = Convert.ToString(String.Format("{0:n0}", miligramos.calcularMiligramos()));

            }
            else if (cbUnidadDeMedida.SelectedIndex == 1)
            {
                gramos.setNumero(double.Parse(txtNumero.Text));
                textBox2.Text = Convert.ToString(String.Format("{0:n0}",gramos.calcularGramos()));
                
            }
            else if (cbUnidadDeMedida.SelectedIndex == 2)
            {
                decagramos.setNumero(double.Parse(txtNumero.Text));
                textBox2.Text = Convert.ToString(String.Format("{0:n0}", decagramos.calculardecagramos()));
            }
            
        }

        private void cbUnidadDeMedida_SelectedValueChanged(object sender, EventArgs e)
        {

        }



    }
}
