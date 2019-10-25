using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.Start();
        }

        void Start() {
            var task = StartAsync();
            Console.WriteLine("Thread not frozen");
            Console.ReadLine();
        }

        async Task StartAsync() {
            var task = AddAsync(10, 14);
            var task2 = AddAsync(50, 2);

            Console.WriteLine("Starting tasks");

            var result = await task;
            var result2 = await task2;

            Console.WriteLine("Done with adding!");
        }

        async Task<int> AddAsync(int a, int b) {
            int result = a + b;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return result;
        }
    }
}
