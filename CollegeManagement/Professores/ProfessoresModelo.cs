using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Professores
{
    public class ProfessoresModelo
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Materia { get; private set; }
        public ProfessoresModelo(string nome, string cpf, string materia)
        {
            Nome = nome;
            Cpf = cpf;
            Materia = materia;
        }
        public void ToString()
        {
            Console.WriteLine($"Nome: {this.Nome}\n" +
                              $"CPF: {this.Cpf}\n" +
                              $"Matéria: {this.Materia} \n\n" +
                              $">>>>>>>>>>>>>>>>>>>>>>>>>\n");
        }
    }
}
