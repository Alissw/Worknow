using System;
using Controller;
using Models;

namespace Views{

    public class AutonomoView{
        public static void CadastrarAutonomo(){
            Console.WriteLine("Cadastrando Autonomo: ");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: ");
            string datadenascimento = Console.ReadLine();
            Console.WriteLine("Serviços Prestados: ");
            string servicosprestados = Console.ReadLine();
            Console.WriteLine("CEP: ");
            string cep = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            AutonomoController.InserirAutonomo(nome,cpf,datadenascimento,servicosprestados,cep,email);
        }
        public static void Deletar(){
            Console.WriteLine("Deletar autonomo\n");

            AutonomoController.GetAutonomo().ForEach(autonomo => Console.WriteLine(autonomo));

            try
            {
                Console.WriteLine("Qual autônomo você deseja deletar?");
                int idAutonomo = 0;
                idAutonomo = Convert.ToInt32(Console.ReadLine());
                AutonomoModels.Deletar(idAutonomo);
                
            }
            catch
            {
                Console.WriteLine("Não existe!");
            }    

        }

        public static void Atualizar(){
            Console.WriteLine("Atualizar autônomo");
            AutonomoController.GetAutonomo().ForEach(autonomo => Console.WriteLine($"{autonomo.AutonomoId} - {autonomo.Nome}"));

            Console.Write("Qual autônomo você deseja deletar?");
            int AutonomoId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Comece a alterar:\n");

            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("CPF:");
            string cpf = Console.ReadLine();
            Console.Write("Data de nascimento:");
            string datadenascimento = Console.ReadLine();
            Console.Write("Serviços prestados:");
            string servicosprestados = Console.ReadLine();
            Console.Write("CEP:");
            string cep = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();

            AutonomoController.Atualizar(AutonomoId, nome, cpf, datadenascimento, servicosprestados, cep, email);
        }
    }

}