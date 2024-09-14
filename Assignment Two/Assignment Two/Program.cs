namespace Assignment_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Radius of cylinder");
            double radius =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of cylinder");
            double height = Convert.ToDouble(Console.ReadLine());
            Volume vol = new Volume();
           double Volumeofcylinder =  vol.CalculateVolume(radius, height);
            Console.WriteLine($"The Volume of Cylinder {Volumeofcylinder}");
            FibonacciSequence fibonacci = new FibonacciSequence();

 
            Console.Write("Enter the number of Fibonacci terms to generate: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 2)
            {
                fibonacci.GenerateFibonacci(n);
            }
            else
            {
                Console.WriteLine("Please enter a number greater than or equal to 2.");
            }
        } 
    }
}

public class Volume
{
    public double CalculateVolume(double r, double h)
    {
        return Math.PI * Math.Pow(r, 2) * h;
    }
}

public class FibonacciSequence
{
    
    public void GenerateFibonacci(int n)
    {

        int first = 1, second = 1;

        Console.Write(first + " " + second + " ");

        
        for (int i = 3; i <= n; i++)
        {
            int next = first + second; 
            Console.Write(next + " "); 

            
            first = second;
            second = next;
        }

        Console.WriteLine(); 
    }
}
