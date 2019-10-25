using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            string input;
            while ((input = Console.ReadLine()) != null) {
                string[] split = input.Split(' ');
                long a = long.Parse(split[0]);
                long b = long.Parse(split[1]);
                long res = Math.Abs(b - a);
                Console.WriteLine(res);
            }
        }
    }
}
