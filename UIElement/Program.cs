using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int healthProcent = 0, maxHealth = 10;
            
            while (true)
            {
                DrawBar(healthProcent, maxHealth, ConsoleColor.Red, 0, '_');

                Console.SetCursorPosition(0, 5);

                Console.Write("Введите процент, на который заполнить здоровье:");
                healthProcent = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int procent, int maxValue, ConsoleColor color, int position, char symbol = ' ')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            int value = procent * maxValue / 100;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }
            Console.Write(bar + ']');
        }
    }
}
