namespace Course;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Entre com sue nome: ");
        string name = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa? ");
        int room = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço de um produto: ");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre seu último nome, idade e altura na mesma linha: ");
        string[] vet = Console.ReadLine().Split(' ');


        Console.WriteLine(name);
        Console.WriteLine(room);
        Console.WriteLine(price);
        Console.WriteLine(vet[0]);
        Console.WriteLine(vet[1]);
        Console.WriteLine(vet[2]);



    }
}

