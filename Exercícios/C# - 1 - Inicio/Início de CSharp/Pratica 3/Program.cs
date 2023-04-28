using System;

class Programa
{
    static void Main(String [] args)
    {
        int fat = 1;
        for (int i = 1; i < 11; i++)
        {
            fat*=i;
            Console.WriteLine("Fatorial de "+i+" = "+fat);
        }
    }
}