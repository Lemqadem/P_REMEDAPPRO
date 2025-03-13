using System;

namespace ErvLemqadem_MasterMind
{
    internal class Program
    {
        static string exitBoutton;
        static int[] colors = { 1, 2, 3, 4, 5, 6 };//couleurs
        static int[] combination = new int[4];//combinaison de couleurs
        static int attempts = 10; // Nombre d'essais


        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                string UserChoice;
                Console.Clear();
                Menu(); // Affiche le menu
                try
                {
                    UserChoice = Console.ReadLine(); // Récupère l'entrée utilisateur dans le Main
                    if (UserChoice == "1") // Si l'utilisateur appuie sur "1", cela le renvoie à la méthode qui héberge le jeu
                    {
                        Game();//redirection vers la methode de jeu 
                    }

                    if (UserChoice == "2") // Si l'utilisateur appuie sur "2", cela le renvoie à la méthode avec les règles du jeu
                    {
                        GameRule();//redirection vers la methode contenant les règles du jeu
                    }
                }
                catch// si l'entrée de l'utilisateur est une chose autre, fin de la boucle while --> run devient false et affichage du message d'erreur
                {
                    run = false;
                    Console.WriteLine("Erreur, choisissez une option valide.");
                }
            }
        }

        /// <summary>
        ///methode contenant les règles du jeu
        /// </summary>
        static void GameRule()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t╔═══════════════════════════════════╗");//
            Console.WriteLine("\t\t\t\t\t║           Règles du               ║");//affichage du titre
            Console.WriteLine("\t\t\t\t\t║           MASTERMIND              ║");//
            Console.WriteLine("\t\t\t\t\t╚═══════════════════════════════════╝");//
            Console.CursorTop = 9;//placement 
            Console.WriteLine("Le mastermind est un jeu de société de déduction dont Le but est de deviner, par déductions successives," +
                " la couleur et la position de la combinaison secrète 4 pions cachés en 5 essais." +
                " Après chaque tentative, il sera affiché si des couleurs sont bien placés ou si elles sont mal placé mais correctes");
            Console.CursorTop = 15;
            Console.WriteLine("Appuyez sur 1 pour revenir au menu principal");

            try
            {
                exitBoutton = Console.ReadLine();
                if (exitBoutton == "1")
                {
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Erreur, choisissez une option valide.");
            }

        }

        static void Title()
        {
            Console.WriteLine("\t\t\t\t\t╔═══════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t║ Bienvenue dans le jeu MASTERMIND  ║");
            Console.WriteLine("\t\t\t\t\t║     réalisé par Ervan Lemqadem    ║");
            Console.WriteLine("\t\t\t\t\t╚═══════════════════════════════════╝");
            Console.WriteLine("");
        }

        static void Menu()
        {
            Title();
            Console.CursorTop = 9;
            Console.WriteLine("\t\t\t\t╔════════════════════╗");
            Console.WriteLine("\t\t\t\t║      1.JOUER       ║");
            Console.WriteLine("\t\t\t\t╚════════════════════╝");
            Console.CursorTop = 9;
            Console.WriteLine("\t\t\t\t\t\t\t\t╔════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t║  2.REGLES DU JEU   ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t╚════════════════════╝");
            Console.WriteLine("\n\n\n\n\t\t\t\t    Choisissez une option en appuyant sur 1, 2.");

        }
        static void Game()
        {
            Console.Clear();
            Title();
            Random rand = new Random();// génére des nombres aleatoires
            for (int i = 0; i < 4; i++)// boucle qui va remplir chaque case du tableau combinaison avec une valeur aleatoire
            {
                combination[i] = rand.Next(1, 7);
            }


            Console.WriteLine("Vous avez 10 essais pour deviner la combinaison secrète !");
            Console.WriteLine("Les couleurs à mettre dans les cases :");
            Console.WriteLine("1 = Blanc | 2 = Bleu | 3 = Rouge | 4 = Vert | 5 = Jaune | 6 = Noir");
            Console.WriteLine("╔═══╦═══╦═══╦═══╗");
            Console.WriteLine("║   ║   ║   ║   ║");
            Console.WriteLine("╚═══╩═══╩═══╩═══╝");

            for (int attempt = 1; attempt < 10; attempt++) // boucle pour les 10 essais
            {
                Console.WriteLine($"\nEssai {attempt}/10 : Veuillez entrer une combinaison de 4 chiffres (séparés par des espaces) :");
                Console.WriteLine("╔═══╦═══╦═══╦═══╗");
                Console.WriteLine("║   ║   ║   ║   ║");
                Console.WriteLine("╚═══╩═══╩═══╩═══╝");

                string input = Console.ReadLine();
                string[] parts = input.Split();
                int[] guess = new int[4];

                // Vérification de l'entrée
                if (parts.Length != 4)
                {
                    Console.WriteLine("Entrée invalide. Entrez 4 chiffres entre 1 et 6.");
                    attempt--; // Ne pas compter cet essai
                    continue;
                }

                bool valid = true;
                for (int i = 0; i < 4; i++)
                {
                    if (int.TryParse(parts[i], out int num) && num >= 1 && num <= 6)
                    {
                        guess[i] = num;
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }

                if (!valid)
                {
                    Console.WriteLine("Entrée invalide. Entrez 4 chiffres entre 1 et 6.");
                    attempt--; // Ne pas compter cet essai
                    continue;
                }

                // Affichage de la combinaison saisie
                Console.WriteLine("╔═══╦═══╦═══╦═══╗");
                Console.WriteLine($"║ {guess[0]} ║ {guess[1]} ║ {guess[2]} ║ {guess[3]} ║");
                Console.WriteLine("╚═══╩═══╩═══╩═══╝");
            }
        }
    }
}





