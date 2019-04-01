namespace View
{
    partial class VVeiculoPesquisa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VVeiculoPesquisa));
            this.Renavam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAnoFabricacao = new System.Windows.Forms.TextBox();
            this.txtPessoaCpf = new System.Windows.Forms.TextBox();
            this.dataGridViewVeiculo = new System.Windows.Forms.DataGridView();
            this.rENAVAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoFabricacaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoModeloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripVeiculos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mVeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPesquisarVeiculo = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonExcluirVeiculo = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculo)).BeginInit();
            this.contextMenuStripVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mVeiculoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Renavam
            // 
            this.Renavam.AutoSize = true;
            this.Renavam.Location = new System.Drawing.Point(12, 37);
            this.Renavam.Name = "Renavam";
            this.Renavam.Size = new System.Drawing.Size(60, 13);
            this.Renavam.TabIndex = 0;
            this.Renavam.Text = "RENAVAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano Fabricação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // txtRenavam
            // 
            this.txtRenavam.Location = new System.Drawing.Point(100, 37);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(115, 20);
            this.txtRenavam.TabIndex = 5;
            this.txtRenavam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(100, 72);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(115, 20);
            this.txtPlaca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(100, 115);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(115, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtAnoFabricacao
            // 
            this.txtAnoFabricacao.Location = new System.Drawing.Point(100, 156);
            this.txtAnoFabricacao.Name = "txtAnoFabricacao";
            this.txtAnoFabricacao.Size = new System.Drawing.Size(115, 20);
            this.txtAnoFabricacao.TabIndex = 8;
            // 
            // txtPessoaCpf
            // 
            this.txtPessoaCpf.Location = new System.Drawing.Point(100, 196);
            this.txtPessoaCpf.Name = "txtPessoaCpf";
            this.txtPessoaCpf.Size = new System.Drawing.Size(115, 20);
            this.txtPessoaCpf.TabIndex = 9;
            // 
            // dataGridViewVeiculo
            // 
            this.dataGridViewVeiculo.AllowUserToAddRows = false;
            this.dataGridViewVeiculo.AllowUserToDeleteRows = false;
            this.dataGridViewVeiculo.AllowUserToResizeColumns = false;
            this.dataGridViewVeiculo.AllowUserToResizeRows = false;
            this.dataGridViewVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVeiculo.AutoGenerateColumns = false;
            this.dataGridViewVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rENAVAMDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn1,
            this.modeloDataGridViewTextBoxColumn1,
            this.anoFabricacaoDataGridViewTextBoxColumn1,
            this.anoModeloDataGridViewTextBoxColumn1,
            this.pessoaCPFDataGridViewTextBoxColumn});
            this.dataGridViewVeiculo.ContextMenuStrip = this.contextMenuStripVeiculos;
            this.dataGridViewVeiculo.DataSource = this.mVeiculoBindingSource;
            this.dataGridViewVeiculo.Location = new System.Drawing.Point(238, 28);
            this.dataGridViewVeiculo.MultiSelect = false;
            this.dataGridViewVeiculo.Name = "dataGridViewVeiculo";
            this.dataGridViewVeiculo.ReadOnly = true;
            this.dataGridViewVeiculo.RowHeadersVisible = false;
            this.dataGridViewVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVeiculo.Size = new System.Drawing.Size(524, 251);
            this.dataGridViewVeiculo.TabIndex = 5;
            // 
            // rENAVAMDataGridViewTextBoxColumn
            // 
            this.rENAVAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rENAVAMDataGridViewTextBoxColumn.DataPropertyName = "RENAVAM";
            this.rENAVAMDataGridViewTextBoxColumn.FillWeight = 12F;
            this.rENAVAMDataGridViewTextBoxColumn.HeaderText = "RENAVAM";
            this.rENAVAMDataGridViewTextBoxColumn.Name = "rENAVAMDataGridViewTextBoxColumn";
            this.rENAVAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn1
            // 
            this.placaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placaDataGridViewTextBoxColumn1.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn1.FillWeight = 10F;
            this.placaDataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn1.Name = "placaDataGridViewTextBoxColumn1";
            this.placaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn1
            // 
            this.modeloDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modeloDataGridViewTextBoxColumn1.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.FillWeight = 10F;
            this.modeloDataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn1.Name = "modeloDataGridViewTextBoxColumn1";
            this.modeloDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // anoFabricacaoDataGridViewTextBoxColumn1
            // 
            this.anoFabricacaoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anoFabricacaoDataGridViewTextBoxColumn1.DataPropertyName = "AnoFabricacao";
            this.anoFabricacaoDataGridViewTextBoxColumn1.FillWeight = 18F;
            this.anoFabricacaoDataGridViewTextBoxColumn1.HeaderText = "Ano de Fabricacao";
            this.anoFabricacaoDataGridViewTextBoxColumn1.Name = "anoFabricacaoDataGridViewTextBoxColumn1";
            this.anoFabricacaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // anoModeloDataGridViewTextBoxColumn1
            // 
            this.anoModeloDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.anoModeloDataGridViewTextBoxColumn1.DataPropertyName = "AnoModelo";
            this.anoModeloDataGridViewTextBoxColumn1.FillWeight = 16F;
            this.anoModeloDataGridViewTextBoxColumn1.HeaderText = "Ano de Modelo";
            this.anoModeloDataGridViewTextBoxColumn1.Name = "anoModeloDataGridViewTextBoxColumn1";
            this.anoModeloDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pessoaCPFDataGridViewTextBoxColumn
            // 
            this.pessoaCPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pessoaCPFDataGridViewTextBoxColumn.DataPropertyName = "PessoaCPF";
            this.pessoaCPFDataGridViewTextBoxColumn.FillWeight = 10F;
            this.pessoaCPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.pessoaCPFDataGridViewTextBoxColumn.Name = "pessoaCPFDataGridViewTextBoxColumn";
            this.pessoaCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStripVeiculos
            // 
            this.contextMenuStripVeiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStripVeiculos.Name = "contextMenuStripVeiculos";
            this.contextMenuStripVeiculos.Size = new System.Drawing.Size(109, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // mVeiculoBindingSource
            // 
            this.mVeiculoBindingSource.DataSource = typeof(Model.MVeiculo);
            // 
            // buttonPesquisarVeiculo
            // 
            this.buttonPesquisarVeiculo.Location = new System.Drawing.Point(15, 256);
            this.buttonPesquisarVeiculo.Name = "buttonPesquisarVeiculo";
            this.buttonPesquisarVeiculo.Size = new System.Drawing.Size(200, 23);
            this.buttonPesquisarVeiculo.TabIndex = 11;
            this.buttonPesquisarVeiculo.Text = "Pesquisar";
            this.buttonPesquisarVeiculo.UseVisualStyleBackColor = true;
            this.buttonPesquisarVeiculo.Click += new System.EventHandler(this.buttonPesquisarVeiculo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonExcluirVeiculo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonExcluirVeiculo
            // 
            this.toolStripButtonExcluirVeiculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExcluirVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExcluirVeiculo.Image")));
            this.toolStripButtonExcluirVeiculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcluirVeiculo.Name = "toolStripButtonExcluirVeiculo";
            this.toolStripButtonExcluirVeiculo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExcluirVeiculo.Text = "toolStripButton1";
            this.toolStripButtonExcluirVeiculo.Click += new System.EventHandler(this.toolStripButtonExcluirVeiculo_Click);
            // 
            // VPesquisaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 297);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonPesquisarVeiculo);
            this.Controls.Add(this.dataGridViewVeiculo);
            this.Controls.Add(this.txtPessoaCpf);
            this.Controls.Add(this.txtAnoFabricacao);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtRenavam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Renavam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VPesquisaVeiculo";
            this.Text = "Pesquisar Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculo)).EndInit();
            this.contextMenuStripVeiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mVeiculoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Renavam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAnoFabricacao;
        private System.Windows.Forms.TextBox txtPessoaCpf;
        private System.Windows.Forms.DataGridView dataGridViewVeiculo;
        private System.Windows.Forms.Button buttonPesquisarVeiculo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcluirVeiculo;
        private System.Windows.Forms.BindingSource mVeiculoBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripVeiculos;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn rENAVAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoFabricacaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoModeloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaCPFDataGridViewTextBoxColumn;
    }
}