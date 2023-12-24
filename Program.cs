namespace Course;

class Program
{
    static void Main(string[] args)
    {
        int age = 32;
        string name = "Maria";
        double balance = 10.2568;

        // Placeholders
        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2}", name, age, balance);

        //Interpolação
        Console.WriteLine($"{name} tem {age} anos e tem saldo igual a {balance:f2} ");

        //Concatenação
        Console.WriteLine(name + " tem " + age + " anos e tem saldo igual a " + balance.ToString("F2"));

    }
}

