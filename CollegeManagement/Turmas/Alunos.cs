using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Turmas
{
    public class Alunos
    {
        public string NomeAluno { get; private set; }
        public string CpfAluno { get; private set; }
        public string NomePai { get; private set; }
        public string NomeMae { get; private set; }
        public int IdadeAluno { private set; get; }
        public long Contato1 { private set; get; }
        public long Contato2 { private set; get;}

        public List<Alunos> _listaDeAlunos = new List<Alunos>();

        public Alunos(string nome, int idade, string cpf, string? nomeMae, string? nomePai, long contato)
        {
            NomeAluno = nome;
            IdadeAluno = idade;
            CpfAluno = cpf;
            NomeMae = nomeMae;
            NomePai = nomePai;
            Contato1 = contato;
        }

        
        public void ToString()
        {
            Console.WriteLine($"Nome: {this.NomeAluno}\n" +
                              $"Idade: {this.IdadeAluno}\n" +
                              $"CPF: {this.CpfAluno}\n"+
                              $"Nome da mãe: {this.NomeMae}\n" +
                              $"Nome da pai: {this.NomePai}\n" +
                              $"Contato 1: {this.Contato1} \n" +
                              $"Contato 2: {this.Contato2} \n" +
                              $">>>>>>>>>>>>>>>>>>>>>>>>>\n");
        }



    }
}
