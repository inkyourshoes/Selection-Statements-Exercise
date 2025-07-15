namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 
            var r = new Random();
            var favNumber = r.Next(1,100);
            int response = 0;
            
            //var userInput = int.Parse(Console.ReadLine());

            while (response != favNumber)
            {

                Console.WriteLine("Give me a number between 1 and 100:");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine("Too low!\nYour guess: {response}");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine("Too high!\nYour guess: {response}");
                }
                else
                {
                    Console.WriteLine("You got it!\nYour guess: {response}");
                }
            }
            
        }
    }
}
