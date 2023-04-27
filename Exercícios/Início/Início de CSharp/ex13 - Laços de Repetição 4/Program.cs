using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****

        int contLinhas;
        int contCol;
        for(contLinhas = 0;contLinhas<10;contLinhas++)
        {
            for (contCol = 0; contCol < 10; contCol++)
            {
                Console.Write("*");
                if (contCol >= contLinhas)
                    break;
            }
            Console.WriteLine(); 
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}