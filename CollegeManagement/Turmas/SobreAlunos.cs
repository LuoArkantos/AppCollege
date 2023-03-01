using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Turmas
{
    public class SobreAlunos
    {
        string NomeAluno { get; set; }
        string NomePai { get; set; }
        string NomeMae { get; set; }
        int IdadeAluno { set; get; }
        long Contato1 { set; get; }
        long Contato2 { set; get;}

        public List<SobreAlunos> _listaDeAlunos = new List<SobreAlunos>();

        public SobreAlunos(string nome, int idade, string? nomeMae, string? nomePai, long contato)
        {
            NomeAluno = nome;
            IdadeAluno = idade;
            NomeMae = nomeMae;
            NomePai = nomePai;
            Contato1 = contato;
        }

        
        public void ToString()
        {
            Console.WriteLine($"Nome: {this.NomeAluno}\n" +
                              $"Nome da mãe: {this.NomeMae}\n" +
                              $"Nome da pai: {this.NomePai}\n" +
                              $"Idade: {this.IdadeAluno} \n\n" +
                              $"Contato 1: {this.Contato1} \n\n" +
                              $"Contato 2: {this.Contato2} \n\n" +
                              $">>>>>>>>>>>>>>>>>>>>>>>>>\n");
        }



    }
}
