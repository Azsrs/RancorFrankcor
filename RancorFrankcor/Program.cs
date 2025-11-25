using RancorFrankcor;
using System.ComponentModel;
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

// TypeWriter Loadq = new TypeWriter(); //Frågar om att ladda save?
// Loadq.Text = "Would you like to load a save?\n";
// Loadq.TextSpeed = 20;
// Loadq.Talk();
// string LoadSave = Console.ReadLine().ToLower();

// while (LoadSave != "yes" && LoadSave != "no") //Om ej accepterat svar
// {

//     Console.WriteLine("Load a save? Please answer Yes or No?");
//     LoadSave = Console.ReadLine().ToLower();
// }

// if (LoadSave == "yes")
// {
//     if (File.Exists(@"C:\RancorFrankcor\RancorFrankcor\test.txt")) 
//     {
//         Console.WriteLine("ja");
//         Console.ReadLine();
//         redansave = true;
//     }
//     else
//     {
//         Console.WriteLine("No save file found, starting game");
//         Console.ReadLine();
//         redansave = false;
//     }
// }

// if (redansave == true)


TypeWriter NameChoose = new TypeWriter();  //Ask name
NameChoose.Text = "What will you name your fighter?\n";
NameChoose.TextSpeed = 40;
NameChoose.Talk();
string name = Console.ReadLine(); 

while (name == "" || name.Length > 9)  //If name invalid
{
    NameChoose.Text = "Please pick a name between 1 and 9 characters";
    NameChoose.Talk();
    name = Console.ReadLine();
}

Directory.CreateDirectory("savegames");
File.Create($"{name}.txt"); //Create save file, named after player character

Console.Clear();

TypeWriter ClassChoose = new TypeWriter();  //Pick class
ClassChoose.Text = "Please pick a class for your character\n1.Brute: low speed hard hits.\n2.Assassin:Weaker hits, higher speed\n3.Glass Cannon: Massive damage, No health\n";
ClassChoose.TextSpeed = 40;
List<string> classes = ["Brute", "Assassin", "Glass Cannon"];
ClassChoose.Talk();



