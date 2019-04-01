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
    public partial class VPessoaCadastro : Form
    {
        public VPessoaCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: validação da entrada
            MPessoa item = new MPessoa();

            item.CPF = txtCPF.Text;
            item.Nome = txtNome.Text;
            item.DataNascimento = txtDataNascimento.Value;

            try
            {
                CPessoa.Inserir(item);
                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VPessoaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
