using Controller;
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
            try
            {
                //CPessoa.Inserir(item);
                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VVeiculoEditar_Load(object sender, EventArgs e)
        {
            atual = CVeiculo.Obter(atual);

            if (atual != null)
            {
                textBoxRENAVAM.Text = atual.RENAVAM;
                textBoxPlaca.Text = atual.Placa;
                textBoxModelo.Text = atual.Modelo;
                textBoxAnoModelo.Text = atual.AnoModelo.ToString();
                textBoxAnoFabricacao.Text = atual.ToString();
            }
            else
            {
                Close();
            }
        }
    }
}
