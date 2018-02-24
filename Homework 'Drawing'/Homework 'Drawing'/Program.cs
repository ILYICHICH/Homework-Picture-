using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__Drawing_
{
    class Program
    {
        static void Main(string[] args)
        {
            int left = Console.WindowWidth / 2;
            int top = Console.WindowHeight / 2;
            Console.SetCursorPosition(left, top);
            while(true)
            {
                ConsoleKeyInfo consoleSetCursorPosition = Console.ReadKey();
                if (consoleSetCursorPosition.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(left, top -= 1);
                }
                if (consoleSetCursorPosition.Key == ConsoleKey.DownArrow) 
                {
                    Console.SetCursorPosition(left, top += 1);

                }
                if (consoleSetCursorPosition.Key == ConsoleKey.LeftArrow) 
                {
                    Console.SetCursorPosition(left -= 1, top);

                }
                if (consoleSetCursorPosition.Key == ConsoleKey.RightArrow) 
                {
                    Console.SetCursorPosition(left += 1, top);
                }
                Console.WriteLine("*");
                if (left >= 119)
                {
                    Console.SetCursorPosition(left = 1, top);
                }
                if (top <= 0)
                {
                    Console.SetCursorPosition(left, top = 119);
                }
                if (left <= 0)
                {
                    Console.SetCursorPosition(left = 119, top);
                }

















            }
           
        }
    }
}
