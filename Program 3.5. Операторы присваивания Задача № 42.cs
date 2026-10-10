using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program42
{
    internal class Program
    {
        static void Main()
        {
            int a = 10;

            // Промежуточный расчёт для наглядности
            int rightSide = 2 + 3;
            Console.WriteLine($"Правая часть (2 + 3) = {rightSide}");

            a *= rightSide; // то же, что a = a * rightSide

            Console.WriteLine($"a после a *= {rightSide}: {a}"); // 50
        }
    }
}
