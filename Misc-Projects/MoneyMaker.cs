using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      int schmeckleValue = 10;
      int brappleValue = 5;
      
      Console.WriteLine("\n\n\n\n\n\nWelcome to Blips and Chitz Coin Counter!\n\n\n");
      Console.WriteLine("Press the enter key to begin.\n");
      Console.ReadLine();
      
      Console.WriteLine("Please enter a coin amount you'd like to convert: \n");
      string amt = Console.ReadLine();
      double amtDbl = Convert.ToDouble(amt);

      Console.WriteLine($"Let's see, {amtDbl} cents is equal to...");

      double goldCoins = Math.Floor(amtDbl / goldValue);
      double leftOver = amtDbl % goldValue;
      double silverCoins = Math.Floor(leftOver / silverValue);
      leftOver = leftOver % silverValue;

      Console.WriteLine($"Schmeckles: {goldCoins}\nBrapples: {silverCoins}\nBlemflarks: {leftOver}\n\nRemember to always practice pizza safety!"); 
    }
  }
}
