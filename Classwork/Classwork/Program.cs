namespace Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the Number for prime Number");
           int Number = Convert.ToInt32(Console.ReadLine());
            Boolean PrimeNumber =  primeNumber(Number);
            if (PrimeNumber == true) {
                Console.WriteLine("Number is Prime Number");
            }
            else
            {
                Console.WriteLine("Number is not Prime Number");
            }

            Console.Write("Enter hour (0-23): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minute (0-59): ");
            int minute = Convert.ToInt32(Console.ReadLine());

            double angle = FindAngle(hour, minute);
            Console.WriteLine($"The angle between the hour and minute hands is: {angle} degrees.");


            Console.Write("Enter a number to calculate its factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            try
            {
                int factorial = CalculateFactorial(num);
                Console.WriteLine($"Factorial of {num} is: {factorial}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Cannot calculate factorial due to overflow.");
            }

            try
            {
                Console.Write("Enter a number: ");
                double number = Convert.ToDouble(Console.ReadLine());

                double result = CalculateSquareRoot(number);
                Console.WriteLine($"The square root of {number} is: {result}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); // Handle negative number input
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.Write("Enter a binary number: ");
            string binaryInput = Console.ReadLine();

            int decimalNumber = 0;
            int power = 1; // Power of 2 starts at 2^0 = 1

            // Iterate over the binary number from right to left
            for (int i = binaryInput.Length - 1; i >= 0; i--)
            {
                if (binaryInput[i] == '1')
                {
                    decimalNumber += power;
                }
                power *= 2; // Move to the next power of 2
            }

            Console.WriteLine($"The decimal equivalent is: {decimalNumber}");

            while (true)
            {
                // Displaying menu options
                Console.WriteLine("Simple Calculator Menu:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an operation (1-5): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                // If user chooses to exit
                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                Console.Write("How many numbers do you want to input? ");
                int count = Convert.ToInt32(Console.ReadLine());

                // Initialize result based on the first number
                Console.Write("Enter number 1: ");
                double result = Convert.ToDouble(Console.ReadLine());

                // Process subsequent numbers
                for (int i = 2; i <= count; i++)
                {
                    Console.Write($"Enter number {i}: ");
                    double number = Convert.ToDouble(Console.ReadLine());

                    // Perform selected operation
                    switch (choice)
                    {
                        case 1: // Add
                            result += number;
                            break;

                        case 2: // Subtract
                            result -= number;
                            break;

                        case 3: // Multiply
                            result *= number;
                            break;

                        case 4: // Divide
                            if (num != 0)
                            {
                                result /= number;
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                                i--; // Re-enter the number
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid operation selected.");
                            break;
                    }
                }

                Console.WriteLine($"The result of the operation is: {result}\n");
            }
        }

        static bool primeNumber(int Num)
        {
            if (Num <=1) {
                return false;
            }
            else
            {
                for (int i = 2; i < Num; i++) {
                    if (Num % i == 0) { 
                        return false;
                    }
                }
                return true;
            }
            
        }
        static double FindAngle(int hour, int minute)
        {

            if (hour >= 12)
                hour = hour - 12;


            double hourAngle = (hour * 30) + (minute * 0.5);

           
            double minuteAngle = minute * 6; 


            double angle = Math.Abs(hourAngle - minuteAngle);


            return Math.Min(360 - angle, angle);
        }
        static int CalculateFactorial(int n)
        {
            int result = 1;
            try
            {
                checked // Enable overflow checking
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i; // Multiplying result by i
                    }
                }
            }
            catch (OverflowException) // Catch the overflow exception
            {
                Console.WriteLine($"Overflow occurred! Factorial of {n} exceeds the Int32 limit.");
                throw;
            }
            return result;
        }

        static double CalculateSquareRoot(double num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("num", "Cannot calculate square root of a negative number.");
            }
            return Math.Sqrt(num);
        }
    }
}

