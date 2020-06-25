using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


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