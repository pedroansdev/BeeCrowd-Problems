/* A basic script that calculates the consumption average of a car */

using System; 

class URI {

    static void Main(string[] args) { 
        int km = int.Parse(Console.ReadLine());
        float fuel = float.Parse(Console.ReadLine());
        
        float consumption = km/fuel;
        
        Console.WriteLine(consumption.ToString("0.000") + " km/l");
    }

}