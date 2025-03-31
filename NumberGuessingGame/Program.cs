namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0,100);

            bool win = false;
            do
            {
                Console.Write("Guess a number inbetween 0 and 100: ");
                int number = int.Parse(Console.ReadLine());

                if(number > winNum)
                {
                    Console.WriteLine("Too high! Guess lower...");
                }
                else if (number < winNum)
                {
                    Console.WriteLine("Go low! Guess higher...");
                }
                else 
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
