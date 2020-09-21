using System;
using System.IO;

namespace ASOIAF_Quiz_True_or_False
{
  public class Tools
  {
    public static void SetUpInputStream(string sample)
    {
                        if (sample == null)
                        {
                                Console.SetIn(new StreamReader("true.txt"));
                        }      
    }
  }
}