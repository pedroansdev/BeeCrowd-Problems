/* A basic script that calculates a simple average considering that grade A has weight 3.5 and grade B, weight 7.5 */

using System; 

class URI {

    static void Main(string[] args) {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double MEDIA = (A * 3.5 + B * 7.5)/11;
        
        Console.WriteLine("MEDIA = " + MEDIA.ToString("0.00000"));
    }

}