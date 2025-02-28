using System;

namespace ErvLemqadem_MasterMind
{
    internal class Program
    {
        static string exitBoutton;
        static int [] colors = {1,2,3,4,5,6};
        static int[] combination;


        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                
                string UserChoice;
                Menu();// Affiche le menu
                try
                {
                    UserChoice = Console.ReadLine();// Récupère l'entrée utilisateur dans le Main
                    if (UserChoice == "1")//si l'utilisateur appuie sur "1", cela le renvoi à la méthode qui habrite le jeu
                    {
                        Game();
                    }

                    if (UserChoice == "2")// si l'utilisateur appui sur "2", cela le renvoi à la méthode avec les règles du jeu
                    {
                        GameRule();
                    }

                }
                catch
                {
                    run = false;
                    Console.WriteLine("Erreur, choisissez une option valide.");

                }
            }
        }

        static void GameRule()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t╔═══════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t║           Règles du               ║");
            Console.WriteLine("\t\t\t\t\t║           MASTERMIND              ║");
            Console.WriteLine("\t\t\t\t\t╚═══════════════════════════════════╝");
            Console.CursorTop = 9;
            Console.WriteLine("Le mastermind est un jeu de société de déduction dont Le but est de deviner, par déductions successives," +
                " la couleur et la position de la combinaison secrète 4 pions cachés en 5 essais." +
                " Après chaque tentative, si un ▲ s'affiche, c'est qu'une couleur est correcte et bien placée, et si un ◘ s'affiche, c'est que la couleur est correcte mais mal placée.");
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
            Console.WriteLine("veuillez entrer un combinaison de 4 couleurs");
            Console.WriteLine("Les couleurs à mettre dans les cases:\r\n1 = Blanc\r\n2 = Bleu\r\n3 = Rouge\r\n4 = Vert\r\n5 = Jaune\r\n6 = Noir");

        }
    }
}

