using System;

namespace funcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n1, n2, y;

            Console.WriteLine( "--- Calculadora da Mallu --- ");
            Console.WriteLine("Pressione 1 para iniciar: ");
            x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                do
                {
                    Console.WriteLine("Digite o 1º número: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o 2º número: ");
                    n2 = int.Parse(Console.ReadLine());

                    int resultado = somar(n1, n2);
                    Console.WriteLine("O resultado da soma dos números é: " + resultado);

                    int resultado1 = subtrair(n1, n2);
                    Console.WriteLine("O resultado da subtração dos números é: " + resultado1);

                    int resultado2 = multiplicar(n1, n2);
                    Console.WriteLine("O resultado da multiplicação dos números é: " + resultado2);

                    string resultado3 = dividir(n1, n2);
                    Console.WriteLine("O resultado da divisão dos números é: " + resultado3);

                    Console.WriteLine("Pressione 2 para desligar ou 1 para iniciar: ");
                    y = int.Parse(Console.ReadLine());

                }
                while (y == 2);

            }
                else Console.WriteLine(" -- Fim do programa -- ");


        }


        public static int somar(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        private static string dividir(int n1, int n2)
        {
            if (eDividendoMenorIgualZero(n1))
            {
                return "Dividendo menor ou igual a zero";
            }
            return string.Format($"{n1} / {n2} = {n1 / n2}");

            bool eDividendoMenorIgualZero(int n1)
            {
                if (n1 <= 0)
                {
                    return true;
                }
                return false;
            }
        }

    }
}