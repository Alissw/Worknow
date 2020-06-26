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
        /*
        public static AutonomoModels GetAutonomo(int autonomoId){
            return AutonomoModels.GetAutonomo(autonomoId);
        }

        public static List<AutonomoModels> GetAutonomo(){
            return AutonomoModels.GetAutonomo();
        }
        */
    }
}