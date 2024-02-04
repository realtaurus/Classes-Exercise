public class Car
{
    // Properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {

        Car taurusCar = new Car();
        taurusCar.Make = "Jeep";
        taurusCar.Model = "Grand Cherokee";
        taurusCar.Year = 2021;
        Console.WriteLine($"{taurusCar.Make} is my favorite suv.");
        Console.WriteLine($"{taurusCar.Model} is the best version.");
        Console.WriteLine($"{taurusCar.Year} is the last production year");
    }
}

