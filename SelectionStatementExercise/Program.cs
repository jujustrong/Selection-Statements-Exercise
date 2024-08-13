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
            var favNumber = r.Next(1, 11);
            var i = true;
            
            //The following code will prompt the user
            //to guess what my favorite number is.
            
            while (i == true)
            {
                Console.WriteLine("What is my favorite number? ");
                var userInput = int.Parse(Console.ReadLine());
                
                if (userInput < favNumber)
                {
                    Console.WriteLine("nah thats too low.");
                    Console.WriteLine("guess again.");
                    i = true;
                } else if (userInput > favNumber)
                {
                    Console.WriteLine("nah that too high.");
                    Console.WriteLine("guess again.");
                    i = true;
                }
                else
                {
                    Console.WriteLine("Nice.");
                    i = false;
                }
            }
            
        }
        
    }
}
