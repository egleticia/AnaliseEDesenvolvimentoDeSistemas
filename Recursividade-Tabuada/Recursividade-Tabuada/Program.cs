


Console.WriteLine("Escreva um número para sua tabuada: ");
int t = int.Parse(Console.ReadLine());

int i = 0;
tabuada(t, i);



static void tabuada (int n, int numero)
{
    if (numero > 10)
    {
        return;

    }

    int x = n * numero;
    Console.WriteLine($"{n} * {numero} = {x}");

    tabuada(n, numero+1);

}
