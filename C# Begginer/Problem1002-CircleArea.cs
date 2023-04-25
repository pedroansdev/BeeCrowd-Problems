/* A basic script that calculates the area of a circle with 4 places after decimal point */

using System; 

class URI {

    static void Main(string[] args) { 

        double pi = 3.14159;
        
        double R = double.Parse(Console.ReadLine());
        
        double A = pi * (R * R);
        
        Console.WriteLine("A=" + A.ToString("0.0000"));

    }

}