using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        bool allowChallenge = args.Contains("--challenge");
        int max = allowChallenge ? 5 : 4;
        int task = rnd.Next(1, max + 1);

        if (task == 5)
        {
            int fallback = rnd.Next(1, 5);
            Console.WriteLine($"Challenge task selected: 5");
            Console.WriteLine($"Fallback task: {fallback}");
        }
        else
        {
            Console.WriteLine($"Your task is: {task}");
        }
    }
}