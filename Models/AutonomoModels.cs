using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Repositories;

namespace Models{
    public class AutonomoModels{

        [Key]
        public int AutonomoId{get; set;}
        [Required]
        public string Nome{get; set;}
        [Required]
        public string CPF{get; set;}
        [Required]
        public string DatadeNascimento{get; set;}
        [Required]
        public string ServicosPrestados{get; set;}
        [Required]
        public string CEP{get; set;}
        [Required]
        public string Email{get; set;}

        public AutonomoModels(){

        }
        public AutonomoModels(string nome, string cpf, string datadenascimento, string servicosprestados, string cep, string email){
            Nome = nome;
            CPF = cpf;
            DatadeNascimento = datadenascimento;
            ServicosPrestados = servicosprestados;
            CEP = cep;
            Email = email;

            var db = new Context();
            db.Autonomos.Add(this);
            db.SaveChanges();
        }

        
        public static List<AutonomoModels> GetAutonomo(){
            var db = new Context();
            return db.Autonomos.ToList();
        }

        public static AutonomoModels GetAutonomo(int autonomoId){
            var db = new Context();
            return(from autonomo in db.Autonomos
                where autonomo.AutonomoId == autonomoId
                select autonomo).First();
        }
        public static void Atualizar(
            int AutonomoId, 
            string nome, 
            string cpf, 
            string datadenascimento, 
            string servicosprestados, 
            string cep, 
            string email
            )
        {
            Context db = new Context();
            try
            {
                AutonomoModels autonomo = db.Autonomos.First(autonomo => autonomo.AutonomoId == AutonomoId);
                autonomo.AutonomoId = AutonomoId;
                autonomo.Nome = nome;
                autonomo.CPF = cpf;
                autonomo.DatadeNascimento = datadenascimento;
                autonomo.ServicosPrestados = servicosprestados;
                autonomo.CEP = cep;
                autonomo.Email = email;
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
            AutonomoModels autonomo = db.Autonomos.First(Autonomo => Autonomo.AutonomoId == id);
            db.Remove(autonomo);
            
            try
            {
                db.SaveChanges();
            }
            catch
            {
                Console.WriteLine("Falha au remover dados!\nTente novamente...");
            }
        }        


        public override string ToString(){
            return $"--------- Dados Do Cliente Autonomo-------"+
                   $"\n ID: {AutonomoId}"+
                   $"\n Nome: {Nome} "+
                   $"\n CPF: {CPF}"+
                   $"\n Data de Nascimento:{DatadeNascimento}"+
                   $"\n Serviços Prestados: {ServicosPrestados}"+
                   $"\n Cep: {CEP}"+
                   $"\n Email: {Email}";
        }
    }
}