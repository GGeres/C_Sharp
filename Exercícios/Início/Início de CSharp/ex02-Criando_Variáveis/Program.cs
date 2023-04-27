using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");
        
        int idade;
        idade = 23;

        Console.WriteLine("Minha idade é " +idade);

        idade = 25 - 5;

        Console.WriteLine(idade);

        idade = 5 * 2 - 6;
        Console.WriteLine(idade);

        idade = (5 + 9 - 8) * 6;
        Console.WriteLine(idade);
        

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}