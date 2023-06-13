using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
       // Let the user know that the program is starting:
      Console.WriteLine("Madlibs in #C");


      // Give the Mad Lib a title:
      string title = "Once upon a time...";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("Gimme an adjective (i.e a colour, a feeling, a texture): ");
      string adj1 = Console.ReadLine();

      Console.Write("And another: ");
      string adj2 = Console.ReadLine();

      Console.Write("Aaand just one more: ");
      string adj3 = Console.ReadLine();

      Console.Write("Give me a verb: (i.e an action) ");
      string verb = Console.ReadLine();

      Console.Write("Gimme a noun (i.e a place, person, object): ");
      string noun1 = Console.ReadLine();

      Console.Write("And one more noun: ");
      string noun2 = Console.ReadLine();

      Console.Write("Gimme an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Gimme a food: ");
      string food = Console.ReadLine();

      Console.Write("Gimme a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Gimme a superhero: ");
      string superhero = Console.ReadLine();

      Console.Write("Gimme a country: ");
      string country = Console.ReadLine();

      Console.Write("Gimme a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Gimme a year: ");
      string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}