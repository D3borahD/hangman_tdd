using hangman;

string unknowWord = "hello";


// Prompt
Console.WriteLine("Trouve le mot : {0}", HandgameView.viewWord(unknowWord));

Console.Write("Saisie une lettre :");
string letter = Console.ReadLine();

Console.WriteLine("Tu as saisie la lettre : {0}", letter);

