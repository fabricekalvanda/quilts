// Fabrice Kalvanda
// July 16, 2020
// myQuiltsGame.cs
// This program prints quilts of the same pattern,but different sizes depending on the customers needs. 

using System;

namespace myQuiltsGame
{
    class MainClass
    {
        /* Method printint the first line of the quilts */

        static void line1(int quiltSize)
        {
            Console.Write("\t\t");//2 table lines
            
            for (int i = 0; i < (quiltSize * 1); i++)//printing the first line of the quilts 
            {
                Console.Write("#================#");
                Console.Write(" ");//space betweent printed lines
            }
            Console.WriteLine();
        }

        /* Method printint the second line of the quilts */

        static void line2(int quiltSize) 
        {
            if (quiltSize == 1)//check if the size is 1
            {
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("      ");
                for (int i = 0; i < quiltSize; i++)
                {
                    Console.Write("<><>");
                }
                Console.Write("      ");
                Console.Write("|\n");
            }
            else //check if it is more than one 
            {
                string space = " ";//space variable to scale the quilts 

                int k = ((18 * quiltSize) / 2) - ((4 * quiltSize * 1) / 2) - 4;//calculating the space so that the quilts scale propretly

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("      ");
                for (int i = 0; i < quiltSize; i++)
                {
                    Console.Write("<><>");
                }
                Console.Write("      ");
                Console.Write("|\n");
            }
        }

        /* Method printint the 3rd line of the quilts */

        static void line3(int quiltSize)
        {
            if (quiltSize ==1)
            {
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("    ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 4; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("    ");
                Console.Write("|\n");
            }
            else
            {

                string space = " ";

                int k = ((18 * quiltSize)/ 2) - ((4 * quiltSize * 1)) / 2 - 4;

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("    ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 4; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("    ");
                Console.Write("|\n");
            }
            
        }

        /* Method printint the 4th line of the quilts */

        static void line4(int quiltSize)
        {
            if (quiltSize == 1)
            {
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("  ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 8; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("  ");
                Console.Write("|\n");
            }
            else
            {
                string space = " ";

                int k = ((18 * quiltSize) / 2) - ((4 * quiltSize * 1) / 2) - 4;

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("  ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 8; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("  ");
                Console.Write("|\n");
            }
            
        }

        /* Method printint the 5th line of the quilts */

        static void line5(int quiltSize) 
        {
            if (quiltSize == 1)
            {
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 12; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("|\n");
            }
            else
            {
                string space = " ";

                int k = ((18 * quiltSize) / 2) - ((4 * quiltSize * 1) / 2) - 4;

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 12; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("|\n");
            }
            
        }

        /* Method printint the 6th line of the quilts */

        static void line6(int quiltSize)
        {
            if (quiltSize == 1)
            {
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 12; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("|\n");
            }
            else
            {
                string space = " ";

                int k = ((18 * quiltSize) / 2) - ((4 * quiltSize * 1) / 2) - 4;

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 12; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("|\n");
            }

        }

        /* Method printint the 7th line of the quilts */
        static void line7(int quiltSize)
        {
            if (quiltSize == 1)
            {
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("  ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 8; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("  ");
                Console.Write("|\n");
            }
            else
            {
                string space = " ";

                int k = ((18 * quiltSize) / 2) - ((4 * quiltSize * 1) / 2) - 4;

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("  ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 8; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("  ");
                Console.Write("|\n");
            }
        }

        /* method printint the 8th line of the quilts */

        static void line8(int quiltSize)
        {
            if (quiltSize == 1)
            {
               Console.Write("\t\t");
                Console.Write("|");
                Console.Write("    ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 4; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("    ");
                Console.Write("|\n");
            }
            else
            {
                string space = " ";

                int k = ((18 * quiltSize) / 2) - ((4 * quiltSize * 1) / 2) - 4;

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("    ");
                Console.Write("<>");
                for (int i = 0; i < 4 * quiltSize - 4 + 4; i++)
                {
                    Console.Write(".");
                }
                Console.Write("<>");
                Console.Write("    ");
                Console.Write("|\n");
            }

        }

        /* method printint the 9th line of the quilts */

        static void line9(int quiltSize)
        {
            if (quiltSize == 1)
            {
               Console.Write("\t\t");
                Console.Write("|");
                Console.Write("      ");
                for (int i = 0; i < quiltSize; i++)
                {
                    Console.Write("<><>");
                }
                Console.Write("      ");
                Console.Write("|\n");
            }
            else
            {
                string space = " ";

                int k = ((18 * quiltSize) / 2) - ((4 * quiltSize * 1) / 2) - 4;

                for (int i = 0; i < k; i++)
                {
                    Console.Write(space);
                }
                Console.Write("\t\t");
                Console.Write("|");
                Console.Write("      ");
                for (int i = 0; i < quiltSize; i++)
                {
                    Console.Write("<><>");
                }
                Console.Write("      ");
                Console.Write("|\n");
            }
        }

        /* Method printing the bottom line of the Quilts */

        static void line10(int quiltSize)
        {
           Console.Write("\t\t");

            for (int i = 0; i < (quiltSize * 1); i++)
            {
                Console.Write("#================#");
                Console.Write(" ");
            }
            Console.WriteLine();
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tina's Quilts! I'm glad you're here!");
            Console.WriteLine("What size quilt would you like?");
            string quilt = Console.ReadLine();
            int quiltSize = Int32.Parse(quilt);

            Console.WriteLine("Sure! Coming right up...");

            /* Calling all the methods one by one */

            line1(quiltSize);
            line2(quiltSize);
            line3(quiltSize);
            line4(quiltSize);
            line5(quiltSize);
            line6(quiltSize);
            line7(quiltSize);
            line8(quiltSize);
            line9(quiltSize);
            line10(quiltSize);
          
        }
    }
}
