




contar(int.Parse(Console.ReadLine()));

static void contar(int n)
{
    for (int i = n; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
}


Console.WriteLine("Informe um número: ");
int n = int.Parse(Console.ReadLine());

int f = fatorial(n);
Console.WriteLine("Fatorial é " + f);

static int fatorial(int n)
{
    if (n == 1)
        return 1;

    return n * fatorial(n - 1);
  
}