namespace Topic_5___Assignment_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            int guess;
            Console.WriteLine("I am thinking of a number from 1-10. Guess what the number is");
            Int32.TryParse(Console.ReadLine(), out guess);

            if (guess == number)
                Console.WriteLine("Correct! My number was " + number);
            else if (guess != number)
                Console.WriteLine("Incorrect. My number was " + number);
            else if (number > 10 || number < 1)
                Console.WriteLine("Invalid Input, you didn't enter a number within the range");

        




        }
    }
}
