﻿






internal class Program
{
    private static void Main(string[] args)
    {
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
        Console.WriteLine("Pattern ex 11:");
        printbasicpattern11();
        Console.ReadKey();
    }

    private static void printbasicpattern11()
    {
        var start = 1;
        var counter = 1;
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
            if(i <= 3)
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
            for(int j = 0; j < spaces; j++)
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