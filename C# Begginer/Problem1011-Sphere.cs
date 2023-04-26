/* A basic script that calculates the volume of a sphere */

using System; 

class URI {

    static void Main(string[] args) { 
        double R = double.Parse(Console.ReadLine());
        double volume = (4/3.0) * 3.14159 * Math.Pow(R,3);
        
        Console.WriteLine("VOLUME = " + volume.ToString("0.000"));
    }

}