namespace View
{
    partial class VVeiculoEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VVeiculoEditar));
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
            this.SuspendLayout();
            // 
            // buttonSalvarVeiculo
            // 
            this.buttonSalvarVeiculo.Location = new System.Drawing.Point(29, 222);
            this.buttonSalvarVeiculo.Name = "buttonSalvarVeiculo";
            this.buttonSalvarVeiculo.Size = new System.Drawing.Size(237, 23);
            this.buttonSalvarVeiculo.TabIndex = 38;
            this.buttonSalvarVeiculo.Text = "Editar";
            this.buttonSalvarVeiculo.UseVisualStyleBackColor = true;
            this.buttonSalvarVeiculo.Click += new System.EventHandler(this.buttonSalvarVeiculo_Click);
            // 
            // textBoxAnoFabricacao
            // 
            this.textBoxAnoFabricacao.Location = new System.Drawing.Point(127, 178);
            this.textBoxAnoFabricacao.Name = "textBoxAnoFabricacao";
            this.textBoxAnoFabricacao.Size = new System.Drawing.Size(139, 20);
            this.textBoxAnoFabricacao.TabIndex = 37;
            // 
            // textBoxAnoModelo
            // 
            this.textBoxAnoModelo.Location = new System.Drawing.Point(127, 143);
            this.textBoxAnoModelo.Name = "textBoxAnoModelo";
            this.textBoxAnoModelo.Size = new System.Drawing.Size(139, 20);
            this.textBoxAnoModelo.TabIndex = 36;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(127, 103);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(139, 20);
            this.textBoxModelo.TabIndex = 35;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(127, 58);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(139, 20);
            this.textBoxPlaca.TabIndex = 34;
            // 
            // textBoxRENAVAM
            // 
            this.textBoxRENAVAM.Location = new System.Drawing.Point(127, 18);
            this.textBoxRENAVAM.Name = "textBoxRENAVAM";
            this.textBoxRENAVAM.Size = new System.Drawing.Size(139, 20);
            this.textBoxRENAVAM.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "AnoFabricacao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "AnoModelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "RENAVAM";
            // 
            // VEditarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 274);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VEditarVeiculo";
            this.Text = "Editar Veiculo";
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
    }
}