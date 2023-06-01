// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        // iterate from 1 to 100
        for (int n = 1; n <= 100; n++) // Loop from 1 to 100
        {
            if (n % 15 == 0) // Check if n is divisible by both 3 and 5
            {
                Console.WriteLine("fizzbuzz"); // Print "fizzbuzz"
            }
            else if (n % 3 == 0) // Check if n is divisible by 3
            {
                Console.WriteLine("fizz"); // Print "fizz"
            }
            else if (n % 5 == 0) // Check if n is divisible by 5
            {
                Console.WriteLine("buzz"); // Print "buzz"
            }
            else
            {
                Console.WriteLine(n); // Print the value of n
            }
        }
    }
}
