namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int rock = 1;
            int paper = 2;
            int scissors = 3;

            Console.Write("P1 Choose your name: ");
            string p1 = Console.ReadLine();
            Console.Clear();

            Console.Write("P2 Choose your name: ");
            string p2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{p2} Please Don't look at the screen");
            Console.WriteLine($"{p1}: Rock? Paper? Scissors? ");
            Console.Write("1 = Rock " + "2 = Paper " + "3 = Scissors : ");
            string p1Answer = Console.ReadLine();
            int p1NumAnswer = Convert.ToInt32(p1Answer);

            while (p1NumAnswer != 1 && p1NumAnswer != 2 && p1NumAnswer != 3)
            {
                Console.Write($"Invalid answer {p1}! Please enter again: ");
                p1Answer = Console.ReadLine();
                p1NumAnswer = Convert.ToInt32(p1Answer);
            }

            Console.Clear();

            Console.WriteLine($"{p1} Please Don't look at the screen");
            Console.WriteLine($"{p2}: Rock? Paper? Scissors? ");
            Console.Write("1 = Rock " + "2 = Paper " + "3 = Scissors : ");
            string p2Answer = Console.ReadLine();
            int p2NumAnswer = Convert.ToInt32(p2Answer);

            while (p2NumAnswer != 1 && p2NumAnswer != 2 && p2NumAnswer != 3)
            {
                Console.Write($"Invalid answer {p2}! Please enter again: ");
                p2Answer = Console.ReadLine();
                p2NumAnswer = Convert.ToInt32(p2Answer);
            }

            Console.Clear();

            int countdownTime = 3;
            Console.WriteLine("Computer is choosing...");

            Console.Clear();

            for (int i = countdownTime; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
            }

            Console.Clear();

            if (p1NumAnswer == rock)
            {
                Console.WriteLine($"{p1}'s Selection: Rock");
            }
            else if (p1NumAnswer == paper)
            {
                Console.WriteLine($"{p1}'s Selection: Paper");
            }
            else
            {
                Console.WriteLine($"{p1}'s Selection: Scissors");
            }

            if (p2NumAnswer == rock)
            {
                Console.WriteLine($"{p2}'s Selection: Rock");
            }
            else if (p2NumAnswer == paper)
            {
                Console.WriteLine($"{p2}'s Selection: Paper");
            }
            else
            {
                Console.WriteLine($"{p2}'s Selection: Scissors");
            }

            if (p1NumAnswer == p2NumAnswer)
            {
                Console.WriteLine("It's a tie!!!");
            }
            else if ((p1NumAnswer == 1 && p2NumAnswer == 3) || (p1NumAnswer == 2 && p2NumAnswer == 1) || (p1NumAnswer == 3 && p2NumAnswer == 2))
            {
                Console.WriteLine($"{p1} wins!!!");
            }
            else
            {
                Console.WriteLine($"{p2} wins!!!");
            }

            Console.ReadLine();
        }
    }
}
