namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            //my number will be 222
            var s = 222;

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < s)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > s)
            {
                Console.WriteLine("Too High");
            }
            else 
            {
                Console.WriteLine("YES!");
            }

            //Console.WriteLine("Try again");
            //var secondInput = int.Parse(Console.ReadLine());

            //if (secondInput < s)
            //{
            //    Console.WriteLine("Too Low");
            //}
            //else if (secondInput > s)
            //{
            //    Console.WriteLine("Too High");
            //}
            //else
            //{
            //    Console.WriteLine("YES!");
            //}
        }
    }
}
