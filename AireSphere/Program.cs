using System;

namespace AireSphere
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entrez le rayon de la sphère en cm :");
            double rayon = Double.Parse(Console.ReadLine());
            //afficher l'aire d'une sphère
            Console.WriteLine("aire : " + Math.Round(calculAire(rayon), 2) + " cm²");
        }

        public static double calculAire(double rayon)
        {

            if (rayon > 0)
            {
                double pi = Math.PI;
                double aire = 4 * pi * Math.Pow(rayon, 2);
                return aire;
            }
            else
            {
                //on retourne une exception
                throw new Exception("Valeur du rayon doit être strictement supérieur à 0");
            }

        }
    }
}
