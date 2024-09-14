namespace BaseOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their name, age, and favorite number
            Console.WriteLine("Enter the Full Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Age: ");
            string AgeString = Console.ReadLine();
            Console.WriteLine("Enter the Favorite Number: ");
            string FavoriteNumberString = Console.ReadLine();

            // Convert age and favorite number from strings to integers
            int age = int.Parse(AgeString);
            int favoriteNumber = int.Parse(FavoriteNumberString);

            // Call the methods to get the number of years until 100 and to check if age is even or odd
            int yearsUntil100 = CalculateYearsUntil100(age, favoriteNumber);
            string ageEvenOdd = CheckIfAgeIsEvenOrOdd(age);

            // Output: Greeting message, years until 100, and age even/odd check
            // Using both concatenation and string interpolation
            Console.WriteLine("Hello " + Name + "!");
            Console.WriteLine($"You are {age} years old, and your favorite number is {favoriteNumber}.");
            Console.WriteLine("You have " + yearsUntil100 + " years until you turn 100.");
            Console.WriteLine($"Your age is an {ageEvenOdd} number.");
        }

        // Method to calculate years until the user turns 100
        static int CalculateYearsUntil100(int age, int favoriteNumber)
        {
            return 100 - age;
        }

        // Method to check if the user's age is even or odd
        static string CheckIfAgeIsEvenOrOdd(int age)
        {
            return (age % 2 == 0) ? "even" : "odd";
        }

    }
}
