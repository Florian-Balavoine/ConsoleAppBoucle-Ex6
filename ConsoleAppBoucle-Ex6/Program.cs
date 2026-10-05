using System;

namespace ConsoleAppBoucle_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre un montant en euros : ");
            int montant = int.Parse(Console.ReadLine());

            int nb100 = 0;
            int nb50 = 0;
            int nb20 = 0;
            int nb10 = 0;
            int nb5 = 0;
            int nb2 = 0;
            int nb1 = 0;

           
            do
            {
                if (montant >= 100)
                {
                    montant = montant - 100;
                    nb100 = nb100 + 1;
                }
                else if (montant >= 50)
                {
                    montant = montant - 50;
                    nb50 = nb50 + 1;
                }
                else if (montant >= 20)
                {
                    montant = montant - 20;
                    nb20 = nb20 + 1;
                }
                else if (montant >= 10)
                {
                    montant = montant - 10;
                    nb10 = nb10 + 1;
                }
                else if (montant >= 5)
                {
                    montant = montant - 5;
                    nb5 = nb5 + 1;
                }
                else if (montant >= 2)
                {
                    montant = montant - 2;
                    nb2 = nb2 + 1;
                }
                else if (montant >= 1)
                {
                    montant = montant - 1;
                    nb1 = nb1 + 1;
                }
            } while (montant > 0);

            Console.WriteLine("Billets de 100 : " + nb100);
            Console.WriteLine("Billets de 50 : " + nb50);
            Console.WriteLine("Billets de 20 : " + nb20);
            Console.WriteLine("Billets de 10 : " + nb10);
            Console.WriteLine("Billets de 5 : " + nb5);
            Console.WriteLine("Pièces de 2 : " + nb2);
            Console.WriteLine("Pièces de 1 : " + nb1);
            Console.ReadLine();
        }
    }
}