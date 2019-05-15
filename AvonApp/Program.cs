using System;


namespace AvonApp
{
    class Program
    {

        public static void ImprimirMedia(int inicio, int somaParcial, int[] lista)
        {
            int somatoriaDeValoresDaLista = somaParcial;

            //int maiorValor = 0;
            if (inicio < lista.Length)
            {
                somatoriaDeValoresDaLista += lista[inicio];
                ImprimirMedia(inicio + 1, somatoriaDeValoresDaLista, lista);

            }
            else
            {
                var media = somatoriaDeValoresDaLista / (double)lista.Length;
                Console.WriteLine("A média calculada é: " + media);
                Console.ReadLine();
            }
        }
        public static void Main(string[] args)
        {
            int[] listaNumeros = { 5, 1, 2, 50, 15 };
            ImprimirMedia(0, 0, listaNumeros);
        }
    }
}
