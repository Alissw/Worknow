using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


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
        public string ServiçosPrestados{get; set;}
        [Required]
        public string CEP{get; set;}
        [Required]
        public string Email{get; set;}

        public AutonomoModels(){

        }
        public AutonomoModels(string nome, string cpf, string datadenascimento, string serviçosprestados, string cep, string email){
            Nome = nome;
            CPF = cpf;
            DatadeNascimento = datadenascimento;
            ServiçosPrestados = serviçosprestados;
            CEP = cep;
            Email = email;
        }


        public override string ToString(){
            return $"--------- Dados Do Cliente Autonomo-------"+
                   $"\n ID: {AutonomoId}"+
                   $"\n Nome: {Nome} "+
                   $"\n CPF: {CPF}"+
                   $"\n Data de Nascimento:{DatadeNascimento}"+
                   $"\n Serviços Prestados: {ServiçosPrestados}"+
                   $"\n Cep: {CEP}"+
                   $"\n Email: {Email}";
        }
    }
}