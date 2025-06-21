using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First log message");
        logger2.Log("Second log message");

        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger1 and logger2 are the same instance.");
        }
        else
        {
            Console.WriteLine("Different instances exist!");
        }
    }
}
