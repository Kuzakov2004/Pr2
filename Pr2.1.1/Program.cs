using System;
class Program {
        static void Main(string[] args)
        {
                string S, J;
                int count = 0;
                J = Console.ReadLine();
                S = Console.ReadLine();


                foreach (char diamond in J)
                {
                        foreach (char stone in S)
                        {
                                if (stone == diamond)
                                {
                                        count++;
                                }
                        }
                }
                Console.WriteLine(count);
        }
}
