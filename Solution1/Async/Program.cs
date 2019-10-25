using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async {
    class Program {
        /*
        static async Task Main(string[] args) {
            var cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            var eggs = await FryEggs(2);
            Console.WriteLine("eggs are ready");
            var bacon = await FryBacon(3);
            Console.WriteLine("bacon is ready");
            var toast = await ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            var oj = PourOJ();
            Console.WriteLine("oj is ready");

            Console.WriteLine("Breakfast is ready!");
        }*/

        static async Task Main(string[] args) {
            int cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            Task<int> eggTask = FryEggs(2);
            Task<int> baconTask = FryBacon(3);
            Task<int> toastTask = ToastBread(2);
            int toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");
            int oj = PourOJ();
            Console.WriteLine("oj is ready");

            int eggs = await eggTask;
            Console.WriteLine("eggs are ready");
            int bacon = await baconTask;
            Console.WriteLine("bacon is ready");

            Console.WriteLine("Breakfast is ready!");
        }

        private static void ApplyJam(int toast) {
            Thread.Sleep(500);
        }

        private static void ApplyButter(int toast) {
            Thread.Sleep(500);
        }

        private static int PourOJ() {
            Thread.Sleep(1000);
            return 1;
        }

        private async static Task<int> ToastBread(int v) {
            Thread.Sleep(5000);
            return 1;
        }

        private async static Task<int> FryBacon(int v) {
            Thread.Sleep(5000);
            return 1;
        }

        private async static Task<int> FryEggs(int v) {
            Thread.Sleep(5000);
            return 1;
        }

        private static int PourCoffee() {
            Thread.Sleep(5000);
            return 1;
        }
    }
}
