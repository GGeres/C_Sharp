using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Investindo a Longo prazo");

        double fatorRend = 1.005;
        double invest = 1000;
        int anos;
        int mes;

        //Encadeamento de Laços (For)

        for(anos = 1; anos <=5; anos++)
        {
            for(mes = 1; mes < 13; mes++)
            {
                invest *= fatorRend;
            }
            fatorRend += 0.001;
        }
        Console.WriteLine("Depois de 5 anos você terá R$ " + invest);
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
