using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is going to straight-up blow your mind with the mad libs broh.
      Author: Bryan Kilgore
      */


      // Program Start:
      Console.WriteLine("Welcome to Mad Libs with Mr. Burrito!\n\nPress Enter to Start.");
      Console.ReadLine();
      Console.WriteLine("\n\n\n\n\n\n\n");

      // Give the Mad Lib a title:
      string title = "Mad Libs with Mr. Burrito, the Human Pizza\n\n\n\n";
      Console.WriteLine(title);

      // Define user input and variables:
      Console.Write("Who is the star of our story? \n");
      string protagonist = Console.ReadLine();

      Console.Write("\nIn terms of color, how you feelin', boo? \n");
      string adj1 = Console.ReadLine();
      
      Console.Write("\nHow would you describe the weather today? \n");
      string adj2 = Console.ReadLine();
      
      Console.Write("\nHow would you describe a vegan pizza? \n");
      string adj3 = Console.ReadLine();

      Console.Write("\nHow about a hypothetical? Say a group of robot pizzas ambush you with Mormon literature. What do you do? \n");
      string verb = Console.ReadLine();
      
      Console.Write("\nOK, so howabout a personal question. What is your favorite bodily noise? \n");
      string noun1 = Console.ReadLine();
      
      Console.Write("\nWhat person (fictional or not), or what item, would you take with you on an interdimensional adventure? \n");
      string noun2 = Console.ReadLine();

      Console.Write("\nWhat vegetable would you want to punch in the face if it were a person? \n");
      string veg = Console.ReadLine();

      Console.Write("\nWhat you feelin' for dinner tonight? Perhaps a pizza? Don't forget to practice pizza safety. \n");
      string food = Console.ReadLine();

      Console.Write("\nWhat fruit speaks to your more unrefined sensibilities? \n");
      string fruit = Console.ReadLine();

      Console.Write("\nScenario time! Again. So a terrifying race of pizza-hating insectoid aliens has descended upon the Earth, bent on the complete annihilation of all life, including humans and human pizzas. You got to take these fucks to school, but you're going to need backup. What superhero are you calling in? \n");
      string superhero = Console.ReadLine();

      Console.Write("\nIf you had to, which country would you fake your own death and disappear to? \n");
      string country = Console.ReadLine();

      Console.Write("\nSo there's this game show called \"How Did I Get HERE?!\" - long story. Anyway, Gordon Ramsay was on that show and he suddenly materializes directly in front of you. Butt nekkid. He offers to make you whatever dessert you want if you just forget about all this and get him back home. What dessert you asking for? \n" );
      string dessert = Console.ReadLine();

      Console.Write("\nFinal Question. So 2020 is among the shittiest years of all time. What year would you like to phase into so we can just see how this all shakes out? \n");
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"\n\n\nThis morning {protagonist} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of fucking {veg}s were protesting to keep {food}s out of stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {protagonist} texted {superhero}, who flew {protagonist} to {country} and dropped {protagonist} in a puddle of frozen {dessert}. {protagonist} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
