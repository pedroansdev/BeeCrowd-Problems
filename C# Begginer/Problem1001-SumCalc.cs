/* A basic script that sums two integer values */

using System; 

class URI {

    static void Main(string[] args) { 
        
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        
        int Sum = A + B;
        
        Console.WriteLine("X = " + Sum);
    }

}