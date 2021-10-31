/*
Titre : Nombre Caché 
Description : Mini-jeu permettant à deux joueurs de chercher le nombre de l'autre 
Auteur : UNG David 
Date de création : 30 OCT 2021
Date de dernière modification : 30 OCT 2021
*/
using System;

namespace NombreCache
{
    class Program
    {
        static int essai = 0;
        static void gestionSaisie()
        {
            int correct = 0; 
            while (correct != 1)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    essai = int.Parse(Console.ReadLine()); // le nombre à chercher 
                    correct = 1;
                }
                catch
                {
                    Console.WriteLine("Vous avez fait une erreur de saisie, veuillez choisir un nombre entier ");
                }
            }
        }
        static void Main(string[] args)
        {
            int nombreCache = 0;
            int compteur = 1;
            int correct = 0;
            //tour du joueur 1
            while (correct != 1)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    nombreCache = int.Parse(Console.ReadLine()); // le nombre à chercher 
                    correct = 1;
                }
                catch
                {
                    Console.WriteLine("Vous avez fait une erreur de saisie, veuillez choisir un nombre entier ");
                }
            }
            Console.Clear(); // permet d'effacer la console, pour que le deuxième joueur ne voit pas ce que le nombre du premier
            correct = 0;
            // tour du joueur 2
            // saisie du premier essai (avec la fonction) 
            gestionSaisie();
            // test de comparaison entre le nombre caché et l'essai 
            while (nombreCache != essai)
            {
                correct = 0;

                if (nombreCache < essai)
                {
                    Console.WriteLine("Trop grand !");
                    compteur += 1;
                }
                else 
                {
                    Console.WriteLine("Trop petit");
                    compteur += 1;
                }
                gestionSaisie();

            }
            Console.WriteLine("Bien joué ! Vosu avez trouvez le nombre caché "+"("+nombreCache+")");
            Console.WriteLine($"Vous avez trouvé le nombre en {compteur} essai");

            Console.ReadLine(); 
        }
    }
}
