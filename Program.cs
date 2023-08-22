﻿// Screen Sound
// List<string> registeredBands = new List<string> { "The Beatles", "U2", "ACDC" };

Dictionary<string, List<int>> dictionaryBands = new Dictionary<string, List<int>>();
dictionaryBands.Add("Link Park", new List<int>{10, 8, 6});
dictionaryBands.Add("The Beatles", new List<int>());


void WelcomeMessage()
{
  Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
  ");
  Console.WriteLine("Boas vindas!!");
}

void OptionsMenu()
{
  WelcomeMessage();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite 0 para sair\n");
  Console.Write("Digite sua opção: ");

  string chosenOption = Console.ReadLine();
  int chosenOptionNumeric = int.Parse(chosenOption);

  switch (chosenOptionNumeric)
  {
    case 1:
      RegisterBands();
      break;
    case 2:
      ShowBands();
      break;
    case 3: 
      BandNotes();
      break;
  }
}

void RegisterBands()
{
  DisplayTitle("Digite o nome da banda para registrar: ");
  string bands = Console.ReadLine()!;
  dictionaryBands.Add(bands, new List<int>());
  Console.WriteLine($"Banda {bands} registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  OptionsMenu();
}

void ShowBands()
{
  Console.Clear();
  DisplayTitle("Lista das bandas registradas!\n");

  foreach (string band in dictionaryBands.Keys)
  {
    Console.WriteLine("Banda: " + band);
  }
  Console.WriteLine("Digite qualquer tecla voltar ao menu principal.\n");
  Console.ReadKey();
  OptionsMenu();
}

void DisplayTitle(string title)
{
  int quantityLetters = title.Length;
  string asterisk = string.Empty.PadLeft(quantityLetters, '*');
  Console.WriteLine(asterisk);
  Console.WriteLine(title);
  Console.WriteLine(asterisk + "\n");

}

void BandNotes()
{
  Console.Clear();
  DisplayTitle("Avaliação das bandas!");
  Console.Write("Digite o nome da banda que deseja avaliar: \n");
  string ratedBand = Console.ReadLine()!;

  if (dictionaryBands.ContainsKey(ratedBand))
  {

  } else
  {
    Console.WriteLine($"A banda {ratedBand} não encontrada!");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    OptionsMenu();
  }
}
OptionsMenu();