using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primFrase = "Alura - Cursos de Tecnologia ";
        string seguFrase = "Escola Online ";
        Console.WriteLine(primFrase + seguFrase + 2023);

        string cursos = @"
- Go 
- Java 
- C# 
- Python";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}