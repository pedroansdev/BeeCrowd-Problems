/* A basic script that calculates the time it takes for a car to distance itself from another, based on the distance */

using System; 

class URI {

    static void Main(string[] args) { 
        int distance = int.Parse(Console.ReadLine());
        int time = distance * 2;
        
        Console.WriteLine(time + " minutos");
    }

}