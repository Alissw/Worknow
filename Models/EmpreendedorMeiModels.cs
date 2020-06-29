using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Repositories;


namespace Models{
    public class EmpreendedorMEIModels{

        [Key]
        public int MeiId{get; set;}
        [Required]
        public string RazaoSocial {get; set; }
        [Required]
        public string NomeFantasia {get; set;}
        [Required]
        public string Cnpj {get; set; }
        [Required]
        public string Cep {get; set; }
        [Required]
        public int NumeroEmpregados {get; set; }
        [Required]
        public string ServiçosPrestados{get; set;}

        public EmpreendedorMEIModels(){

        }
        public EmpreendedorMEIModels(string razaosocial, string nomefantasia, string cnpj, string cep, int numeroempregados, string serviçosprestados){
            RazaoSocial = razaosocial;
            NomeFantasia = nomefantasia;
            Cnpj = cnpj;
            Cep = cep;
            NumeroEmpregados = numeroempregados;
            ServiçosPrestados = serviçosprestados;
        }

        public static List<EmpreendedorMEIModels> GetEMei(){
            var db = new Context();
            return db.Empreendedores.ToList();
        }

        public static EmpreendedorMEIModels GetEMei(int MeiId){
            var db = new Context();
            return(from eMei in db.Empreendedores
                where eMei.MeiId == MeiId
                select eMei).First();
        }
        public static void Atualizar(int MeiId, string razaosocial, string nomefantasia, string cnpj, string cep, int numeroempregados, string serviçosprestados)
        {
            Context db = new Context();
            EmpreendedorMEIModels eMei = GetEMei(MeiId);
            eMei.RazaoSocial = razaosocial;
            eMei.NomeFantasia = nomefantasia;
            eMei.Cnpj = cnpj;
            eMei.Cep = cep;
            eMei.NumeroEmpregados = numeroempregados;
            eMei.ServiçosPrestados = serviçosprestados;
            
            db.SaveChanges();
        }

       public static void Deletar(int id)
        {
            Context db = new Context();
            EmpreendedorMEIModels eMei = db.Empreendedores.First( eMei => eMei.MeiId == id);
            db.Remove(eMei);

            try
            {
                db.SaveChanges();
            }catch{
                Console.WriteLine("Falha ao remover dados!\nTente novamente...");
            }
        } 


        public override string ToString(){
            return $"--------- Dados Do Cliente Autonomo-------"+
                   $"\n ID: {MeiId}"+
                   $"\n Razão Social: {RazaoSocial} "+
                   $"\n CNPJ: {Cnpj}"+
                   $"\n CNPJ: {Cep}"+
                   $"\n Número de Empregados:{NumeroEmpregados}"+
                   $"\n Serviços Prestados: {ServiçosPrestados}";
        }
    }
}