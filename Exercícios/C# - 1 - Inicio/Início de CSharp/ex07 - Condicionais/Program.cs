using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");
        int idadeJohn = 19;
        int qtdPessoas = 3;
        if (idadeJohn >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (qtdPessoas >= 2)
            {
                Console.WriteLine("Você está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

        }
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
