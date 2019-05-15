using System;


namespace AvonApp
{
    class Program
    {

        public static void ImprimirMedia(int inicio, int somaParcial, int[] lista)
        {
            int somatoriaDeValoresDaLista = somaParcial;
            double media = 0.0;
            //int maiorValor = 0;
            if (inicio < lista.Length)
            {
                somatoriaDeValoresDaLista += lista[inicio];
                ImprimirMedia(inicio + 1, somatoriaDeValoresDaLista, lista);

            }
            media = somatoriaDeValoresDaLista / (double)lista.Length;
            Console.WriteLine("A média calculada é: " + media);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            int[] listaNumeros = { 5, 8, 2, 4, 15 };
            ImprimirMedia(0, 0, listaNumeros);
        }
    }
}
