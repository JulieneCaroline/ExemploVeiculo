using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CPessoa
    {
        public static List<MPessoa> Pesquisar(MPessoa item)
        {
            List<MPessoa> retorno = null;

            //if(item != null && item.Nome != null && item.Nome.Length <= 200)
            //{
            //    string cpf = item.CPF.Replace(".", "");
            //    cpf = cpf.Replace("-", "");
            //    cpf = cpf.Trim();

            //    if(cpf == "")
            //    {
            //        item.CPF = "";
            //    }

            //    retorno = DPessoa.Pesquisar(item);
            //}
            retorno = DPessoa.Pesquisar(item);

            return retorno;
        }

        public static MPessoa Obter(MPessoa item)
        {
            MPessoa retorno = null;

            if (item != null)
            {
                string cpf = item.CPF.Replace(".", "");
                cpf = cpf.Replace("-", "");
                cpf = cpf.Trim();

                if (cpf == "")
                {
                    item.CPF = "";
                }

                retorno = DPessoa.Obter(item);
            }

            return retorno;
        }

        public static void Atualizar(MPessoa item)
        {
            if (item == null)
            {
                throw new Exception("Objeto PESSOA inválido");
            }

            if (item.Nome.Trim() == "" || item.Nome.Length > 200)
            {
                throw new Exception("Objeto PESSOA nome inválido");
            }

            try
            {
                DPessoa.Atualizar(item);
            }
            catch
            {
                throw;
            }
        }

        public static void Inserir(MPessoa item)
        {
            if(item == null)
            {
                throw new Exception("Objeto PESSOA inválido");
            }

            if(item.Nome.Trim() == "" || item.Nome.Length > 200)
            {
                throw new Exception("Objeto PESSOA nome inválido");
            }

            //todo CPF
            //todo DataNascimento

            try
            {
                DPessoa.Inserir(item);
            }
            catch
            {
                throw;
            }
        }

        public static void Excluir(MPessoa item)
        {
            if (item.CPF.Trim() == "")
                throw new Exception("CPF inválido");

            try
            {
                DPessoa.Excluir(item);
            }
            catch
            {
                throw;
            }
        }
    }
}
