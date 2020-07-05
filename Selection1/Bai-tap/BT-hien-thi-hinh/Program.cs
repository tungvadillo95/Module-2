using System;

namespace BT_hien_thi_hinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            int lengthRectangle;
                            int widthRectangle;
                            Console.WriteLine("Enter the length of the rectangle: ");
                            lengthRectangle = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the width of the rectangle: ");
                            widthRectangle = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Print the rectangle");
                            for (int i = 0; i < widthRectangle; i++)
                            {
                                for (int j = 0; j < lengthRectangle; j++)
                                {
                                    Console.Write(" * ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            int angle;
                            int lengthTriangle = 0;
                            Console.WriteLine("Print the square triangle");
                            Console.WriteLine("1. The corner is square at botton-left ");
                            Console.WriteLine("2. The corner is square at top-left");
                            Console.WriteLine("3. The corner is square at botton-right");
                            Console.WriteLine("4. The corner is square at top-right");
                            Console.WriteLine("Enter your choice: ");
                            angle = Int32.Parse(Console.ReadLine());
                            if (angle > 4 || angle <= 0)
                            {
                                Console.WriteLine("No Choice!");
                            }
                            else
                            {
                                Console.WriteLine("Enter your length triangle: ");
                                lengthTriangle = Int32.Parse(Console.ReadLine());
                            }
                            switch (angle)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("The corner is square at botton-left ");
                                        for (int i = 1; i <= lengthTriangle; i++)
                                        {
                                            for (int j = 0; j < i; j++)
                                            {
                                                Console.Write(" * ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("The corner is square at top-left");
                                        for (int i = lengthTriangle; i >= 1; i--)
                                        {
                                            for (int j = 0; j < i; j++)
                                            {
                                                Console.Write(" * ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("The corner is square at botton-right");
                                        for (int i = 1; i <= lengthTriangle; i++)
                                        {
                                            for (int j = lengthTriangle - 1; j >= i; j--)
                                            {
                                                Console.Write("   ");
                                            }
                                            for (int k = 1; k <= i; k++)
                                            {
                                                Console.Write(" * ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("The corner is square at top-right");
                                        for (int i = 1; i <= lengthTriangle; i++)
                                        {
                                            for (int k = 1; k < i; k++)
                                            {
                                                Console.Write("   ");
                                            }
                                            for (int j = lengthTriangle; j >= i; j--)
                                            {
                                                Console.Write(" * ");
                                            }
                                            Console.WriteLine();
                                        }
                                    }
                                    break;
                                    // default:
                                    //     Console.WriteLine("Choice Wrong!");
                                    //     break;
                            }
                            break;
                        }
                    case 3:
                        {
                            int widthTriangle;
                            Console.WriteLine("Enter your width scales triangle: ");
                            widthTriangle = Int32.Parse(Console.ReadLine());
                            for (int i = 1; i <= widthTriangle; i++)
                            {
                                for (int j = widthTriangle - 1; j >= i; j--)
                                {
                                    Console.Write("   ");
                                }
                                for (int k = 1; k < i; k++)
                                {
                                    Console.Write(" * ");
                                }
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write(" * ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}

