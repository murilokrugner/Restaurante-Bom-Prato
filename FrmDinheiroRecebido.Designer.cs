namespace RestauranteBomPrato
{
    partial class FrmDinheiroRecebido
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
            this.labelValor = new System.Windows.Forms.Label();
            this.maskedTextBoxDinheiro = new System.Windows.Forms.MaskedTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.maskedTextBoxTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(12, 23);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(109, 17);
            this.labelValor.TabIndex = 0;
            this.labelValor.Text = "Valor Recebido:";
            // 
            // maskedTextBoxDinheiro
            // 
            this.maskedTextBoxDinheiro.Location = new System.Drawing.Point(140, 20);
            this.maskedTextBoxDinheiro.Name = "maskedTextBoxDinheiro";
            this.maskedTextBoxDinheiro.Size = new System.Drawing.Size(140, 22);
            this.maskedTextBoxDinheiro.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(205, 75);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 43);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // maskedTextBoxTotal
            // 
            this.maskedTextBoxTotal.Location = new System.Drawing.Point(63, 90);
            this.maskedTextBoxTotal.Name = "maskedTextBoxTotal";
            this.maskedTextBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(7, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // FrmDinheiroRecebido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 130);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.maskedTextBoxTotal);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.maskedTextBoxDinheiro);
            this.Controls.Add(this.labelValor);
            this.Name = "FrmDinheiroRecebido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinheiro Recebido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDinheiro;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}