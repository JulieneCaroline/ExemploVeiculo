using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CVeiculo
    {
        public static List<MVeiculo> Pesquisar(MVeiculo item)
        {
            List<MVeiculo> retorno = null;

            if (item != null && item.RENAVAM != null)
            {
                //string cpf = item.CPF.Replace(".", "");
                //cpf = cpf.Replace("-", "");
                //cpf = cpf.Trim();

                //if (item.Placa == "")
                //{
                //    item.Placa = "";
                //}

                //if (item.Modelo == "")
                //{
                //    item.Modelo = "";
                //}

                //if (item.AnoModelo == 0)
                //{
                //    item.AnoModelo = 0;
                //}

                //if (item.AnoFabricacao == 0)
                //{
                //    item.AnoFabricacao = 0;
                //}

            }
            retorno = DVeiculo.Pesquisar(item);

            return retorno;
        }

        public static MVeiculo Obter(MVeiculo item)
        {
            MVeiculo retorno = null;

            if (item != null)
            {

            
                retorno = DVeiculo.Obter(item);
            }

            return retorno;
        }

        public static void Atualizar(MVeiculo item)
        {
            if (item == null)
            {
                throw new Exception("Objeto Veiculo inválido");
            }

            if (item.RENAVAM.Trim() == "" || item.RENAVAM.Length > 11)
            {
                throw new Exception("Objeto VEICULO nome inválido");
            }

            try
            {
                DVeiculo.Atualizar(item);
            }
            catch
            {
                throw;
            }
        }

        public static void Inserir(MVeiculo item)
        {
            if (item == null)
            {
                throw new Exception("Objeto VEICULO inválido");
            }

            if (item.RENAVAM.Trim() == "" || item.RENAVAM.Length > 11)
            {
                throw new Exception("Objeto VEICULO RENAVAM inválido");
            }

            if (item.Placa.Trim() == "" || item.Placa.Length != 8)
            {
                throw new Exception("Objeto VEICULO Placa inválido");
            }

            if (item.Modelo.Trim() == "" || item.Modelo.Length > 100)
            {
                throw new Exception("Objeto VEICULO Modelo inválido");
            }

            string AuxAnoModelo = item.AnoModelo.ToString();

            if (AuxAnoModelo.Trim() == "" || AuxAnoModelo.Length != 4 )
            {
                throw new Exception("Objeto VEICULO AnoModelo inválido");
            }

            string AuxAnoFabricacao = item.AnoFabricacao.ToString();

            if (AuxAnoFabricacao.Trim() == "" || AuxAnoFabricacao.Length != 4)
            {
                throw new Exception("Objeto VEICULO AnoFabricacao inválido");
            }

            try
            {
                DVeiculo.Inserir(item);
            }
            catch
            {
                throw;
            }
        }
        public static void Excluir(MVeiculo item)
        {
            if (item.RENAVAM.Trim() == "")
                throw new Exception("RENAVAM inválido");

            try
            {
                DVeiculo.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }

}
