// See https://aka.ms/new-console-template for more information
string mensagemDeBoasVindas = "Boas vindas ao Screen Soud";


List<string> ListaBandas = new List<string>() {"Matue", "Orochi", "Poze"};
void ExibirMensagemBoasVindas()
{
    Console.WriteLine(@"

        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═════╝░");
    Console.WriteLine("");
    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirOpcoesDoMenu()
{
    ExibirMensagemBoasVindas();
    Console.WriteLine("");
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digete 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica =  int.Parse(opcaoEscolhida); 
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção 3");
            break;
        case 4: Console.WriteLine("Você escolheu a opção 4");
            break;
        case -1: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarBanda()
{
    ExibirTituloDaOpcao("Registrar Bandas");
    Console.Write("Digite o nome da banda: ");
    string NewBanda = Console.ReadLine()!;
    ListaBandas.Add(NewBanda);
    Console.WriteLine($"Banda {NewBanda} adicionada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    //for (int i = 0; i < ListaBandas.Count; i++)
    //{
    //   Console.WriteLine($"Banda: {ListaBandas[i]}");
    //}
    foreach (string banda in ListaBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
} 

void ExibirTituloDaOpcao(string titulo)
{
    int NumeroDeletras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(NumeroDeletras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
};

ExibirOpcoesDoMenu();

