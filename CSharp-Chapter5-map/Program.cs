using System;

namespace Uppgift_5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] karta = new string[4, 4];
            karta[0, 0] = "A";
            karta[1, 0] = "B";
            karta[2, 0] = "C";
            karta[3, 0] = "D";
            karta[0, 1] = "E";
            karta[1, 1] = "F";
            karta[2, 1] = "G";
            karta[3, 1] = "H";
            karta[0, 2] = "I";
            karta[1, 2] = "J";
            karta[2, 2] = "K";
            karta[3, 2] = "L";
            karta[0, 3] = "M";
            karta[1, 3] = "N";
            karta[2, 3] = "O";
            karta[3, 3] = "P";

            int x = 0;
            int y = 0;

            string val = "r";

            do
            {
                Console.WriteLine($"Du står på X:{x}, Y:{y}");
                Console.WriteLine($"Du står på bokstaven {karta[x, y]}");
                Console.WriteLine("Välj en riktning");
                Console.WriteLine("w = upp, s = ner, a = vänster, d = höger, r = starta om, e = avsluta\n");

                if (val != "r")
                {
                    val = Console.ReadLine();
                    Console.WriteLine();
                }

                switch (val)
                {
                    case "r":
                        x = 0;
                        y = 0;
                        val = "";
                        break;

                    case "w":
                        y--;
                        break;

                    case "s":
                        y++;
                        break;

                    case "a":
                        x--;
                        break;

                    case "d":
                        x++;
                        break;

                    case "e":
                        Console.WriteLine("Programmet avslutas...\n");
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ\n");
                        break;
                }

                if (val == "e")
                {
                    break;
                }

                if (x < 0)
                {
                    x = 0;
                }
                else if (x > 3)
                {
                    x = 3;
                }

                if (y < 0)
                {
                    y = 0;
                }
                else if (y > 3)
                {
                    y = 3;
                }

                for (int y1 = 0; y1 < karta.GetLength(1); y1++)
                {
                    for (int x1 = 0; x1 < karta.GetLength(0); x1++)
                    {

                        if (x == x1 && y == y1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(karta[x1, y1]);
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.Write(karta[x1, y1]);
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            } while (val != "e");
        }
    }
}