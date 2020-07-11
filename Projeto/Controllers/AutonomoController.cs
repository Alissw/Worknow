using System;
using System.Collections.Generic;
using Models;

namespace Controller
{
    public class AutonomoController
    {
        public static void InserirAutonomo(string nome, string cpf, string datadenascimento, string servicosprestados, string cep, string email)
        {
            DateTime dtnacscimento;
            try
            {
                dtnacscimento = Convert.ToDateTime(datadenascimento);
            }
            catch
            {
                Console.WriteLine("Formato inválido, será utilizado a data atual para terminar o cadastro!");
                dtnacscimento = DateTime.Now;
            }
            new AutonomoModels(nome, cpf, datadenascimento, servicosprestados, cep, email);
        }

        public static void Atualizar(int AutonomoId, string nome, string cpf, string datadenascimento, string servicosprestados, string cep, string email){
            AutonomoModels.Atualizar(AutonomoId, nome, cpf, datadenascimento, servicosprestados, cep, email);
        }
       public static void Deletar(int id)
        {
            AutonomoModels.Deletar(id);
        }        
        
        public static AutonomoModels GetAutonomo(int autonomoId){
            return AutonomoModels.GetAutonomo(autonomoId);
        }

        public static List<AutonomoModels> GetAutonomo(){
            return AutonomoModels.GetAutonomo();
        }
        public static bool CamposPreenchidosCadastroAutonomo(
            string nome,
            string cpf,
            string datadenascimento,
            string servicosprestados,
            string cep,
            string email)
        {
            if ((nome == string.Empty)
                || (cpf == string.Empty)
                || (datadenascimento == string.Empty)
                || (servicosprestados == string.Empty)
                || (cep == string.Empty)
                || (email == string.Empty))
            {
                return false;
            }
            return true;
        }

    }
}