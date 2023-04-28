using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double invest = 1000;
        int mes = 1;
        
        // rendimento 0.5% (0.005) ao mês

        while (mes <= 12)
        {
            invest = invest + invest * 0.005;
            Console.WriteLine("No mês "+mes+" você tem R$ "+ invest);
            
            mes +=1; //-> mes = mes + 1 = mes++
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
