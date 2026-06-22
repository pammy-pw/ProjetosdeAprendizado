using System;

class Program
{
    static void Main()
    {
        float nota = 0;
        float soma = 0;
        int contador = 0;
        float media = 0;

        Console.Write("Digite uma nota (-1 para encerrar): ");
        nota = float.Parse(Console.ReadLine());

        while (nota != -1)
        {
            soma += nota;
            contador++;
            Console.Write("Digite uma nota (-1 para encerrar): ");
            nota = float.Parse(Console.ReadLine());
        }

        media = soma / contador;
        Console.WriteLine("Média: " + media);
    }
}
