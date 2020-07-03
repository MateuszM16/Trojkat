using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Trojkat
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] boki = new double[3];
            int bok_max = 0;
            bool status = true;

            for (; ; )
            {

                Console.WriteLine("Podaj dłgości boków");

                do
                {
                    Error(status);

                    Console.Write("Bok nr.1: ");
                    status = double.TryParse(Console.ReadLine(), out boki[0]);

                } while (status == false);

                Sprzatanie1(boki);

                do
                {
                    Error(status);

                    Console.Write("Bok nr.2: ");
                    status = double.TryParse(Console.ReadLine(), out boki[1]);

                } while (status == false);

                Sprzatanie2(boki);

                do
                {
                    Error(status);

                    Console.Write("Bok nr.3: ");
                    status = double.TryParse(Console.ReadLine(), out boki[2]);

                } while (status == false);

                Sprzatanie3(boki);
                Sprawdzenie(boki);
                Reset();
            }

        }

        /// <summary>
        /// Resetowanie ustawień
        /// </summary>
        private static void Reset()
        {
            Console.ResetColor();
            Console.Read();
            Console.Read();
            Console.Clear();
        }

        /// <summary>
        /// Usuwa nieprawidlowe liczby
        /// </summary>
        /// <param name="boki"></param>
        private static void Sprzatanie3(double[] boki)
        {
            Sprzatanie2(boki);
            Console.WriteLine("Bok nr.3: " + boki[2]);
        }

        /// <summary>
        /// Usuwa nieprawidłowe liczby
        /// </summary>
        /// <param name="boki"></param>
        private static void Sprzatanie2(double[] boki)
        {
            Sprzatanie1(boki);
            Console.WriteLine("Bok nr.2: " + boki[1]);
        }

        /// <summary>
        /// Usuwa nieprawidłowe liczby
        /// </summary>
        /// <param name="boki"></param>
        private static void Sprzatanie1(double[] boki)
        {
            Console.Clear();
            Console.WriteLine("Podaj dłgości boków");
            Console.WriteLine("Bok nr.1: " + boki[0]);
        }

        /// <summary>
        /// Wyświetla bład przy podaniu złej dlugości boków 
        /// </summary>
        /// <param name="status"></param>
        private static void Error(bool status)
        {
            if (status == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zła długość boku! Spróbuj ponownie!");
                Console.ResetColor();
            }
        }


        /// <summary>
        /// Sprawdza czy z podanych boków można utworzyć trójkat
        /// </summary>
        /// <param name="boki"></param>
        private static void Sprawdzenie(double[] boki)
        {
            int bok_max = (boki[0] > boki[1]) ? 0 : 1;
            bok_max = (boki[2] > bok_max) ? 2 : bok_max;

            if (boki[bok_max] < boki[0] + boki[1] + boki[2] - boki[bok_max])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Z tych boków można zbudować trójkąt");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie można zbudować trójkąta z tych boków");
            }
        }
    }
}
