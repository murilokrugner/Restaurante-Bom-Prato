using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteBomPrato
{
    public partial class FrmFechamento : Form
    {
        private double total;

        public FrmFechamento(double vtotal, double recebido)
        {
            InitializeComponent();

            maskedTextBoxPago.Text = vtotal.ToString();

            maskedTextBoxRecebido.Text = recebido.ToString();
        }

        public FrmFechamento(double total)
        {
            this.total = total;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            if (radioButtonDinheiro.Checked == true)
            {
                maskedTextBoxTroco.Text = (double.Parse(maskedTextBoxRecebido.Text) - double.Parse(maskedTextBoxPago.Text)).ToString();

                MessageBox.Show("Pagamento realizado com sucesso!");
            }

            if (radioButtonCredito.Checked == true)
            {
                if (radioButtonMasterCard.Checked == false && radioButtonAmerican.Checked == false && radioButtonVisa.Checked == false)
                {
                    MessageBox.Show("Por favor, selecione a bandeira do cartão de credito");
                    return;
                }

                maskedTextBoxTroco.Text = (double.Parse(maskedTextBoxRecebido.Text) - double.Parse(maskedTextBoxPago.Text)).ToString();

                MessageBox.Show("Pagamento realizado com sucesso!");
            }

            if (radioButtonDebito.Checked == true)
            {
                maskedTextBoxTroco.Text = (double.Parse(maskedTextBoxRecebido.Text) - double.Parse(maskedTextBoxPago.Text)).ToString();

                MessageBox.Show("Pagamento realizado com sucesso!");
            }
        }

        private void maskedTextBoxRecebido_Click(object sender, EventArgs e)
        {


        }

        private void maskedTextBoxRcebido_Click(object sender, EventArgs e)
        {

        }

        private void FrmFechamento_Activated(object sender, EventArgs e)
        {
            

        }

        private void maskedTextBoxRecebido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
