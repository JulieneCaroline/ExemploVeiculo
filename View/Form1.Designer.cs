namespace View
{
    partial class Form1
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
            this.buttonCadastroPessoa = new System.Windows.Forms.Button();
            this.buttonPesquisaPessoa = new System.Windows.Forms.Button();
            this.buttonPesquisaVeiculo = new System.Windows.Forms.Button();
            this.buttonCadastroVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCadastroPessoa
            // 
            this.buttonCadastroPessoa.Location = new System.Drawing.Point(12, 12);
            this.buttonCadastroPessoa.Name = "buttonCadastroPessoa";
            this.buttonCadastroPessoa.Size = new System.Drawing.Size(153, 23);
            this.buttonCadastroPessoa.TabIndex = 0;
            this.buttonCadastroPessoa.Text = "Cadastro de Pessoa";
            this.buttonCadastroPessoa.UseVisualStyleBackColor = true;
            this.buttonCadastroPessoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPesquisaPessoa
            // 
            this.buttonPesquisaPessoa.Location = new System.Drawing.Point(12, 41);
            this.buttonPesquisaPessoa.Name = "buttonPesquisaPessoa";
            this.buttonPesquisaPessoa.Size = new System.Drawing.Size(153, 23);
            this.buttonPesquisaPessoa.TabIndex = 1;
            this.buttonPesquisaPessoa.Text = "Pesquisa de Pessoa";
            this.buttonPesquisaPessoa.UseVisualStyleBackColor = true;
            this.buttonPesquisaPessoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPesquisaVeiculo
            // 
            this.buttonPesquisaVeiculo.Location = new System.Drawing.Point(13, 101);
            this.buttonPesquisaVeiculo.Name = "buttonPesquisaVeiculo";
            this.buttonPesquisaVeiculo.Size = new System.Drawing.Size(152, 23);
            this.buttonPesquisaVeiculo.TabIndex = 3;
            this.buttonPesquisaVeiculo.Text = "PesquisaVeiculo";
            this.buttonPesquisaVeiculo.UseVisualStyleBackColor = true;
            this.buttonPesquisaVeiculo.Click += new System.EventHandler(this.buttonPesquisaVeiculo_Click);
            // 
            // buttonCadastroVeiculo
            // 
            this.buttonCadastroVeiculo.Location = new System.Drawing.Point(13, 71);
            this.buttonCadastroVeiculo.Name = "buttonCadastroVeiculo";
            this.buttonCadastroVeiculo.Size = new System.Drawing.Size(152, 23);
            this.buttonCadastroVeiculo.TabIndex = 2;
            this.buttonCadastroVeiculo.Text = "Cadastro de Veiculo";
            this.buttonCadastroVeiculo.UseVisualStyleBackColor = true;
            this.buttonCadastroVeiculo.Click += new System.EventHandler(this.buttonCadastroVeiculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 246);
            this.Controls.Add(this.buttonPesquisaVeiculo);
            this.Controls.Add(this.buttonCadastroVeiculo);
            this.Controls.Add(this.buttonPesquisaPessoa);
            this.Controls.Add(this.buttonCadastroPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastroPessoa;
        private System.Windows.Forms.Button buttonPesquisaPessoa;
        private System.Windows.Forms.Button buttonPesquisaVeiculo;
        private System.Windows.Forms.Button buttonCadastroVeiculo;
    }
}

