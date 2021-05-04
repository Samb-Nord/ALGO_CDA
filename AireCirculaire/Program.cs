using System;

namespace AireCirculaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le rayon d'une sphère en cm :");
            double rayon = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez l'angle de la sphère en degré :");
            double angle = Double.Parse(Console.ReadLine());
            //afficher l'aire du secteur circulaire d'une sphère
            Console.WriteLine("aire circulaire" + Math.Round(calculerAireCirculaire(rayon, angle), 2) + " cm²");
        }

        //Lire le rayon R d'un cercle et un angle a (en degré(s)). Calculer et afficher l'aire du secteur circulaire =  R2 a / 360
        public static double calculerAireCirculaire(double rayon, double angle)
        {

            if (rayon > 0 && angle > 0)
                return (Math.PI * Math.Pow(rayon, 2) * angle) / 360;
            else
                throw new Exception("Valeur du rayon et du degré doivent être strictement supérieur à 0");

        }
    }
}
