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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VVeiculoCadastro));
            this.buttonSalvarVeiculo = new System.Windows.Forms.Button();
            this.textBoxAnoFabricacao = new System.Windows.Forms.TextBox();
            this.textBoxAnoModelo = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxRENAVAM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSalvarVeiculo
            // 
            this.buttonSalvarVeiculo.Location = new System.Drawing.Point(33, 256);
            this.buttonSalvarVeiculo.Name = "buttonSalvarVeiculo";
            this.buttonSalvarVeiculo.Size = new System.Drawing.Size(237, 23);
            this.buttonSalvarVeiculo.TabIndex = 25;
            this.buttonSalvarVeiculo.Text = "Salvar";
            this.buttonSalvarVeiculo.UseVisualStyleBackColor = true;
            this.buttonSalvarVeiculo.Click += new System.EventHandler(this.buttonSalvarVeiculo_Click);
            // 
            // textBoxAnoFabricacao
            // 
            this.textBoxAnoFabricacao.Location = new System.Drawing.Point(131, 226);
            this.textBoxAnoFabricacao.Name = "textBoxAnoFabricacao";
            this.textBoxAnoFabricacao.Size = new System.Drawing.Size(139, 20);
            this.textBoxAnoFabricacao.TabIndex = 24;
            // 
            // textBoxAnoModelo
            // 
            this.textBoxAnoModelo.Location = new System.Drawing.Point(131, 191);
            this.textBoxAnoModelo.Name = "textBoxAnoModelo";
            this.textBoxAnoModelo.Size = new System.Drawing.Size(139, 20);
            this.textBoxAnoModelo.TabIndex = 23;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(131, 154);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(139, 20);
            this.textBoxModelo.TabIndex = 22;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(131, 118);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(139, 20);
            this.textBoxPlaca.TabIndex = 21;
            // 
            // textBoxRENAVAM
            // 
            this.textBoxRENAVAM.Location = new System.Drawing.Point(131, 81);
            this.textBoxRENAVAM.Name = "textBoxRENAVAM";
            this.textBoxRENAVAM.Size = new System.Drawing.Size(139, 20);
            this.textBoxRENAVAM.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ano da Fabricacao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ano do Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "RENAVAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CPF do proprietario";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(131, 42);
            this.textBoxCPF.Mask = "000,000,000-00";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.ReadOnly = true;
            this.textBoxCPF.Size = new System.Drawing.Size(139, 20);
            this.textBoxCPF.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nome do Proprietario";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(139, 20);
            this.txtNome.TabIndex = 28;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // VVeiculoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 297);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.buttonSalvarVeiculo);
            this.Controls.Add(this.textBoxAnoFabricacao);
            this.Controls.Add(this.textBoxAnoModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxRENAVAM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VVeiculoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Veiculos";
            this.Load += new System.EventHandler(this.VVeiculoCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvarVeiculo;
        private System.Windows.Forms.TextBox textBoxAnoFabricacao;
        private System.Windows.Forms.TextBox textBoxAnoModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxRENAVAM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
    }
}