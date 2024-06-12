namespace SelectionStatementExercise
{
    public class Program
    {
        public static void NumberGame(int favNumber)
        {

            Console.WriteLine("I'm thinking of a number between 1 and 10...");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("That's too low!");
                NumberGame(favNumber);
            }

            else if (userInput > favNumber)
            {
                Console.WriteLine("That's too high!");
                NumberGame(favNumber);

            }

            else
            {
                Console.WriteLine("That's not ri---Oh, you guessed it! Good one!");
            }
        }
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1, 1000);

            NumberGame(favNumber);
        }
    }
}
