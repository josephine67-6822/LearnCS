using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5; int b = 2;
            Console.WriteLine($"a + b = {a + b}");
            // Addition
            // Subtractio
            //kfjalkmdfakma;f;

            //Arrey
            string[] cars = new string[3];
            cars[0] = "Volvo";
            cars[1] = "BMW";
            cars[2] = "Ford";
            Console.WriteLine($"First car: {cars[0]}");
            Console.WriteLine($"Second car: {cars[1]}");
            Console.WriteLine($"Third car: {cars[2]}");
            //List (Dynamic Array)
            List<int> numbers = new List<int>();
            numbers.Add(64);
            numbers.Add(34);
            numbers.Add(25);
            Console.WriteLine($"First number: {numbers[0]}");
            Console.WriteLine($"Second number: {numbers[1]}");
            Console.WriteLine($"Third number: {numbers[2]}");
            numbers.Remove(34);
            Console.WriteLine($"Second number: {numbers[1]}");
            numbers.Add(100);
            numbers[0] = numbers[1] + numbers[2];
            Console.WriteLine($"First number: {numbers[0]}");
            // Dictionaries
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Apple", 0.99f);
            products.Add("Banana", 0.59f);
            products.Add("Orange", 0.79f);
            Console.WriteLine($"Apple: ${products["Apple"]}");
            Console.WriteLine($"Banana: ${products["Banana"]}");
            Console.WriteLine($"Orange: ${products["Orange"]}");
            if (a > b) Console.WriteLine("Alright, a is greater than b");
            else Console.WriteLine("No, b is greater than a");

            int age = 15;
            if (age >= 15) Console.WriteLine("You are a teenajer");
            else Console.WriteLine("You are a minor");

            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }

            bool isTrue = true;
            int counter = 0;
            while (isTrue) // isTrue == true)
            {
                Console.WriteLine("Eternity");
                if (counter == 10)
                {
                    isTrue = false;
                }
                counter++;

            }
            foreach (string car in cars)
            {
                Console.WriteLine($"Car: {car}"); // Iterates through each element in the cars array
            }


            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Car: {cars[i]}"); // Iterates through each element in the cars array using index)
            }

            //Functions
            string Hello(string name = "Noname")
            {
                return $"Hello, (name)!";
            }

            /* string h = Hello();
            Console.WriteLine(h); */

            Console.WriteLine(Hello("John"));
            Console.WriteLine(Hello());

            void NumberCompare(int x, int y)
            {
                if (x > y) Console.WriteLine($"{x} is greater than {y}");
                else if (x < y) Console.WriteLine($"{x} is less than {y}");
                else Console.WriteLine($"{x} is equal to {y}");
            }

            NumberCompare(5, 10);

            List<Player> players = new List<Player>();

            for (int i = 0; i < 5; i++)
            {
                players.Add(new Player());
            }
            /*players.Add(new Player("Alice", 5));
            players.Add(new Player("Bob", 10));
            players.Add(new Player("Charlie", 15));

            /*players[0].Name = "John";
            players[1].Name = "Alice";
            players[2].Name = "Bob";
            players[0].Level = 1;
            players[1].Level = 2;
            players[2].Level = 3; */



            foreach (Player player in players)
            {
                Console.WriteLine($"Player: {player.Name}, Level: {player.Level}");

            }


        }
        class Player
        {
            public string Name;
            public int Health;
            public int Level;
            public void Introduce()
            {
                Console.WriteLine($"Hi, my name is {Name}, I have {Health} health and I am level {Level}.");
            }
        }
    }
}




