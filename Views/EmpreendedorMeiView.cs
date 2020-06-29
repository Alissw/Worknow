using System;
using Controller;
using Models;

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
        public static void Deletar(){
            Console.WriteLine("Deletar autonomo\n");

            EmpreendedorMeiController.GetEMei().ForEach(eMei => Console.WriteLine(eMei));

            try
            {
                Console.WriteLine("Qual empreendedor você deseja deletar?");
                int idEmpreendedor = 0;
                idEmpreendedor = Convert.ToInt32(Console.ReadLine());
                EmpreendedorMEIModels.Deletar(idEmpreendedor);
                
            }
            catch
            {
                Console.WriteLine("Não existe!");
            }    

        }  
        public static void Atualizar(){
            Console.WriteLine("Atualizar autônomo");
            EmpreendedorMeiController.GetEMei().ForEach(eMei => Console.WriteLine($"{eMei.MeiId} - {eMei.NomeFantasia}"));

            Console.Write("Qual empreendedor você deseja deletar?");
            int MeiId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Comece a alterar:\n");

            Console.Write("Razão Social:");
            string razaosocial = Console.ReadLine();
            Console.Write("Nome Fantasia:");
            string nomefantasia = Console.ReadLine();
            Console.Write("CNPJ:");
            string cnpj = Console.ReadLine();
            Console.Write("CEP:");
            string cep = Console.ReadLine();
            Console.Write("Número de empregados:");
            int numeroempregados = Console.Read();
            Console.Write("Serviços prestados:");
            string servicosprestados = Console.ReadLine();

            EmpreendedorMeiController.Atualizar(MeiId, razaosocial, nomefantasia, cnpj, cep, numeroempregados, servicosprestados);
        }              
    }
} 