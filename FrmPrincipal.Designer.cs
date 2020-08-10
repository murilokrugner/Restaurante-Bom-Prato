namespace RestauranteBomPrato
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextParcial = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextServico = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextPagar = new System.Windows.Forms.MaskedTextBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblParcial = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblPagar = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.checkBoxChopp = new System.Windows.Forms.CheckBox();
            this.checkBoxPetiscos = new System.Windows.Forms.CheckBox();
            this.checkBoxRefeicao = new System.Windows.Forms.CheckBox();
            this.textMesa = new System.Windows.Forms.TextBox();
            this.textChopp = new System.Windows.Forms.TextBox();
            this.textPetiscos = new System.Windows.Forms.TextBox();
            this.textRefeicao = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextParcial
            // 
            this.maskedTextParcial.Location = new System.Drawing.Point(396, 104);
            this.maskedTextParcial.Name = "maskedTextParcial";
            this.maskedTextParcial.ReadOnly = true;
            this.maskedTextParcial.Size = new System.Drawing.Size(127, 22);
            this.maskedTextParcial.TabIndex = 5;
            // 
            // maskedTextServico
            // 
            this.maskedTextServico.Location = new System.Drawing.Point(396, 165);
            this.maskedTextServico.Name = "maskedTextServico";
            this.maskedTextServico.ReadOnly = true;
            this.maskedTextServico.Size = new System.Drawing.Size(127, 22);
            this.maskedTextServico.TabIndex = 6;
            // 
            // maskedTextPagar
            // 
            this.maskedTextPagar.Location = new System.Drawing.Point(396, 228);
            this.maskedTextPagar.Name = "maskedTextPagar";
            this.maskedTextPagar.ReadOnly = true;
            this.maskedTextPagar.Size = new System.Drawing.Size(127, 22);
            this.maskedTextPagar.TabIndex = 7;
            this.maskedTextPagar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextPagar_MaskInputRejected);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(12, 29);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(62, 17);
            this.lblMesa.TabIndex = 8;
            this.lblMesa.Text = "N° Mesa";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(12, 84);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(59, 17);
            this.lblPedidos.TabIndex = 9;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQnt.Location = new System.Drawing.Point(222, 84);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(92, 17);
            this.lblQnt.TabIndex = 10;
            this.lblQnt.Text = "Quantidade";
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.Location = new System.Drawing.Point(393, 84);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(100, 17);
            this.lblParcial.TabIndex = 11;
            this.lblParcial.Text = "Total Parcial";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(393, 145);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(173, 17);
            this.lblTaxa.TabIndex = 12;
            this.lblTaxa.Text = "Taxa de Serviço (10%)";
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagar.Location = new System.Drawing.Point(393, 208);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(107, 17);
            this.lblPagar.TabIndex = 13;
            this.lblPagar.Text = "Total a Pagar";
            this.lblPagar.Click += new System.EventHandler(this.lblPagar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(206, 283);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(127, 35);
            this.btnVerificar.TabIndex = 14;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnConta
            // 
            this.btnConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConta.Location = new System.Drawing.Point(396, 283);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(127, 35);
            this.btnConta.TabIndex = 15;
            this.btnConta.Text = "Fechar Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // checkBoxChopp
            // 
            this.checkBoxChopp.AutoSize = true;
            this.checkBoxChopp.Location = new System.Drawing.Point(15, 119);
            this.checkBoxChopp.Name = "checkBoxChopp";
            this.checkBoxChopp.Size = new System.Drawing.Size(125, 21);
            this.checkBoxChopp.TabIndex = 16;
            this.checkBoxChopp.Text = "Chopp R$ 4,50";
            this.checkBoxChopp.UseVisualStyleBackColor = true;
            // 
            // checkBoxPetiscos
            // 
            this.checkBoxPetiscos.AutoSize = true;
            this.checkBoxPetiscos.Location = new System.Drawing.Point(15, 176);
            this.checkBoxPetiscos.Name = "checkBoxPetiscos";
            this.checkBoxPetiscos.Size = new System.Drawing.Size(137, 21);
            this.checkBoxPetiscos.TabIndex = 17;
            this.checkBoxPetiscos.Text = "Petiscos R$ 7,90";
            this.checkBoxPetiscos.UseVisualStyleBackColor = true;
            // 
            // checkBoxRefeicao
            // 
            this.checkBoxRefeicao.AutoSize = true;
            this.checkBoxRefeicao.Location = new System.Drawing.Point(15, 230);
            this.checkBoxRefeicao.Name = "checkBoxRefeicao";
            this.checkBoxRefeicao.Size = new System.Drawing.Size(148, 21);
            this.checkBoxRefeicao.TabIndex = 18;
            this.checkBoxRefeicao.Text = "Refeição R$ 15,90";
            this.checkBoxRefeicao.UseVisualStyleBackColor = true;
            // 
            // textMesa
            // 
            this.textMesa.Location = new System.Drawing.Point(80, 24);
            this.textMesa.MaxLength = 3;
            this.textMesa.Name = "textMesa";
            this.textMesa.Size = new System.Drawing.Size(100, 22);
            this.textMesa.TabIndex = 19;
            // 
            // textChopp
            // 
            this.textChopp.Location = new System.Drawing.Point(225, 117);
            this.textChopp.Name = "textChopp";
            this.textChopp.Size = new System.Drawing.Size(89, 22);
            this.textChopp.TabIndex = 20;
            // 
            // textPetiscos
            // 
            this.textPetiscos.Location = new System.Drawing.Point(225, 176);
            this.textPetiscos.Name = "textPetiscos";
            this.textPetiscos.Size = new System.Drawing.Size(89, 22);
            this.textPetiscos.TabIndex = 21;
            // 
            // textRefeicao
            // 
            this.textRefeicao.Location = new System.Drawing.Point(225, 228);
            this.textRefeicao.Name = "textRefeicao";
            this.textRefeicao.Size = new System.Drawing.Size(89, 22);
            this.textRefeicao.TabIndex = 22;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(15, 283);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 35);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 330);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textRefeicao);
            this.Controls.Add(this.textPetiscos);
            this.Controls.Add(this.textChopp);
            this.Controls.Add(this.textMesa);
            this.Controls.Add(this.checkBoxRefeicao);
            this.Controls.Add(this.checkBoxPetiscos);
            this.Controls.Add(this.checkBoxChopp);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblPagar);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.maskedTextPagar);
            this.Controls.Add(this.maskedTextServico);
            this.Controls.Add(this.maskedTextParcial);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante Bom Prato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextParcial;
        private System.Windows.Forms.MaskedTextBox maskedTextServico;
        private System.Windows.Forms.MaskedTextBox maskedTextPagar;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblPagar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.CheckBox checkBoxChopp;
        private System.Windows.Forms.CheckBox checkBoxPetiscos;
        private System.Windows.Forms.CheckBox checkBoxRefeicao;
        private System.Windows.Forms.TextBox textMesa;
        private System.Windows.Forms.TextBox textChopp;
        private System.Windows.Forms.TextBox textPetiscos;
        private System.Windows.Forms.TextBox textRefeicao;
        private System.Windows.Forms.Button btnLimpar;
    }
}

