using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a Celsuis temperature");
    double celsuis = Convert.ToDouble(Console.ReadLine());
    double Farenhiet = (celsuis * 9/5) + 32;
    Console.WriteLine("The Equivalent in Farenhiet is " + Farenhiet);
    if (Farenhiet > 212)
    {
      Console.WriteLine("This temperature is above boiling point of 212 degrees Farenhiet");
    }
    else if (Farenhiet < 32)
    {
      Console.WriteLine("This temperature is below the freezing point of 32 degrees Farenhiet");
    }
    else
    {

    }


  }
}