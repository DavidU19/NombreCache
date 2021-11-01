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
        static int gestionSaisie(string message)
        {
            int nombre = 0; 
            int correct = 0; 
            while (correct != 1)
            {
                try
                {
                    Console.Write(message + "= " );
                    nombre = int.Parse(Console.ReadLine()); // le nombre à chercher 
                    correct = 1;
                }
                catch
                {
                    Console.WriteLine("Vous avez fait une erreur de saisie, veuillez choisir un nombre entier ");
                }
            }
            return nombre; 
        }
        static void Main(string[] args)
        {
            int nombreCache = 0;
            int essai = 0;
            int compteur = 1;
           
            
            //tour du joueur 1
            nombreCache = gestionSaisie("Entrez le nombre caché"); // fonction 
            Console.Clear(); // permet d'effacer la console, pour que le deuxième joueur ne voit pas ce que le nombre du premier
            
            
            // tour du joueur 2
            essai = gestionSaisie("Entrez le nombre à chercher"); // fonction
            // test de comparaison entre le nombre caché et l'essai 
            while (nombreCache != essai)
            {
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
                essai = gestionSaisie("Entrez le nombre à chercher"); // fonction 

            }
            Console.WriteLine("Bien joué ! Vosu avez trouvez le nombre caché "+"("+nombreCache+")");
            Console.WriteLine($"Vous avez trouvé le nombre en {compteur} essai");

            Console.ReadLine(); 
        }
    }
}
