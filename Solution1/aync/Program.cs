using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace aync {
    class Program {
        static void Main(string[] args) {
            var program = new Program();
            program.Start();
            Console.ReadLine();
        }

        void Start() {
            Task sheep = Task.Run(() => Count("Sheep", 3));
            Task fish = Task.Run(() => Count("Fish", 20));
            Task deer = Task.Run(() => Count("Deer", 3));

            Task.WaitAll(sheep, fish, deer);
            Console.WriteLine("Done");
        }

        void Count(string thing, int amount) {
            for (int i = 0; i < amount; i++) {
                Console.WriteLine(thing + " " + (i+1));
                Thread.Sleep(250);
            }
        }


        void PrintInts(int num) {
            for (int i = 0; i < num; i++) {
                Console.Write(i + " ");
            }
        }


        void PrintChars(string chars) {
            for (int i = 0; i < chars.Length; i++) {
                Console.Write(chars[i] + " ");
            }
        }


        void OldStart() {
            CountAsync("fish");
            Count("sheep", 0);

            //Task.Run(() => Count("Sheep"));
            //Count("Fish");
        }


        

        Task CountAsync(string thing) {
            return Task.Run(() => {
                for (int i = 0; true; i++) {
                    Console.WriteLine(thing + " " + i);
                    Thread.Sleep(500);
                }
            });
        }

        async Task DoSomethingAsync() {
            int value = 13;
            await Task.Delay(TimeSpan.FromSeconds(1));

            value *= 2;

            await Task.Delay(TimeSpan.FromSeconds(1));

            Trace.WriteLine(value);
        
        }
    }
}
