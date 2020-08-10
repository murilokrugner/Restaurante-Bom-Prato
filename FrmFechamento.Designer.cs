using System.Windows.Forms;

namespace RestauranteBomPrato
{
    partial class FrmFechamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonCredito = new System.Windows.Forms.RadioButton();
            this.radioButtonDebito = new System.Windows.Forms.RadioButton();
            this.radioButtonDinheiro = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonAmerican = new System.Windows.Forms.RadioButton();
            this.radioButtonMasterCard = new System.Windows.Forms.RadioButton();
            this.radioButtonVisa = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblRecebido = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.maskedTextBoxTroco = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRecebido = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPago = new System.Windows.Forms.MaskedTextBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonCredito);
            this.panel1.Controls.Add(this.radioButtonDebito);
            this.panel1.Controls.Add(this.radioButtonDinheiro);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 100);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonCredito
            // 
            this.radioButtonCredito.AutoSize = true;
            this.radioButtonCredito.Location = new System.Drawing.Point(278, 29);
            this.radioButtonCredito.Name = "radioButtonCredito";
            this.radioButtonCredito.Size = new System.Drawing.Size(140, 21);
            this.radioButtonCredito.TabIndex = 9;
            this.radioButtonCredito.TabStop = true;
            this.radioButtonCredito.Text = "Cartão de Crédito";
            this.radioButtonCredito.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebito
            // 
            this.radioButtonDebito.AutoSize = true;
            this.radioButtonDebito.Location = new System.Drawing.Point(120, 29);
            this.radioButtonDebito.Name = "radioButtonDebito";
            this.radioButtonDebito.Size = new System.Drawing.Size(136, 21);
            this.radioButtonDebito.TabIndex = 8;
            this.radioButtonDebito.TabStop = true;
            this.radioButtonDebito.Text = "Cartão de Débito";
            this.radioButtonDebito.UseVisualStyleBackColor = true;
            // 
            // radioButtonDinheiro
            // 
            this.radioButtonDinheiro.AutoSize = true;
            this.radioButtonDinheiro.Location = new System.Drawing.Point(20, 29);
            this.radioButtonDinheiro.Name = "radioButtonDinheiro";
            this.radioButtonDinheiro.Size = new System.Drawing.Size(82, 21);
            this.radioButtonDinheiro.TabIndex = 7;
            this.radioButtonDinheiro.TabStop = true;
            this.radioButtonDinheiro.Text = "Dinheiro";
            this.radioButtonDinheiro.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonAmerican);
            this.panel2.Controls.Add(this.radioButtonMasterCard);
            this.panel2.Controls.Add(this.radioButtonVisa);
            this.panel2.Location = new System.Drawing.Point(12, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // radioButtonAmerican
            // 
            this.radioButtonAmerican.AutoSize = true;
            this.radioButtonAmerican.Location = new System.Drawing.Point(278, 42);
            this.radioButtonAmerican.Name = "radioButtonAmerican";
            this.radioButtonAmerican.Size = new System.Drawing.Size(142, 21);
            this.radioButtonAmerican.TabIndex = 10;
            this.radioButtonAmerican.TabStop = true;
            this.radioButtonAmerican.Text = "American Express";
            this.radioButtonAmerican.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasterCard
            // 
            this.radioButtonMasterCard.AutoSize = true;
            this.radioButtonMasterCard.Location = new System.Drawing.Point(120, 42);
            this.radioButtonMasterCard.Name = "radioButtonMasterCard";
            this.radioButtonMasterCard.Size = new System.Drawing.Size(100, 21);
            this.radioButtonMasterCard.TabIndex = 9;
            this.radioButtonMasterCard.TabStop = true;
            this.radioButtonMasterCard.Text = "Mastercard";
            this.radioButtonMasterCard.UseVisualStyleBackColor = true;
            // 
            // radioButtonVisa
            // 
            this.radioButtonVisa.AutoSize = true;
            this.radioButtonVisa.Location = new System.Drawing.Point(20, 42);
            this.radioButtonVisa.Name = "radioButtonVisa";
            this.radioButtonVisa.Size = new System.Drawing.Size(56, 21);
            this.radioButtonVisa.TabIndex = 8;
            this.radioButtonVisa.TabStop = true;
            this.radioButtonVisa.Text = "Visa";
            this.radioButtonVisa.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTroco);
            this.panel3.Controls.Add(this.lblRecebido);
            this.panel3.Controls.Add(this.lblPago);
            this.panel3.Controls.Add(this.maskedTextBoxTroco);
            this.panel3.Controls.Add(this.maskedTextBoxRecebido);
            this.panel3.Controls.Add(this.maskedTextBoxPago);
            this.panel3.Location = new System.Drawing.Point(473, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 236);
            this.panel3.TabIndex = 2;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(12, 167);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(45, 17);
            this.lblTroco.TabIndex = 11;
            this.lblTroco.Text = "Troco";
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Location = new System.Drawing.Point(12, 100);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(105, 17);
            this.lblRecebido.TabIndex = 10;
            this.lblRecebido.Text = "Valor Recebido";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(12, 34);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(113, 17);
            this.lblPago.TabIndex = 9;
            this.lblPago.Text = "Valor a ser pago";
            // 
            // maskedTextBoxTroco
            // 
            this.maskedTextBoxTroco.Location = new System.Drawing.Point(140, 162);
            this.maskedTextBoxTroco.Name = "maskedTextBoxTroco";
            this.maskedTextBoxTroco.Size = new System.Drawing.Size(104, 22);
            this.maskedTextBoxTroco.TabIndex = 9;
            // 
            // maskedTextBoxRecebido
            // 
            this.maskedTextBoxRecebido.Location = new System.Drawing.Point(140, 97);
            this.maskedTextBoxRecebido.Name = "maskedTextBoxRecebido";
            this.maskedTextBoxRecebido.Size = new System.Drawing.Size(104, 22);
            this.maskedTextBoxRecebido.TabIndex = 8;
            this.maskedTextBoxRecebido.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxRecebido_MaskInputRejected);
            this.maskedTextBoxRecebido.Click += new System.EventHandler(this.maskedTextBoxRecebido_Click);
            // 
            // maskedTextBoxPago
            // 
            this.maskedTextBoxPago.Location = new System.Drawing.Point(140, 31);
            this.maskedTextBoxPago.Name = "maskedTextBoxPago";
            this.maskedTextBoxPago.Size = new System.Drawing.Size(104, 22);
            this.maskedTextBoxPago.TabIndex = 7;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(632, 275);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(140, 33);
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(29, 9);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(144, 17);
            this.lblPagamento.TabIndex = 4;
            this.lblPagamento.Text = "Forma de Pagamento";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(29, 148);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(119, 17);
            this.lblCredito.TabIndex = 5;
            this.lblCredito.Text = "Cartão de Crédito";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(494, 9);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(145, 17);
            this.lblDados.TabIndex = 6;
            this.lblDados.Text = "Dados do Pagamento";
            this.lblDados.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 320);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento";
            this.Activated += new System.EventHandler(this.FrmFechamento_Activated);
            this.MouseCaptureChanged += new System.EventHandler(this.maskedTextBoxRcebido_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTroco;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRecebido;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPago;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblRecebido;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.RadioButton radioButtonCredito;
        private System.Windows.Forms.RadioButton radioButtonDebito;
        private System.Windows.Forms.RadioButton radioButtonDinheiro;
        private System.Windows.Forms.RadioButton radioButtonAmerican;
        private System.Windows.Forms.RadioButton radioButtonMasterCard;
        private System.Windows.Forms.RadioButton radioButtonVisa;

        
    }
}