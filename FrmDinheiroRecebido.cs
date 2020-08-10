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
    public partial class FrmDinheiroRecebido : Form
    {

        public double vtotal;
        public double recebido; 

        public FrmDinheiroRecebido(double total)
        {
            InitializeComponent();

            maskedTextBoxTotal.Text = total.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            vtotal = double.Parse(maskedTextBoxTotal.Text);

            recebido = double.Parse(maskedTextBoxDinheiro.Text);

            FrmFechamento newFrmFechamento = new FrmFechamento(vtotal, recebido);

            newFrmFechamento.Show();

           this.Close();
        }
    }
}
