using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Views;

namespace Worknow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opc = 0;
            Console.WriteLine("Sistema Worknow");
            do{
                Console.WriteLine("1 - Autonomos");
                Console.WriteLine("2 - Emprendedores");
                Console.WriteLine("0 - Sair");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            
                switch (opc)
                {
                    case 1:
                        int opcAutonomo = 0;

                        do{
                            Console.WriteLine("#####Menu Autônomos#####");
                            Console.WriteLine("1 - Cadastrar");
                            Console.WriteLine("2 - Atualizar dados");
                            Console.WriteLine("3 - Deletar dados");
                            Console.WriteLine("0 - Sair");
                            opcAutonomo = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            
                            switch (opcAutonomo)
                            {
                                case 1:
                                    AutonomoView.CadastrarAutonomo();
                                break;
                                case 2:
                                    AutonomoView.Atualizar();
                                break;
                                case 3:
                                    AutonomoView.Deletar();
                                break;

                            }

                        }while (opcAutonomo != 0 );
                    break;
                    case 2:
                        int opcEmpreendedor = 0;

                        do{
                            Console.WriteLine("#####Menu Empreendedor#####");
                            Console.WriteLine("1 - Cadastrar");
                            Console.WriteLine("2 - Atualizar dados");
                            Console.WriteLine("2 - Deletar dados");
                            Console.WriteLine("0 - Sair");
                            opcEmpreendedor = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            
                            switch (opcEmpreendedor)
                            {
                                case 1:
                                    EmpreendedorMeiView.CadastrarAutonomo();
                                break;

                            }

                        }while (opcEmpreendedor != 0 );
                    break;

                    default:
                        Console.WriteLine("Até mais");
                    break;
                }
            }while(opc != 0 );
            
        }


    }
}
