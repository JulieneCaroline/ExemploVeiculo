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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new VPessoaEditar().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VPessoaPesquisa().ShowDialog();
        }

        private void buttonCadastroVeiculo_Click(object sender, EventArgs e)
        {
            //new VVeiculoCadastro().ShowDialog();
        }

        private void buttonPesquisaVeiculo_Click(object sender, EventArgs e)
        {
            new VVeiculoPesquisa().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
