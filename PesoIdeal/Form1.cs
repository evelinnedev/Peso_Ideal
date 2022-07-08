using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                Double Altura = 0, Pesoideal = 0;
                Altura = double.Parse(textAltura.Text);

                if (cmbSexo.Text == "Feminino")
                {
                    Pesoideal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + "," + " seu peso ideal é: " + Pesoideal.ToString() + "Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Masculino")
                {
                    Pesoideal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + "," + " seu peso ideal é: " + Pesoideal.ToString() + "Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informados", "Peso Ideal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            textAltura.Clear();
            cmbSexo.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
