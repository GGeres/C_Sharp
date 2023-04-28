using ByteBank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André Silva";
contaAndre.numAgencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

Console.WriteLine("Saldo da Conta do André = " + contaAndre.saldo);

contaAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pós-depósito = " + contaAndre.saldo);

if (contaAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André " + contaAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque");
}

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numAgencia = 17;
contaMaria.conta = "1010-5";
contaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaMaria.saldo);

contaAndre.Transferir(50, contaMaria);
Console.WriteLine("Saldo do André = "+ contaAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaMaria.saldo);