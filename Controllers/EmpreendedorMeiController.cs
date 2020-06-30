using System;
using System.Collections.Generic;
using Models;

namespace Controller
{
    public class EmpreendedorMeiController
    {
        public static void InserirEmpreendedor(string razaosocial, string nomefantasia, string cnpj, string cep, string senha, string confirmarSenha)
        {
            new EmpreendedorMEIModels(razaosocial, nomefantasia, cnpj, cep, senha, confirmarSenha);
        }

        public static void Atualizar(int MeiId, string razaosocial, string nomefantasia, string cnpj, string cep, string senha, string confirmarSenha){
            EmpreendedorMEIModels.Atualizar(MeiId, razaosocial, nomefantasia, cnpj, cep, senha, confirmarSenha);
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