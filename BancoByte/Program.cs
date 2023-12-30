using System.Globalization;
using BancoByte;

ContaBancaria conta;

//Abertura da conta
Console.WriteLine("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.WriteLine("Haverá Depósito inicial (s/n)? ");
char resposta = char.Parse(Console.ReadLine());
if (resposta == 's' || resposta == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(titular, numero, depositoInicial);
}
else
{
    conta = new ContaBancaria(titular, numero);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);
                
Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Depositar(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Sacar(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

