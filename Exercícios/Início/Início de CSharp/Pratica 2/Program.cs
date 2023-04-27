using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 2000.0;
        double ir;
        string textComplementar;

        //ifs aqui

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            ir = 7.5;
            textComplementar = "Deduza o valor de R$ 142,00 na declaração";
            Console.WriteLine("Seu IR é de " + ir + "%. " + textComplementar);
        } else if (salario >= 2800.01 && salario <= 3751.00)
        {
            ir = 15;
            textComplementar = "Deduza o valor de R$ 350,00 na declaração";
            Console.WriteLine("Seu IR é de " + ir + "%. " + textComplementar);
        } else if (salario >= 3751.01 && salario <= 4664.0)
        {
            ir = 22.5;
            textComplementar = "Deduza o valor de R$ 636,00 na declaração";
            Console.WriteLine("Seu IR é de " + ir + "%. " + textComplementar);
        }
    
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
