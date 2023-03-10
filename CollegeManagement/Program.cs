using CollegeManagement.Professores;
using CollegeManagement.Turmas;
using System.Security.Cryptography;

List<ProfessoresModelo> _listaDeProfessores = new List<ProfessoresModelo>()
{
    new ProfessoresModelo("Zezo Pinto", "021 21 211", "Geografodase"),
    new ProfessoresModelo("Geremias", "031 31 311", "Matematica"),
    new ProfessoresModelo("Mariana", "041 41 411", "Portugues"),
};
List<Alunos> _listaDeAlunos = new List<Alunos>()
{
    new Alunos("Mario", 15, "12345", "Maria","Jose",62981723123),
    new Alunos("Carlos", 15, "54321", "Clara","Marcos",62981723123),
    new Alunos("Pedro", 15, "22222", "Ana","Jeremias",62981723123),
    new Alunos("Junior", 15, "33333", "Pietra","Algusto",62981723123),
};

#region Menu Principal
void GerenciamentoDeProfessores()
{
    char opcao = '0';

    while (opcao != '4')
    {
        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("===  COLEGIO MODELO 2024  ===");
        Console.WriteLine("=== ÁREA DE GERENCIAMENTO ===");
        Console.WriteLine("=============================");
        Console.WriteLine("\n\n");

        Console.WriteLine("DIGITE A OPÇÃO DESEJADA");
        Console.WriteLine("=== 1 - Cadastrar Professor(a) ===");
        Console.WriteLine("=== 2 - Lista de Professores   ===");
        Console.WriteLine("=== 3 - Remover Professor(a)   ===");
        Console.WriteLine("=== 4 - Localizar Professor(a) ===");
        Console.WriteLine("=== 5 - Menu Principal         ===");

        opcao = Console.ReadLine()[0];

        if (opcao != '6')
        {
            switch (opcao)
            {
                case '1':
                    NovoProfessor();
                    break;
                case '2':
                    ListarProfessores();
                    break;
                case '3':
                    RemoverProfessor();
                    break;
                case '4':
                    LocalizarProfessor();
                    break;
                case '5':
                    MenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção não implementada");
                    break;
            }
        }
    }
    

    
}
void LocalizarProfessor()
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("===   COLEGIO MODELO 2024  ===");
    Console.WriteLine("===   LOCALIZAR PROFESSOR  ===");
    Console.WriteLine("==============================");
    Console.WriteLine("\n\n");

    Console.Write("Digite o CPF do professor: ");
    string cpf = Console.ReadLine();

    if (_listaDeProfessores != null)
    {
        for (int i = 0; i < _listaDeProfessores.Count; i++)
        {
            if (_listaDeProfessores[i].Cpf == cpf)
            {
                Console.WriteLine("Professor Encontrado\n");
                _listaDeProfessores[i].ToString();
            }
            else
            {
                Console.WriteLine("Professor não encontrado");
            }
        }
    }
    Console.ReadKey();
}

void RemoverProfessor()
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("===   COLEGIO MODELO 2024  ===");
    Console.WriteLine("===  REMOVER PROFESSOR(A)  ===");
    Console.WriteLine("==============================");
    Console.WriteLine("\n\n");

    Console.Write("Digite o CPF para ser removido: ");
    string cpf = Console.ReadLine();

    for (int i = 0; i < _listaDeProfessores.Count; i++)
    {
        if (cpf.Equals(_listaDeProfessores[i].Cpf))
        {
            Console.WriteLine($"Removendo o(a) professor(a) {_listaDeProfessores[i].Nome}, de {_listaDeProfessores[i].Materia}");
            _listaDeProfessores.Remove(_listaDeProfessores[i]);
            Console.WriteLine();
            Console.WriteLine("Clique ENTER para retornar ao MENU principal");
            Console.ReadKey();
        }
    }
}

void ListarProfessores()
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("===   COLEGIO MODELO 2024  ===");
    Console.WriteLine("===  LISTA DE PROFESSORES  ===");
    Console.WriteLine("==============================");
    Console.WriteLine("\n\n");

    for (int i = 0; i < _listaDeProfessores.Count; i++)
    {
        _listaDeProfessores[i].ToString();
    }
    Console.ReadKey();
}

void NovoProfessor()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("===  COLEGIO MODELO 2024  ===");
    Console.WriteLine("=== CADASTRO DE NOVO PROF ===");
    Console.WriteLine("=============================");
    Console.WriteLine("\n\n");

    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("CPF: ");
    string cpf = Console.ReadLine();
    Console.Write("Matéria: ");
    string materia = Console.ReadLine();

    var novo = new ProfessoresModelo(nome, cpf, materia);
    _listaDeProfessores.Add(novo);

    Console.WriteLine("\n PROFESSOR CADASTRADO COM SUCESSO");
    Console.ReadKey();
    return;
}
#endregion

void GerenciamentoDeAlunos()
{
    char opcao = '0';

    while (opcao != '4')
    {
        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("===  COLEGIO MODELO 2024  ===");
        Console.WriteLine("===GERENCIAMENTO DE ALUNOS===");
        Console.WriteLine("=============================");
        Console.WriteLine("\n\n");

        Console.WriteLine("DIGITE A OPÇÃO DESEJADA");
        Console.WriteLine("=== 1 - Cadastrar Aluno        ===");
        Console.WriteLine("=== 2 - Lista de Alunos        ===");
        Console.WriteLine("=== 3 - Remover Aluno          ===");
        Console.WriteLine("=== 4 - Localizar Aluno        ===");
        Console.WriteLine("=== 5 - Menu Principal         ===");

        opcao = Console.ReadLine()[0];

        if (opcao != '6')
        {
            switch (opcao)
            {
                case '1':
                    NovoAluno();
                    break;
                case '2':
                    ListarDeAlunos();
                    break;
                case '3':
                    RemoverAluno();
                    break;
                case '4':
                    LocalizarAluno();
                    GerenciamentoDeAlunos();
                    break;
                case '5':
                    MenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção não implementada");
                    break;
            }
        }
    }
}
void LocalizarAluno()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("===  COLEGIO MODELO 2024  ===");
    Console.WriteLine("===     BUSCAR  ALUNO     ===");
    Console.WriteLine("=============================");
    Console.WriteLine("\n\n");

    Console.Write("\nDigite o CPF do aluno para busca: ");
    string cpf = Console.ReadLine();

    if (_listaDeAlunos != null)
    {
        
        foreach(var item in _listaDeAlunos)
        {
            if (item.CpfAluno.Equals(cpf))
            {
                Console.WriteLine("===== DADOS DE ALUNO ENCONTRADOS =====\n");
                item.ToString();
            }
        }
    }
    else
    {
        Console.WriteLine("--- Lista de alunos vazia ---");
    }
    Console.ReadKey();
}
void RemoverAluno()
{
    Alunos aluno = null;

    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("===  COLEGIO MODELO 2024  ===");
    Console.WriteLine("===     REMOVER  ALUNO    ===");
    Console.WriteLine("=============================");
    Console.WriteLine("\n\n");

    Console.Write("Digite o CPF do aluno para remoção: ");
    string cpf = Console.ReadLine();
    Console.WriteLine();

    foreach (var item in _listaDeAlunos)
    {
        if (item.CpfAluno.Equals(cpf))
        {
            aluno = item;
        }
    }
    if (aluno != null)
    {
        _listaDeAlunos.Remove(aluno);
        Console.WriteLine("--- Aluno Removido ---");
    }
    else
    {
        Console.WriteLine("--- Aluno não encontrado ---");
    }
    Console.ReadKey();
}
void ListarDeAlunos()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("===  COLEGIO MODELO 2024  ===");
    Console.WriteLine("===    LISTA DE ALUNOS    ===");
    Console.WriteLine("=============================");
    Console.WriteLine("\n\n");

    if (_listaDeAlunos.Count != 0)
    {
        foreach (var aluno in _listaDeAlunos)
        {
            aluno.ToString();
        }
    }
    else
    {
        Console.WriteLine("...A Lista não retornou nenhum dado...");
    }
    
    Console.ReadKey();
}
void NovoAluno()
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("===  COLEGIO MODELO 2024  ===");
    Console.WriteLine("=== CADASTRO DE NOVO ALUNO===");
    Console.WriteLine("=============================");
    Console.WriteLine("\n\n");

    Console.Write("Nome do Aluno: ");
    string nome = Console.ReadLine();

    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());
    
    Console.Write("CPF: ");
    string cpf = Console.ReadLine();

    Console.Write("Nome da mãe: ");
    string nomeMae = Console.ReadLine();

    Console.Write("Nome do pai: ");
    string nomePai = Console.ReadLine();

    Console.Write("Contato: ");
    long contato = long.Parse(Console.ReadLine());

    var alunoNovo = new Alunos(nome, idade, cpf, nomeMae, nomePai, contato);
    
    _listaDeAlunos.Add(alunoNovo);

    Console.WriteLine("--- Aluno Cadastrado com sucesso ---");
    Console.WriteLine();
    
    //foreach (var item in _listaDeAlunos)
    //{
    //    item.ToString();
    //}
    Console.ReadKey();
}

//GerenciamentoDeAlunos();

void MenuPrincipal()
{
    Console.Clear();
    char opcao;
    Console.WriteLine("===============================================");
    Console.WriteLine("==========      MENU  PRINCIPAL      ==========");
    Console.WriteLine("==========    COLÉGIO MODELO 2024    ==========");
    Console.WriteLine("===============================================");
    Console.WriteLine("");
    Console.WriteLine("===============================================");
    Console.WriteLine("==========  O QUE VOCÊ QUER GERENCIAR? ========");
    Console.WriteLine("==========                             ========");
    Console.WriteLine("==========  1- PROFESSORES             ========");
    Console.WriteLine("==========  2- ALUNOS                  ========");
    Console.WriteLine("==========  3- Fechar Aplicação        ========");
    Console.WriteLine("==========                             ========");
    Console.WriteLine("===============================================\n\n");

    Console.Write("Digita a opção: ");
    opcao = Console.ReadLine()[0];
    while (opcao != '4')
    {
        switch (opcao)
        {
            case '1':
                GerenciamentoDeProfessores();
                break;
            case '2':
                GerenciamentoDeAlunos();
                break;
            case '3':
                break;
            default:
                Console.WriteLine("Opção não implementada");
                break;
        };
    }
};

MenuPrincipal();
