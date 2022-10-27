using System;
class Program
{

    static void Time(string str)
    {
        // Get Hours
        int h1 = (int)str[0] - '0';
        int h2 = (int)str[1] - '0';
        //str = Console.ReadLine();

        int hh = h1 * 10 + h2;
        //hh %= 12;

        string Meridien;
        if (hh < 12)
        {
            Meridien = "AM";
        }
        else
            Meridien = "PM";

        hh %= 12;

        if (hh == 0)
        {
            Console.Write("12");
            //Printing minutes and seconds
            for (int i = 2; i < 8; ++i)
            {
                Console.Write(str[i]);
            }

        }
        else
        {
            Console.Write(hh);
            for (int i = 2; i < 8; ++i)
            {
                Console.Write(str[i]);
            }

        }

        Console.WriteLine(" " + Meridien);
    }
    static void Time12(string str1)
    {
        // Get hours
        int h11 = (int)str1[1] - '0';
        int h21 = (int)str1[0] - '0';
        int hh1 = (h21 * 10 + h11 % 10);
        //str1 = Console.ReadLine();

        // If time is in "AM"
        if (str1[8] == 'A')
        {
            if (hh1 == 12)
            {
                Console.Write("00");
                for (int i = 2; i <= 7; i++)
                    Console.Write(str1[i]);
            }
            else
            {
                for (int i = 0; i <= 7; i++)
                    Console.Write(str1[i]);
            }
        }


        else
        {
            if (hh1 == 12)
            {
                Console.Write("12");
                for (int i = 2; i <= 7; i++)
                    Console.Write(str1[i]);
            }
            else
            {
                hh1 = hh1 + 12;
                Console.Write(hh1);
                for (int i = 2; i <= 7; i++)
                    Console.Write(str1[i]);
            }
        }

        //// Get Hours
        //int h1 = (int)str[0] - '0';
        //int h2 = (int)str[1] - '0';

        //int hh = h1 * 10 + h2 %10;
        ////hh %= 12;


        //hh %= 24;

        //if (hh == 0)
        //{
        //    Console.Write("00");
        //    //Printing minutes and seconds
        //    for (int i = 1; i <= 7; ++i)
        //    {
        //        Console.Write(str[i]);
        //    }
        //}
        //else
        //{
        //    Console.Write(hh);
        //    for (int i = 1; i <= 7; ++i)
        //    {
        //        Console.Write(str[i]);
        //    }
        //}

        Console.WriteLine(" ");
    }

    public static void Main(string[] args)
    {
        Program obj = new Program();
        //string str = "14:44:10";
        //string str1 = "10:40:10PM";
        Console.WriteLine("Welcome to Time Choice");

        Console.WriteLine("Enter the 24 hrs format");
        string str = Console.ReadLine();

        Console.WriteLine("Enter the 12 hrs format");
        string str1 = Console.ReadLine();


        //Console.WriteLine($"{}");

        Console.WriteLine("12 hour format");
        Time(str);

        Console.WriteLine("24 hour format");
        Time12(str1);

    }
}