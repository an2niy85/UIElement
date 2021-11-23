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
                DrawBar(healthProcent, maxHealth, 0, '#');

                Console.SetCursorPosition(0, 5);

                Console.Write("Введите процент, на который заполнить здоровье:");
                healthProcent = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int procent, int maxValue, int position, char symbol)
        {
            char defaultSymbol = '_';
            int value = procent * maxValue / 100;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.Write(bar);
            
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += defaultSymbol;
            }
            Console.Write(bar + ']');
        }
    }
}
