namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumberGuess();
        }

        public static void NumberGuess()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            //The following code will prompt the user
            //to guess what my favorite number is.
            Console.WriteLine("What is my favorite number? ");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("nah thats too low.");
            } else if (userInput > favNumber)
            {
                Console.WriteLine("nah that too high.");
            }
            else
            {
                Console.WriteLine("Nice.");
            }
        }
        
    }
}
