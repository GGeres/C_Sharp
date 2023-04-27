using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais 2");
        int idadeJohn = 19;
        int qtdPessoas = 2;

        bool mIdade = false;
        bool grupo = true;

        if (mIdade || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {  
        Console.WriteLine("Não pode entrar.");
        }
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}

