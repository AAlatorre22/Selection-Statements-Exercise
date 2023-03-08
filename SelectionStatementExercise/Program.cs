namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game! I'll think of a number between 1-100 and you try to guess it!");
            Console.WriteLine("Please enter your guess.");

            var num = 22;
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < 22)
            {
                Console.WriteLine("Too low!");
            }

            else if (userInput > 22)
            {
                Console.WriteLine("Too high!");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}
