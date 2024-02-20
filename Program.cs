







using PatternsExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        //BasicMathProblems bm = new BasicMathProblems();
        //bm.PrintPrimeAmount(100);
        //Console.WriteLine("Pattern ex 1:");
        //PrintBasicPattern();
        //Console.WriteLine("Pattern ex 2:");
        //PrintBasicPattern2();
        //Console.WriteLine("Pattern ex 3:");
        //PrintBasicPattern3();
        //Console.WriteLine("Pattern ex 4:");
        //PrintBasicPattern4();
        //Console.WriteLine("Pattern ex 5:");
        //PrintBasicPattern5();
        //Console.WriteLine("Pattern ex 6:");
        //PrintBasicPattern6();

        //Console.WriteLine("Pattern ex 7:");
        //PrintBasicPattern7();
        //Console.WriteLine("Pattern ex 8:");
        //PrintBasicPattern8();
        //Console.WriteLine("Pattern ex 9:");
        //PrintBasicPattern9();
        //Console.WriteLine("Pattern ex 10:");
        //printbasicpattern10();
        //Console.WriteLine("Pattern ex 11:");
        //printbasicpattern11();
        //Console.WriteLine("Pattern ex 12:");
        //printbasicpattern12();
        //Console.WriteLine("Pattern ex 13:");
        //printbasicpattern13();
        Console.WriteLine("Pattern ex 14:");
        printbasicpattern14();
        Console.ReadKey();
    }

    private static void printbasicpattern14()
    {
        var chars = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        for (int i = 0; i < 28; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                if (i >= chars.Length) break;
                Console.Write(chars[j]);
            }
            Console.WriteLine();
        }
    }

    /*Pattern ex 13:

1
2 3
4 5 6
7 8 9 10
11 12 13 14 15
*/
    private static void printbasicpattern13()
    {
        var valueToAdd = 0;
       for(int i = 0; i <= 6; i++)
        {
            
            for(int j = 0; j < i; j++)
            {
                valueToAdd++;
                Console.Write(valueToAdd + " ");
            }
            Console.WriteLine();
        }
    }

    /*
Pattern ex 12:
1      1
12    21
123  321
12344321

*/
    private static void printbasicpattern12()
    {
        var rows = 9;
       var start = 1;
       var counter = 1;
       var spaces = 2 * ( rows -1);
       for (int i = 0; i < rows; i++) 
       {
            for (int j = 0; j < start; j++)
            {
                Console.Write(counter);
                counter++;
            }
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < start; j++)
            {
                counter--;
                Console.Write(counter);
            }
            Console.WriteLine();
            start++;
            spaces-=2;
       }
    }

    /*
1
01
101
0101
10101
010101                          
*/
    private static void printbasicpattern11()
    {
        var start = 1;

        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0) start = 1;
            else start = 0;

            for (int j = 0; j <= i; j++)
            {
                Console.Write(start);
                start = 1 - start;
            }


            Console.WriteLine();
        }
    }

    //    Pattern ex 10:
    //*
    //**
    //***
    //****
    //*****
    //****
    //***
    //**
    //*
    private static void printbasicpattern10()
    {
        var stars = 1;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }
            if (i <= 3)
            {
                stars++;
            }
            else
            {
                stars--;
            }
            Console.WriteLine();
        }
    }

    //   Pattern ex 9:
    //    *
    //   ***
    //  *****
    // *******
    //*********
    //*********
    // *******
    //  *****
    //   ***
    //    *

    private static void PrintBasicPattern9()
    {
        // top tree
        var stars = 1;
        var spaces = 5;

        for (int i = 0; i < 5; i++)
        {
            for (int k = 0; k < spaces; k++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < stars; k++)
            {
                Console.Write("*");
            }
            for (int k = 0; k < spaces; k++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            spaces--;
            stars += 2;
        }
        stars = 9;
        spaces = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }

            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine();
            stars -= 2;
            spaces++;
        }




    }

    /**********
     pattern 8

       *******
        *****
         ***
          *
   */
    private static void PrintBasicPattern8()
    {
        var spaces = 0;
        var stars = 9;
        for (int i = 0; i < 5; i++)
        {

            for (int k = 0; k < spaces; k++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }

            for (int k = 0; k < spaces; k++)
            {
                Console.Write(" ");
            }
            spaces += 1;
            stars -= 2;
            Console.WriteLine();
        }
    }




    private static void PrintBasicPattern7()
    {
        var counter = 1;
        var spaces = 5;

        for (int i = 0; i < 5; i++)
        {
            for (int k = 0; k < spaces; k++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < counter; k++)
            {
                Console.Write("*");
            }



            for (int k = 0; k < spaces; k++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
            spaces -= 1;
            counter += 2;
        }
    }

    private static void PrintBasicPattern6()
    {
        var counter = 5;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < counter; j++)
            {
                Console.Write($"{j + 1}");
            }
            counter -= 1;
            Console.WriteLine();
        }
    }

    private static void PrintBasicPattern5()
    {
        var counter = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int k = 5; k > counter; k--)
            {
                Console.Write("*");
            }
            counter++;
            Console.WriteLine();
        }
    }

    //pattern4
    private static void PrintBasicPattern4()
    {
        var counter = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 1; j <= counter; j++)
            {
                Console.Write(counter);
            }
            Console.WriteLine();
            counter++;
        }
    }
    //pattern3
    private static void PrintBasicPattern3()
    {
        var counter = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < counter; j++)
            {
                Console.Write($"{j + 1}");
            }
            counter++;
            Console.WriteLine();
        }
    }
    // pattern1
    private static void PrintBasicPattern1()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    //pattern2
    private static void PrintBasicPattern2()
    {
        int counter = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < counter; j++)
            {
                Console.Write("*");
            }
            counter++;
            Console.WriteLine();
        }
    }
}