using Controller;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class VVeiculoEditar : Form
    {
        MVeiculo atual = null;
        internal bool Atualizou = false;

        public VVeiculoEditar(MVeiculo item)
        {
            InitializeComponent();
            atual = item;

        }

        private void buttonSalvarVeiculo_Click(object sender, EventArgs e)
        {

            atual.RENAVAM = textBoxRENAVAM.Text;

            atual.Placa = textBoxPlaca.Text;
            atual.Modelo = textBoxModelo.Text;

            int AuxAnoModelo = Convert.ToInt32(textBoxAnoModelo.Text);
            atual.AnoModelo = AuxAnoModelo;

            int AuxAnoFabricacao = Convert.ToInt32(textBoxAnoFabricacao.Text);
            atual.AnoFabricacao = AuxAnoFabricacao;

            atual.PessoaCPF = comboBoxCpf.Text;

            bool sucesso = false;

            try
            {
                CVeiculo.Atualizar(atual);
                //MessageBox.Show("Dados salvos com sucesso!");
                sucesso = true;
            }
            catch 
            {
                MessageBox.Show("Erro na atualização!");
            }

            if (sucesso)
            {
                MessageBox.Show("Dados atualizados com sucesso!");
                Atualizou = true;
                Close();
            }
        }

        private void VVeiculoEditar_Load(object sender, EventArgs e)
        {
            List<MPessoa> ListaCPF = DPessoa.PesquisarComboBox(null);

            foreach (MPessoa CPF in ListaCPF)
            {
                comboBoxCpf.Items.Add(CPF.CPF);
            }

            atual = CVeiculo.Obter(atual);
           
            if (atual != null)
            {

                comboBoxCpf.Text = atual.PessoaCPF;
                textBoxRENAVAM.Text = atual.RENAVAM;
                textBoxPlaca.Text = atual.Placa;
                textBoxModelo.Text = atual.Modelo;
                textBoxAnoModelo.Text = atual.AnoModelo.ToString();
                textBoxAnoFabricacao.Text = atual.AnoFabricacao.ToString();

            }
            else
            {
                Close();
            }
        }
    }
}
