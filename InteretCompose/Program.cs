using System;

namespace InteretCompose
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
            //calcul avec intérêt composé
            Console.WriteLine("Nouveau montant estimé : " + Math.Round(calculInteretCompose(sommeInitiale, interets, annees), 2) + "€");
        }

        //calcul avec intérêt composé
        public static double calculInteretCompose(double sommeInitiale, double interets, double annees)
        {

            double sommeFinale = sommeInitiale * (1 + interets * annees);

            if (sommeInitiale > 0 && interets > 0 && annees > 0)
                return sommeFinale;
            else
                throw new Exception("les valeurs entrées ne correspondent pas");
        }
    }
}
