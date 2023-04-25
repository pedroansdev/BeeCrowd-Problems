/* A basic script that calculates the difference of the product between A and B and product between C and D */

using System; 

class URI {

    static void Main(string[] args) { 
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int DIFF = A * B - C * D;
        
        Console.WriteLine("DIFERENCA = " + DIFF);
    }

}