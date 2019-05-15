using System;
using System.Linq;


namespace AvonApp
{
    class Program
    {

        public static void CalcularMediaRecursivo(int pos, int somaParcial, int[] vetor)
        {
            if(pos == vetor.Length - 1)
            {
                somaParcial += vetor[pos];
                var media = somaParcial / (double)vetor.Length;
                Console.WriteLine("Média calculada: " + media);
                Console.WriteLine("Quantidade de elementos maiores que a média: " + vetor.Where(x => x > media).ToList().Count);
            } else
            {
                CalcularMediaRecursivo(pos + 1, somaParcial + vetor[pos], vetor);
            }
        }


        public static void Main(string[] args)
        {
            int[] listaNumeros = { 5, 1, 2, 50, 15, 80, 7 };

            Console.WriteLine("Lista definida no código: { 5, 1, 2, 50, 15, 80, 7 }");
            CalcularMediaRecursivo(0, 0, listaNumeros);
        }
    }
}
