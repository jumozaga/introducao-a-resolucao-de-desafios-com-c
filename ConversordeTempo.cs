using System;

    class MinhaClasse {
        static void Main(string[] args) {
            var timeInSeconds = int.Parse(Console.ReadLine());
            // 1h = 3600seg 
            var minutes =(timeInSeconds%3600)/60;
            var hours = timeInSeconds/3600;
            var seconds =(timeInSeconds%3600)%60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }