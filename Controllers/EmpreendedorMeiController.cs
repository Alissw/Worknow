using System;
using System.Collections.Generic;
using Models;

namespace Controller
{
    public class EmpreendedorMeiController
    {
        public static void InserirEmpreendedor(string razaosocial, string nomefantasia, string cnpj, string cep, int numeroempregados, string serviçosprestados)
        {
            new EmpreendedorMEIModels(razaosocial, nomefantasia, cnpj, cep, numeroempregados, serviçosprestados);
        }

        public static void Atualizar(int MeiId, string razaosocial, string nomefantasia, string cnpj, string cep, int numeroempregados, string serviçosprestados){
            EmpreendedorMEIModels.Atualizar(MeiId, razaosocial, nomefantasia, cnpj, cep, numeroempregados, serviçosprestados);
        }
       public static void Deletar(int id)
        {
            EmpreendedorMEIModels.Deletar(id);
        }        
        
        public static EmpreendedorMEIModels GetEMei(int autonomoId){
            return EmpreendedorMEIModels.GetEMei(autonomoId);
        }

        public static List<EmpreendedorMEIModels> GetEMei(){
            return EmpreendedorMEIModels.GetEMei();
        }

    }
}