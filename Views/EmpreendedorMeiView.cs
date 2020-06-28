using System;
using Controller;

namespace Views{

    public class EmpreendedorMeiView{
        public static void CadastrarAutonomo(){
            Console.WriteLine("Cadastrando Empreendedor: ");

            Console.WriteLine("Razão social: ");
            string razaosocial = Console.ReadLine();
            Console.WriteLine("Nome fantasia: ");
            string nomefantasia = Console.ReadLine();
            Console.WriteLine("CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.WriteLine("CEP: ");
            string servicosprestados = Console.ReadLine();
            Console.WriteLine("Número de Empregados: ");
            int numeroempregados = Console.Read();
            Console.WriteLine("Serviços prestados: ");
            string serviçosprestados = Console.ReadLine();
            EmpreendedorMeiController.InserirEmpreendedor(razaosocial,nomefantasia,cnpj,servicosprestados,numeroempregados,servicosprestados);
        }
    }
} 