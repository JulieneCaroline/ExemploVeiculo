namespace View
{
    partial class VVeiculoCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRENAVAM = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.buttonSalvarVeiculo = new System.Windows.Forms.Button();
            this.maskedTextBoxAnoModelo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAnoFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENAVAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano de Fabricação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano do Modelo";
            // 
            // textBoxRENAVAM
            // 
            this.textBoxRENAVAM.Location = new System.Drawing.Point(129, 64);
            this.textBoxRENAVAM.Name = "textBoxRENAVAM";
            this.textBoxRENAVAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxRENAVAM.TabIndex = 5;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(129, 96);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(166, 20);
            this.textBoxPlaca.TabIndex = 6;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(129, 130);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(166, 20);
            this.textBoxModelo.TabIndex = 7;
            // 
            // buttonSalvarVeiculo
            // 
            this.buttonSalvarVeiculo.Location = new System.Drawing.Point(244, 260);
            this.buttonSalvarVeiculo.Name = "buttonSalvarVeiculo";
            this.buttonSalvarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarVeiculo.TabIndex = 12;
            this.buttonSalvarVeiculo.Text = "Salvar";
            this.buttonSalvarVeiculo.UseVisualStyleBackColor = true;
            this.buttonSalvarVeiculo.Click += new System.EventHandler(this.buttonSalvarVeiculo_Click);
            // 
            // maskedTextBoxAnoModelo
            // 
            this.maskedTextBoxAnoModelo.Location = new System.Drawing.Point(129, 172);
            this.maskedTextBoxAnoModelo.Mask = "00/00/0000";
            this.maskedTextBoxAnoModelo.Name = "maskedTextBoxAnoModelo";
            this.maskedTextBoxAnoModelo.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAnoModelo.TabIndex = 13;
            this.maskedTextBoxAnoModelo.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxAnoFabricacao
            // 
            this.maskedTextBoxAnoFabricacao.Location = new System.Drawing.Point(129, 208);
            this.maskedTextBoxAnoFabricacao.Mask = "00/00/0000";
            this.maskedTextBoxAnoFabricacao.Name = "maskedTextBoxAnoFabricacao";
            this.maskedTextBoxAnoFabricacao.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAnoFabricacao.TabIndex = 14;
            this.maskedTextBoxAnoFabricacao.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(129, 38);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(166, 20);
            this.textBoxCPF.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CPF do proprietario";
            // 
            // VVeiculoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 296);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.maskedTextBoxAnoFabricacao);
            this.Controls.Add(this.maskedTextBoxAnoModelo);
            this.Controls.Add(this.buttonSalvarVeiculo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxRENAVAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VVeiculoCadastro";
            this.Text = "VVeiculoCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRENAVAM;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Button buttonSalvarVeiculo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAnoModelo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAnoFabricacao;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label label6;
    }
}