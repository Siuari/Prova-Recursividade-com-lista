using System;


namespace AvonApp
{
    class Program
    {

        public static void ImprimirMedia(int inicio, int qtdInicial, int somaParcial, int[] lista)
        {
            int somatoriaDeValoresDaLista = somaParcial;

            int qtdValoresMaiorQueMedia = qtdInicial;
            var media = 0.0;

            if (inicio < lista.Length)
            {
                somatoriaDeValoresDaLista += lista[inicio];
                ImprimirMedia(inicio + 1, qtdValoresMaiorQueMedia, somatoriaDeValoresDaLista, lista);
                if (lista[inicio] > media)
                    qtdValoresMaiorQueMedia++;
            }
            else
            {
                media = somatoriaDeValoresDaLista / (double)lista.Length;

                Console.WriteLine("A média calculada é: " + media);
                Console.WriteLine("A quantidade de numeros maior que a média é: " + qtdValoresMaiorQueMedia);

                Console.ReadLine();
            }
        }

        public static void MetodoRecursivo2(int pos, int somaParcial, int[] vetor)
        {
            if(pos == vetor.Length - 1)
            {
                somaParcial += vetor[pos];
                Console.WriteLine("Metodo recursivo 2: " + somaParcial / (double)vetor.Length);
            } else
            {
                MetodoRecursivo2(pos + 1, somaParcial + vetor[pos], vetor);
            }
        }


        public static void Main(string[] args)
        {
            int[] listaNumeros = { 5, 1, 2, 50, 15 };
            ImprimirMedia(0, 0, 0, listaNumeros);
            MetodoRecursivo2(0, 0, listaNumeros);
        }
    }
}
