using CollegeManagement.Professores;

List<ProfessoresModelo> _listaDeProfessores = new List<ProfessoresModelo>()
{
    new ProfessoresModelo("Zezo Pinto", "021 21 211", "Geografodase"),
    new ProfessoresModelo("Geremias", "031 31 311", "Matematica"),
    new ProfessoresModelo("Mariana", "041 41 411", "Portugues"),
};
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
        Console.WriteLine("=== 5 - Fechar Aplicação       ===");

        opcao = Console.ReadLine()[0];

        if (opcao != '5')
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
    
    //return _listaDeProfessores.Where(_listaDeProfessores => _listaDeProfessores.Cpf == cpf).FirstOrDefault();

    //Console.WriteLine("Encontrado");

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



GerenciamentoDeProfessores();