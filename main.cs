using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp
{
    internal class Program
    {
        public static int W = 60;
        public static int H = 32;
        public static string Field = "";
        public static int cursor = 0;
        public static string login = "";
        public static string password = "";
        public static int screen = 0;
        public static void Window()
        {
            OutputEncoding = Encoding.Unicode;
            CursorVisible = false;
            WindowWidth = W;
            BufferWidth = W;
            WindowHeight = H;
            BufferHeight = H;
        }
        public static void Screen()
        {
            SetCursorPosition(0, 0);
            Write(Field);
            SetCursorPosition(0, 31);
            Write(cursor);
            SetCursorPosition(3, 31);
            Write(login);
            SetCursorPosition(login.Length + 5, 31);
            Write(password);
            if (screen == 0)
            {
                SetCursorPosition(27, 5);
                Write("LOGIN");
                SetCursorPosition(18, 7);
                Write("╔═════════════════════╗");
                SetCursorPosition(18, 8);
                Write("║                     ║");
                SetCursorPosition(18, 9);
                Write("╚═════════════════════╝");
                SetCursorPosition(18, 11);
                Write("╔═════════════════════╗");
                SetCursorPosition(18, 12);
                Write("║                     ║");
                SetCursorPosition(18, 13);
                Write("╚═════════════════════╝");
                SetCursorPosition(18, 15);
                Write("╔═════════════════════╗");
                SetCursorPosition(18, 16);
                Write("║         OK          ║");
                SetCursorPosition(18, 17);
                Write("╚═════════════════════╝");
                SetCursorPosition(16, 8 + cursor * 4);
                Write(">");
            }
            else if (screen == 1)
            {

            }
        }
        static void Main(string[] args)
        {
            Field += "╔══════════════════════════════════════════════════════════╗";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "║                                                          ║";
            Field += "╚══════════════════════════════════════════════════════════╝";
            Window();
            Screen();
            do
            {
                if (KeyAvailable)
                {
                    ConsoleKey key = ReadKey(false).Key;
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            if (screen == 0)
                            {
                                if (cursor == 0)
                                {
                                    SetCursorPosition(20, 8);
                                    CursorVisible = true;
                                    login = ReadLine();
                                    CursorVisible = false;
                                }
                                else if (cursor == 1)
                                {
                                    SetCursorPosition(20, 12);
                                    CursorVisible = true;
                                    password = ReadLine();
                                    CursorVisible = false;
                                }
                                else if (cursor == 2)
                                {
                                    screen = 1;
                                }
                            }
                            else if (screen == 1)
                            {
                                if (cursor == 0)
                                {
                                    SetCursorPosition(20, 8);
                                    CursorVisible = true;
                                    login = ReadLine();
                                    CursorVisible = false;
                                }
                                else if (cursor == 1)
                                {
                                    SetCursorPosition(20, 12);
                                    CursorVisible = true;
                                    password = ReadLine();
                                    CursorVisible = false;
                                }
                                else if (cursor == 2)
                                {
                                    screen = 2;
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            cursor++;
                            if (cursor >= 3)
                            {
                                cursor = 0;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            cursor--;
                            if (cursor <= -1)
                            {
                                cursor = 2;
                            }
                            break;
                        case ConsoleKey.Escape:
                            SetCursorPosition(0, 31);
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                Screen();
            } while (true);
        }
    }
}
