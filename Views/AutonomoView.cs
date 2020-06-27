using System;
using Controller;

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
    }
} 