using Controller;
using Model;
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

namespace View
{
    public partial class VVeiculoCadastro : Form
    {
        private MPessoa item;

        public VVeiculoCadastro(string cPF)
        {
            InitializeComponent();

        }

        

        private void buttonSalvarVeiculo_Click(object sender, EventArgs e)
        {

            MessageBox.Show(item.CPF);
            ////todo: validação da entrada
            //MVeiculo item = new MVeiculo();

            //item.RENAVAM = textBoxRENAVAM.Text;
            //item.Placa = textBoxPlaca.Text;
            //item.Modelo = textBoxModelo.Text;
            //Regex regex = new Regex(@"[^\d]");
            //int AuxAnoModelo = Convert.ToInt32(regex.Replace(maskedTextBoxAnoModelo.Text, ""));
            //item.AnoModelo = AuxAnoModelo;
            //int AuxAnoFabricacao = Convert.ToInt32(regex.Replace(maskedTextBoxAnoFabricacao.Text, ""));
            //item.AnoFabricacao = AuxAnoFabricacao;


            //try
            //{
            //    CVeiculo.Inserir(item);
            //    MessageBox.Show("Dados salvos com sucesso!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
