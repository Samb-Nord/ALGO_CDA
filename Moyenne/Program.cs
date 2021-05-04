using System;

namespace Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un premier nombre :");
            double nombre1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un deuxième nombre :");
            double nombre2 = Double.Parse(Console.ReadLine());
            //afficher la moyenne
            Console.WriteLine("moyenne : " + Math.Round(calculMoyenne(nombre1, nombre2), 2));
        }

        //Lire 2 nombres a et b. Calculer et afficher leur moyenne. 

        public static double calculMoyenne(double nombre1, double nombre2)
        {
            double moyenne = (nombre1 + nombre2) / 2;
            if (nombre1 > 0 && nombre2 > 0)
                return moyenne;
            else
                throw new Exception("les nombres doivent être strictement positifs");
        }
    }
}
