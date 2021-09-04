using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if ((txtRaio.Text == "") || (txtAltura.Text==""))
            {
                MessageBox.Show("Falta um valor");
            }

            double altura, raio,volume;

            if((double.TryParse(txtAltura.Text, out altura)) && (double.TryParse(txtRaio.Text,out raio)))
            {
                volume = Math.PI * Math.Pow(raio, 2) * altura;

                txtVolume.Text = volume.ToString("N3");
            }
            else
            {
                MessageBox.Show("Valores invalidos");
            }

            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();

            txtRaio.Focus();
        }
    }
}
