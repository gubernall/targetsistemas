#define EX1

#if EX1

int INDICE = 13, SOMA = 0, K = 0;

while(K < INDICE)
{
    K = K + 1;
    SOMA = SOMA + K;
}
Console.WriteLine(SOMA);

#endif

#if EX2
using System;

class Program {
    static bool Fibonacci(int n) {
        int a = 0;
        int b = 1;
        while (a <= n) {
            if (a == n) {
                return true;
            }
            int temp = b;
            b = a + b;
            a = temp;
        }
        return false;
    }

    static void Main() {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        if (Fibonacci(num)) {
            Console.WriteLine($"O número {num} pertence a sequência de Fibonacci.");
        } else {
            Console.WriteLine($"O número {num} não pertence a sequência de Fibonacci.");
        }
    }
}

#endif

#if EX5
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string original = Console.ReadLine();
        char[] caracteres = original.ToCharArray();

        int tamanho = caracteres.Length;
        for (int i = 0; i < tamanho / 2; i++)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[tamanho - 1 - i];
            caracteres[tamanho - 1 - i] = temp;
        }

        string invertida = new string(caracteres);
        Console.WriteLine(invertida);
    }
}
#endif
