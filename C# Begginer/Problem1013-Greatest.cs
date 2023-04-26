/* A basic script that reads and calculate the greatest value between A, B and C */

using System; 

class URI {

    static void Main(string[] args) { 
        string values = Console.ReadLine();
        string[] splitted = values.Split(' ');
        
        int A = int.Parse(splitted[0]);
        int B = int.Parse(splitted[1]);
        int C = int.Parse(splitted[2]);
        
        int greatestAB = (A + B + Math.Abs(A-B))/2;
        int greatest = (greatestAB + C + Math.Abs(greatestAB - C))/2;
        
        Console.WriteLine(greatest + " eh o maior");
    }

}