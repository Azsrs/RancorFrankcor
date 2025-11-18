using RancorFrankcor;
using System.IO;
//Använder Typewriter klassen för att skapa dialog

TypeWriter Title = new TypeWriter(); //Intro
Title.Text = "New Super Frank Fighter Turbo Ultra Z EX 64 Shippuden\nPress ENTER to start";
Title.TextSpeed = 40;
Title.Talk();
Console.ReadLine();

TypeWriter Rules = new TypeWriter(); //Regler
Rules.Text = "\nYou will create a powerful fighter and face off against a mighty opponent!\nIf your HP reaches 0 you lose";
Rules.TextSpeed = 40;
Rules.Talk();
Console.ReadLine();

Console.Clear();

TypeWriter Loadq = new TypeWriter(); //Frågar om att ladda save?
Loadq.Text = "Would you like to load a save?\n";
Loadq.TextSpeed = 20;
Loadq.Talk();
string LoadSave = Console.ReadLine().ToLower();

while (LoadSave != "yes" && LoadSave != "no") //Om ej accepterat svar
{

    Console.WriteLine("Load a save? Please answer Yes or No?");
    LoadSave = Console.ReadLine();
}

if (LoadSave == "yes")
{
    if (Directory.Exists(@"Savegames"))
    {
        Console.WriteLine("Please pick save to load");
        foreach (string filename in Directory.GetFiles(@"Savegames"))
        {
            Console.WriteLine(filename);
            Console.ReadLine();
        }

    }
    else
    {
        Console.WriteLine("No save file found, starting game");
        Console.ReadLine();
    }
}











