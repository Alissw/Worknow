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
        public string Senha {get; set; }
        [Required]
        public string ConfirmarSenha{get; set;}

        public EmpreendedorMEIModels(){

        }
        public EmpreendedorMEIModels(string razaosocial, string nomefantasia, string cnpj, string cep, string senha, string confirmarSenha){
            RazaoSocial = razaosocial;
            NomeFantasia = nomefantasia;
            Cnpj = cnpj;
            Cep = cep;
            Senha = senha;
            ConfirmarSenha = confirmarSenha;

            var db = new Context();
            db.Empreendedores.Add(this);
            db.SaveChanges();
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
        public static void Atualizar(
            int MeiId, 
            string razaosocial, 
            string nomefantasia, 
            string cnpj, 
            string cep, 
            string senha, 
            string confirmarSenha
            )
        {
            Context db = new Context();
            try
            {
                EmpreendedorMEIModels empreendedor = db.Empreendedores.First(empreendedor => empreendedor.MeiId == MeiId);
                empreendedor.RazaoSocial = razaosocial;
                empreendedor.NomeFantasia = nomefantasia;
                empreendedor.Cnpj = cnpj;
                empreendedor.Cep = cep;
                empreendedor.Senha = senha;
                empreendedor.ConfirmarSenha = confirmarSenha;
                db.SaveChanges();
            }
            catch
            {
                throw new ArgumentException();
            }
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
                   $"\n CNPJ: {Cep}";
        }
    }
}