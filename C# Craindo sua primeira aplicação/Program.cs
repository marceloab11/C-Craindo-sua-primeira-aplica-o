﻿// See https://aka.ms/new-console-template for more information
string mensagemDeBoasVindas = "Boas vindas ao Screen Soud";
// List<string> ListaBandas = new List<string>() { "Matue", "Orochi", "Poze" };
Dictionary<string, List<int>> BandasRegistradas  = new Dictionary<string, List<int>>();
BandasRegistradas.Add("Matue", new List<int>() {10, 8, 6});
BandasRegistradas.Add("Orochi", new List<int>());
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
        case 3: AvaliarUmaBanda();
            break;
        case 4: MostrarMediaDaBanda();
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
    BandasRegistradas.Add(NewBanda, new List<int>());
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
    foreach (string banda in BandasRegistradas.Keys)
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

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda cadastrada");
    Console.Write("Digite a banda que deseja avaliar:");
    string bandaAvaliada = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(bandaAvaliada))
    {
        Console.Write($"\nQual nota a banda {bandaAvaliada} merece?");
        string nota = Console.ReadLine()!;
        int notaBanda = int.Parse(nota);
        BandasRegistradas[bandaAvaliada].Add(notaBanda);
        Console.WriteLine($"\nBanda {bandaAvaliada} avaliada com a nota {notaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Banda não encontrada!!!");
        Console.WriteLine("Digite uma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MostrarMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média das bandas");
    Console.Write("Qual banda deseja saber a média?");
    string banda = Console.ReadLine();
    if (BandasRegistradas.ContainsKey(banda))
    {
        List<int> NotasBandas = BandasRegistradas[banda];
        Console.WriteLine($"\nA média da banda {banda} é de {NotasBandas.Average()}\n");
        Console.WriteLine("Digite uma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Banda não encontrada!!!");
        Console.WriteLine("Digite uma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


ExibirOpcoesDoMenu();

