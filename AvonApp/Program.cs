using System;
using System.Linq;
using System.Collections.Generic;


namespace AvonApp
{
    class Program
    {

        public static void CalcularMediaRecursivo(int pos, int somaParcial, List<int> lista)
        {
            if(pos == lista.Count - 1)
            {
                somaParcial += lista[pos];
                var media = somaParcial / (double)lista.Count;
                Console.WriteLine("Média calculada: " + media);
                Console.WriteLine("Quantidade de elementos maiores que a média: " + lista.Where(x => x > media).ToList().Count);
            } else
            {
                CalcularMediaRecursivo(pos + 1, somaParcial + lista[pos], lista);
            }
        }

        public static List<int> InverterLista(int indice, Stack<int> pilha, List<int> lista)
        {
            if (indice < lista.Count - 1)
            {
                pilha.Push(lista[indice]);
                InverterLista(indice + 1, pilha, lista);
            }
            else
                pilha.Push(lista[indice]);

            return pilha.ToList();

        }

        public static string ImprimirListaString(List<int> lista)
        {
            string str = "{";
            foreach(var a in lista)
            {
                str += (str.Length == 1 ? a + "" : ", " + a);
            }
            return str + "}";
        }

        public static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>() { 5, 1, 2, 50, 15, 80, 7 };

            Console.WriteLine("Lista definida no código: " + ImprimirListaString(listaNumeros));
            CalcularMediaRecursivo(0, 0, listaNumeros);

            Console.WriteLine("Lista invertida: " + ImprimirListaString(InverterLista(0, new Stack<int>(), listaNumeros)));
        }
    }
}
