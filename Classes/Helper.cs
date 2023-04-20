using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoe.Classes
{
    internal class Helper
    {

            //ConsoleColor.Cyan
            //ConsoleColor.Blue
            //ConsoleColor.DarkCyan
            //ConsoleColor.DarkBlue
            //ConsoleColor.DarkMagenta
            //ConsoleColor.DarkRed
            //ConsoleColor.Magenta
            //ConsoleColor.Red



        public Helper()
        {

        }

        //add colour managment control
        //Michael French ST10195824

        
            // colors in an order to create a blue to red gradient
            public static ConsoleColor[] Gradient = { ConsoleColor.Cyan, ConsoleColor.Blue,
                                                  ConsoleColor.DarkCyan,ConsoleColor.DarkBlue,
                                                  ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                                  ConsoleColor.Magenta, ConsoleColor.Red };

            //-------------------------------------------------METHODS----------------------------------------------//
            /// <summary>
            /// changes colour for user input text
            /// </summary>
            /// <param name="color"></param>
            public static void SetColor(ConsoleColor color)
            {
                Console.ForegroundColor = color;
            }

            /// <summary>
            /// writes to console in a specified color
            /// </summary>
            /// <param name="text"></param>
            /// <param name="color"></param>
            public static void MyWriteLine(string text, ConsoleColor color = ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
            }

            /// <summary>
            /// writes to console in a specified color but doesnt go to the next line
            /// </summary>
            /// <param name="text"></param>
            /// <param name="color"></param>
            public static void MyWrite(string text, ConsoleColor color = ConsoleColor.White)
            {
                Console.ForegroundColor = color;
                Console.Write(text);
            }

            /// <summary>
            /// changes the text color per letter based on an array of colors
            /// </summary>
            /// <param name="text"></param>
            public static void WriteGradient(string text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int index = i % Gradient.Length;
                    Console.ForegroundColor = Gradient[index];
                    Console.Write(text[i]);
                }
                Console.WriteLine();
            }
        }
    }
    //----------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------//









