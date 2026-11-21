using System;

namespace CalculatorCS
{
    class Program
    {
        // Cere un numar pana cand utilizatorul scrie unul valid
        static double CitesteNumar(string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                if (double.TryParse(Console.ReadLine(), out double n))
                    return n;
                Console.WriteLine("Eroare: introduceti un numar valid.");
            }
        }

        static void Main()
        {
            Console.WriteLine("=== Calculator-CS ===");
            Console.WriteLine("(pentru iesire scrieti x in loc de operatie)");

            while (true)
            {
                Console.WriteLine();
                double a = CitesteNumar("Primul numar: ");
                Console.Write("Operatia (+, -, *, /): ");
                string op = Console.ReadLine() ?? "";
                if (op == "x")
                    break;
                double b = CitesteNumar("Al doilea numar: ");

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"Rezultat: {a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"Rezultat: {a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"Rezultat: {a} * {b} = {a * b}");
                        break;
                    case "/":
                        Console.WriteLine($"Rezultat: {a} / {b} = {a / b}");
                        break;
                    default:
                        Console.WriteLine("Operatie necunoscuta.");
                        break;
                }
            }

            Console.WriteLine("La revedere!");
        }
    }
}