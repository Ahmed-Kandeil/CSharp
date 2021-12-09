using System;
class Program
{
    public static void Main(string[] args)
    {
        Random r = new Random();
        int answer, g;
        answer = 1 + (r.Next() % 100);
        do
        {
            Console.Write("Guess A Number : ");
            g = int.Parse(Console.ReadLine());
            if (g > answer)
            {
                Console.WriteLine("Too Large");
            }
            else if (g < answer)
            {
                Console.WriteLine("Too Small");
            }
        } while (g != answer);
        Console.WriteLine("That's Correct");
    }
}
