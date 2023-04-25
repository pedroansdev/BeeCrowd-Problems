/* A basic script that calculates a simple average considering that grade A has weight 2, grade B has weight 3 and grade C has weight 5 */

using System; 

class URI {

    static void Main(string[] args) { 
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double MEDIA = (A * 2 + B * 3 + C * 5)/10;
        
        Console.WriteLine("MEDIA = " + MEDIA.ToString("0.0"));
    }

}