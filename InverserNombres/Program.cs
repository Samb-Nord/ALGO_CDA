using System;

namespace InverserNombres
{
    class Program
    {
        static void Main(string[] args)
        {

            //inverser deux nombres
            inverserNombres();
        }


        //Lire 2 nombres a et b. Mettre le contenu de a dans b et celui de b dans a
        public static string inverserNombres()
        {

            int nombreTemporaire;
            Console.WriteLine("Entrez un premier nombre");
            int nombre1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un deuxième nombre");
            int nombre2 = Int32.Parse(Console.ReadLine());

                nombreTemporaire = nombre1;
                nombre1 = nombre2;
                nombre2 = nombreTemporaire;

                return "premier nombre : " + nombre1 + " - deuxième nombre : " + nombre2;

        }
    }
}
