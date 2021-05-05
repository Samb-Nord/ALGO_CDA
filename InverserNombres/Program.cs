using System;

namespace InverserNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un premier nombre");
            int nombre1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un deuxième nombre");
            int nombre2 = Int32.Parse(Console.ReadLine());
            //inverser deux nombres
            Console.WriteLine("premier nombre devient " + nombre1 + " - deuxième nombre devient " + nombre2);

            InverserNombres(ref nombre1, ref nombre2, out int nombreTemporaire);

            Console.WriteLine("premier nombre devient " + nombre1 + " - deuxième nombre devient " + nombre2);
        }

        //Lire 2 nombres a et b. Mettre le contenu de a dans b et celui de b dans a
        public static void InverserNombres(ref int a, ref int b, out int temporaire)
        {

            temporaire = a;
            a = b;
            b = temporaire;
        }
    }
}
