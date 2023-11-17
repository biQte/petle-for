namespace petle_for
{
    internal class Program
    {
        static void printSomeStars()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("*");
            }
        }

        static void printOTower(int towerHeight)
        {
            for (int i = 0; i < towerHeight; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("O");
                }
                Console.Write("\n");
            }
        }

        static void printXRectangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i == 0 || i == height - 1) || (i != 0 && j == 0) || (i != height - 1 && j == 0) || (i != 0 && j == width - 1) || (i != height - 1 && j == width - 1))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void printLetterA(int height)
        {
            int width = (height * 2) - 1;
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if (i == 0 && j == width / 2)
                    {
                        Console.Write("A");
                    } else if (i == 1 && ((j == (width / 2) - 1) || (j == (width / 2) + 1)))
                    {
                        Console.Write("A");
                    } else if (i == (height / 2) && (j > (width / 2) - i) && (j < (width / 2) + i)) 
                    {
                        Console.Write("A");
                    } else if (i > 1 && ((j == (width / 2) - i) || (j == (width / 2) + i)))
                    {
                        Console.Write("A");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void printLetterL(int thickness, int height, int width)
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if(i < height - thickness && j < thickness)
                    {
                        Console.Write("L");
                    } else if (i >= height - thickness)
                    {
                        Console.Write("L");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void printFullXRectangle()
        {
            Console.WriteLine("Rysowanie prostokąta");
            Console.Write("Podaj wysokość prostokąta: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Podaj szerokość prostokąta: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("X");
                }
                Console.Write("\n");
            }
        }

        static void printFullXTriangle()
        {
            Console.WriteLine("Rysowanie trójkąta");
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int width = 1;
            for(int k = 1; k < height; k++)
            {
                width += 2;
            }

            int center = width / 2;

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if(i == 0 && j == center)
                    {
                        Console.Write("X");
                    } else if (i > 0 && j >= center - i && j <= center + i)
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void printXTriangle()
        {
            Console.WriteLine("Rysowanie trójkąta");
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int width = 1;
            for (int k = 1; k < height; k++)
            {
                width += 2;
            }

            int center = width / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == center)
                    {
                        Console.Write("X");
                    }
                    else if (i > 0 && j == center - i || j == center + i)
                    {
                        Console.Write("X");
                    } else if (i == height - 1)
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void printFullXRightTriangle()
        {
            Console.WriteLine("Rysowanie trójkąta");
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if(j <= i)
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void printXRightTriangle()
        {
            Console.WriteLine("Rysowanie trójkąta");
            Console.Write("Podaj wysokość trójkąta: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (j == 0 || j == i)
                    {
                        Console.Write("X");
                    } else if (i == height - 1)
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            printSomeStars();
            Console.WriteLine("\n");
            printOTower(5);
            Console.WriteLine("\n");
            printXRectangle(4, 10);
            Console.WriteLine("\n");
            printLetterA(6);
            Console.WriteLine("\n");
            printLetterL(4, 11, 8);
            Console.WriteLine("\n");
            printFullXRectangle();
            Console.WriteLine("\n");
            printFullXTriangle();
            Console.WriteLine("\n");
            printXTriangle();
            Console.WriteLine("\n");
            printFullXRightTriangle();
            Console.WriteLine("\n");
            printXRightTriangle();
        }
    }
}
