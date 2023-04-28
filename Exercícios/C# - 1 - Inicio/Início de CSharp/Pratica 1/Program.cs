using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando a Prática de Condicionais");


        int idade = 18;
        int qtdPessoas = 2;
        bool acompanhado = qtdPessoas >=2;
        bool mIdade = idade >= 18;

        if (mIdade && acompanhado)
        {
            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("Infelizmente, você não pode entrar.");
        }
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}

