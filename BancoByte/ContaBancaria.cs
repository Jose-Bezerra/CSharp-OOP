
using System.Globalization;

namespace BancoByte
{
	public class ContaBancaria
	{
		private string Nome { get; set; }
		public int Numero { get; private set; } // Auto Properties
		private double _saldo = 0;

		public ContaBancaria(string nome, int numero)
		{
			Nome = nome;
			Numero = numero;
		}

        public ContaBancaria(string nome, int numero, double saldo) : this(nome, numero)
        {
            _saldo = saldo;
        }

		public double Saldo
		{
			get { return _saldo; }
			set { _saldo = value; }
		}

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Dados de conta atualizados: ");
			Console.WriteLine(this);

        }

		public void Sacar(double valor)
		{
			if (valor > Saldo)
			{
				Console.WriteLine("Saldo Insuficiente!");
			} else
			{
				Saldo -= valor + 5;
				Console.WriteLine(this);
			}
		}

        public override string ToString()
        {
			return "Conta: " +
				Numero + " Titular: " +
				Nome + ", $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

		
    }
}

