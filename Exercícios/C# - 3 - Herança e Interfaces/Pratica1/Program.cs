using Pratica1;

Console.WriteLine("Olá! Bem Vindo ao Calculator");
Operacoes operacoes = new Operacoes();
Console.WriteLine("O valor é: "+ operacoes.Soma.Calcular(5,9));
Console.WriteLine("O valor é: "+ operacoes.Subtracao.Calcular(50,41));
Console.WriteLine("O valor é: "+ operacoes.Multi.Calcular(4,22));
Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(90, 3));