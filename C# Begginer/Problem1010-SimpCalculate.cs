/* A basic script that calculates the amount of two products, using only two inputs for this */

using System; 

class URI {

    static void Main(string[] args) { 
        string values1 = Console.ReadLine();
        string values2 = Console.ReadLine();
        string[] splitted1 = values1.Split(' ');
        string[] splitted2 = values2.Split(' ');
        
        int code1 = int.Parse(splitted1[0]);
        int units1 = int.Parse(splitted1[1]);
        float price1 = float.Parse(splitted1[2]);
        
        int code2 = int.Parse(splitted2[0]);
        int units2 = int.Parse(splitted2[1]);
        float price2 = float.Parse(splitted2[2]);
        
        double amount = units1*price1 + units2*price2;
        
        Console.WriteLine("VALOR A PAGAR: R$ " + amount.ToString("0.00"));
    }

}