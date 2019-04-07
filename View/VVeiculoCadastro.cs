using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using DAL;
using Model;

namespace View
{
    public partial class VVeiculoCadastro : Form
    {
        MPessoa atual = null;

        public VVeiculoCadastro(MPessoa item)
        {
            InitializeComponent();
            atual = item;
        }

        

        private void buttonSalvarVeiculo_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(atual.Nome);

            ////todo: validação da entrada
            MVeiculo item = new MVeiculo();

            item.RENAVAM = textBoxRENAVAM.Text;
            item.Placa = textBoxPlaca.Text;
            item.Modelo = textBoxModelo.Text;
            // Regex regex = new Regex(@"[^\d]");
            int AuxAnoModelo = Convert.ToInt32(textBoxAnoModelo.Text);
            item.AnoModelo = AuxAnoModelo;
            int AuxAnoFabricacao = Convert.ToInt32(textBoxAnoFabricacao.Text);
            item.AnoFabricacao = AuxAnoFabricacao;
            item.PessoaCPF = atual.CPF;

            try
            {
                CVeiculo.Inserir(item);
                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VVeiculoCadastro_Load(object sender, EventArgs e)
        {
            atual = CPessoa.Obter(atual);

            if (atual != null)
            {
                textBoxCPF.Text = atual.CPF;
            }
            else
            {
                Close();
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
