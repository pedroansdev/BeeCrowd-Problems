/* A basic script that reads the number, hours worked in a month and the amount per hour of a people, and print his number and calculates his salary */

using System; 

class URI {

    static void Main(string[] args) { 
        int number = int.Parse(Console.ReadLine());
        int hour = int.Parse(Console.ReadLine());
        float perHour = float.Parse(Console.ReadLine());
        float salary = hour * perHour;
        
        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + salary.ToString("0.00"));
    }

}