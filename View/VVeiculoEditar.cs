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
        private object item;

        public VVeiculoEditar()
        {
            InitializeComponent();
        }

        public VVeiculoEditar(object item)
        {
            this.item = item;
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
    }
}
