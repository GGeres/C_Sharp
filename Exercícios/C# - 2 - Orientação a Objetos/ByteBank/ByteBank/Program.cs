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

