using System;

namespace VolumeSphere
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entrez le rayon de la sphère en cm :");
            double rayon = Double.Parse(Console.ReadLine());

            //afficher le volume d'une sphère
            Console.WriteLine("volume : " + Math.Round(calculVolume(rayon), 2) + " cm3");
        }

        //calculer le volume d'une sphère
        public static double calculVolume(double rayon)
        {

            if (rayon > 0)
            {
                double pi = Math.PI;
                double volume = 4 * pi * Math.Pow(rayon, 3);
                return volume;
            }
            else
            {
                throw new Exception("Valeur du rayon doit être strictement supérieur à 0");
            }
        }
    }
}
