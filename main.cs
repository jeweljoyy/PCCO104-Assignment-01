using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the denomination of the Philippine Bank Note:");
    string denominationInput = Console.ReadLine();
    decimal denomination = decimal.Parse(denominationInput);

    string personality = money(denomination);

    if (personality == "")
    {
        Console.WriteLine($"No person is found in PHP {denomination}.");
    }
    else
    {
        Console.WriteLine($"{personality} is found in PHP {denomination}.");
    }
}

static string money(decimal denomination)
{
    switch (denomination)
    {
    case 1:
            return "Jose Rizal";
    case 5:
            return "Emilio Aguinaldo";
    case 10:
            return "Andres Bonifacio, Apolinario Mabini";
    case 20:
            return "Manuel L. Quezon";
    case 50:
            return "Sergio Osmeña";
    case 100:
            return "Manuel Roxas";
    case 200:
            return "Diosdado Macapagal";
    case 500:
            return "Benigno Sr. and Corazon Aquino";
    case 1000:
            return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
        default:
            return "";
    }
  }
}