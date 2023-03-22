
// Escrever uma função em C# que receba como parâmetro um vetor de inteiros e retorne a soma dos números ímpares contidos no vetor:


Console.WriteLine("Digite quantos números terá seu vetor de inteiros: ");
int n = int.Parse(Console.ReadLine());


int[] vetor = new int[n];


int contagem = 0;

while (contagem < vetor.Length)
{
    Console.WriteLine("Digite o número: ");
    vetor[contagem] = int.Parse(Console.ReadLine());

    contagem++;

}

Console.WriteLine("A soma dos vetores é igual a: " + somaImpares(vetor));


static int somaImpares(int[] vetorInserido)
{
    int contagem = 0;
    int soma = 0;
    while (contagem < vetorInserido.Length)
    {
        if (vetorInserido[contagem] % 2 == 1)
        {
            soma += vetorInserido[contagem];
        }

        contagem++;

    }
    return soma;
}











