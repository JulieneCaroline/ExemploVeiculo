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
    public partial class VVeiculoPesquisa : Form
    {
        public VVeiculoPesquisa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonExcluirVeiculo_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculo.SelectedRows != null &&
                dataGridViewVeiculo.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("Deseja excluir este Veiculo?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (r == DialogResult.Yes)
                {
                    //forma 1
                    //MPessoa item = new MPessoa();
                    //item.CPF = dataGridView1.SelectedRows[0].
                    //    Cells["cPFDataGridViewTextBoxColumn"].Value.ToString();

                    //forma 2
                    MVeiculo item = (MVeiculo)dataGridViewVeiculo.SelectedRows[0].
                       DataBoundItem;

                    bool sucesso = false;
                    try
                    {
                        CVeiculo.Excluir(item);
                        sucesso = true;
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao excluir o Veiculo selecionado",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (sucesso)
                    {
                        MessageBox.Show("Veiculo excluído com sucesso", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Forma 1
                        //btnPesquisar_Click(null, null);

                        //Forma 2
                        List<MVeiculo> lista = (List<MVeiculo>)dataGridViewVeiculo.DataSource;
                        lista.Remove(item);

                        dataGridViewVeiculo.DataSource = null;
                        dataGridViewVeiculo.DataSource = lista;
                    }
                }
            }
        }

        private void buttonPesquisarVeiculo_Click(object sender, EventArgs e)
        {
            MVeiculo item = new MVeiculo();

            //item.RENAVAM = txtRenavam.Text;
            //item.Placa = txtPlaca.Text;
            //item.Modelo = txtModelo.Text;
            //int AuxAnoFabricacao = Convert.ToInt32(txtAnoFabricacao.Text);
            //item.AnoFabricacao = AuxAnoFabricacao;
            //item.PessoaCPF = txtPessoaCpf.Text;

            dataGridViewVeiculo.DataSource = CVeiculo.Pesquisar(item);
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja excluir este Veiculo ?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Veiculo excluido com sucesso!",
                             "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void toolStripButtonEditarVeiculo_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (dataGridViewVeiculo.SelectedRows != null &&
               dataGridViewVeiculo.SelectedRows.Count > 0)
            {
                MVeiculo item = new MVeiculo();
                MPessoa pessoa = new MPessoa();

                item.RENAVAM = dataGridViewVeiculo.SelectedRows[0].
                    Cells["rENAVAMDataGridViewTextBoxColumn"].Value.ToString();

              

                VVeiculoEditar v = new VVeiculoEditar(item);
                v.ShowDialog();

                if (v.Atualizou)
                {
                    //atualiza o grid
                    //forma 1
                    //atualiza a lista sem ir no banco

                    //forma 2
                    // btnPesquisar_Click(null, null);
                }
            }
        }
    }
}
