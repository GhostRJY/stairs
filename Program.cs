using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Int32 height = 11;
            Int32 width = 3;
            Int32 posX = 0;

            for (Int32 y = 0; y < height; ++y)
            {
                if (y > 1)
                {                    
                    if (y % 2 == 0)
                    {
                        posX += width - 1;
                    }
                }

                //ставлю указатель в нужное положение чтоб отрисовать следующую ступеньку
                Console.SetCursorPosition(posX, y);

                for (Int32 x = 0; x < width; ++x)
                {
                    if ((y % 2) == 0 || x == width-1)
                    {                        
                        Console.Write("*");
                    }

                    else
                    {
                    
                        Console.Write(" ");
                    }                   
                }
                
                Console.WriteLine("");
                
            }
        }
    }
}

