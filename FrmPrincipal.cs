using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RestauranteBomPrato
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        double chopp;
        double petiscos;
        double refeicao;
        double porcentagem;
        public double total;
        public double recebido;

        private void lblPagar_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextPagar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (textMesa.Text == "")
            {
                MessageBox.Show("Por favor indique o número da mesa!");
                return;
            }

            if (checkBoxChopp.Checked == false && checkBoxPetiscos.Checked == false && checkBoxRefeicao.Checked == false)
            {
                MessageBox.Show("Selecione um item!");
                return;
            }


            if (checkBoxChopp.Checked == true)
            {
                if (textChopp.Text == "")
                {
                    MessageBox.Show("A quantidade está em branco");
                    return;
                }
                chopp = (int.Parse(textChopp.Text) * 4.50);
            }

            if (checkBoxPetiscos.Checked == true)
            {
                if (textPetiscos.Text == "")
                {
                    MessageBox.Show("A quantidade está em branco");
                    return;
                }
                petiscos = (int.Parse(textPetiscos.Text) * 7.90);
            }

            if (checkBoxRefeicao.Checked == true)
            {
                if (textRefeicao.Text == "")
                {
                    MessageBox.Show("A quantidade está em branco");
                    return;
                }
                refeicao = (int.Parse(textRefeicao.Text) * 15.90);
            }

            maskedTextParcial.Text = (chopp + petiscos + refeicao).ToString("C2", CultureInfo.CurrentCulture);

            porcentagem = (((chopp + petiscos + refeicao) * 10) / 100);

            maskedTextServico.Text = porcentagem.ToString("C2", CultureInfo.CurrentCulture);

            total = ((chopp + petiscos + refeicao) + porcentagem);

            maskedTextPagar.Text = total.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textMesa.Clear();
            textChopp.Clear();
            textPetiscos.Clear();
            textRefeicao.Clear();

            maskedTextPagar.Clear();
            maskedTextParcial.Clear();
            maskedTextServico.Clear();

            chopp = 0;
            petiscos = 0;
            refeicao = 0;
            porcentagem = 0;
            total = 0;
            recebido = 0;

        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            FrmDinheiroRecebido newFrmDinheiroRecebido = new FrmDinheiroRecebido(total);

            newFrmDinheiroRecebido.ShowDialog();

            this.Hide();

        }
    }
}
