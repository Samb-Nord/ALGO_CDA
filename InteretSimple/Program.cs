using System;

namespace InteretSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la somme de votre compte :");
            double sommeInitiale = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez les intérêts en pourcentage :");
            double interets = Double.Parse(Console.ReadLine()) / 100;


            Console.WriteLine("Entrez le nombre d'années du compte :");
            int annees = Int32.Parse(Console.ReadLine());

            //calcul avec intérêt simple
            Console.WriteLine("Nouveau montant estimé : " + Math.Round(calculInteretSimple(sommeInitiale, interets, annees), 2) + "€");
        }

        /*Lire la somme initiale S placée sur un compte, l'intérêt i offert par la banque et le nombre n d'années de placement de la somme S.

Calculez la valeur acquise par la somme S placée pendant n années avec un intérêt simple: S ( 1 + n * i ) et composé: S ( 1 + i )n*/

        //calcul avec intérêt simple
        public static double calculInteretSimple(double sommeInitiale, double interets, double annees)
        {

            double sommeFinale = sommeInitiale * (1 + interets * annees);

            if (sommeInitiale > 0 && interets > 0 && annees > 0)
                return sommeFinale;
            else
                throw new Exception("les valeurs entrées ne correspondent pas");
        }
    }
}
