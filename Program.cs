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
                Console.WriteLine("1 - Cadastrar autônomo");
                Console.WriteLine("0 - Sair");
                opc = Convert.ToInt32(Console.ReadLine());
            
                switch (opc)
                {
                    case 1:
                        AutonomoView.CadastrarAutonomo();
                    break;

                    default:
                        Console.WriteLine("Até mais");
                    break;
                }
            }while(opc != 0 );
            
        }


    }
}
