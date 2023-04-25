/* A basic script that calculates the final salary of a seller in a month */

using System; 

class URI {

    static void Main(string[] args) { 
        string sellerName = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double sellsValue = double.Parse(Console.ReadLine());
        double total = salary + sellsValue * 0.15;
        
        Console.WriteLine("TOTAL = R$ " + total.ToString("0.00"));
    }

}