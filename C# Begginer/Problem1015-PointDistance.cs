/* A basic script that calculates the distance between two points of a cartesian plane */

using System; 

class URI {

    static void Main(string[] args) { 
        string values1 = Console.ReadLine();
        string values2 = Console.ReadLine();
        string[] splitted1 = values1.Split(' ');
        string[] splitted2 = values2.Split(' ');
        
        double x1 = double.Parse(splitted1[0]);
        double y1 = double.Parse(splitted1[1]);
        double x2 = double.Parse(splitted2[0]);
        double y2 = double.Parse(splitted2[1]);
        
        double diffx = x2 - x1;
        double diffy = y2 - y1;
        
        double dist = Math.Sqrt(Math.Pow(diffx,2) + Math.Pow(diffy,2));
        
        Console.WriteLine(dist.ToString("0.0000"));
    }

}