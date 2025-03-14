using System;

namespace ErvLemqadem_MasterMind
{
    internal class Program
    {
        static string exitBoutton;//variable pour bouton exit
        static int[] combination = new int[4];//combinaison de couleurs
        static int attempts = 10; // Nombre d'essais


        static void Main(string[] args)
        {
            bool run = true;//variable 
            while (run)// boucle qui va se stopper si l'entrée de l'utilisateur n'est pas valide
            {
                string UserChoice;//variable qui stocke l'entrée de l'utilisateur pour consulter les règles du jeu ou pour jouer directement 
                Console.Clear();// effacer la console
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
            Console.WriteLine("Le mastermind est un jeu de société de déduction dont Le but est de deviner, par déductions successives," +//
                " la couleur et la position de la combinaison secrète 4 pions cachés en 10 essais." +                                     //règles du jeu
                " Après chaque tentative, il sera affiché si des couleurs sont bien placés ou si elles sont mal placé mais correctes");   //
            Console.CursorTop = 15;
            Console.WriteLine("Appuyez sur 1 pour revenir au menu principal");


            try//si l'utilisateur entre 1-> le faire retourner au menu

            {
                exitBoutton = Console.ReadLine();
                if (exitBoutton == "1")
                {
                    return;
                }
            }

            catch//si on entre qqch d'autres--> message erreur

            {
                Console.WriteLine("Erreur, choisissez une option valide.");

            }

        }
        /// <summary>
        /// méthode qui affiche le titre
        /// </summary>
        static void Title()
        {
            Console.WriteLine("\t\t\t\t\t╔═══════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t║ Bienvenue dans le jeu MASTERMIND  ║");
            Console.WriteLine("\t\t\t\t\t║     réalisé par Ervan Lemqadem    ║");
            Console.WriteLine("\t\t\t\t\t╚═══════════════════════════════════╝");
            Console.WriteLine("");
        }
        /// <summary>
        /// méthode contenant l'inteface graphique du menu
        /// </summary>
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
        /// <summary>
        /// méthode contenant le jeu
        /// </summary>
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


            for (int attempt = 1; attempt <= attempts; attempt++) // boucle qui compte les 10 essais
            {
                Console.WriteLine($"\nEssai {attempt}/10 : Veuillez entrer une combinaison de 4 chiffres (séparés par des espaces) :");

                string input = Console.ReadLine();//entrée de l'utilisateur
                string[] parts = input.Split();//variable qui va stocker sous forme de texte l'entrée de lutilisateur
                int[] guess = new int[4];// variable qui va sotcker sous forme de nombre l'entrée de l'utilisateur

                // boucle qui va afficher un message d'erreur si l'entrée n'est pas valide
                if (parts.Length != 4)
                {
                    Console.WriteLine("Entrée invalide. Entrez 4 chiffres entre 1 et 6.");
                    attempt--; // Ne pas compter cet essai
                    continue;
                }


                bool valid = true;
                for (int i = 0; i < 4; i++)//boucle qui va verifier que l'entrée est entre 1 et 6

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


                if (!valid)// si l'entrée de l'utilisateur n'est pas composé de nombrs en 1 et 6--> afficher un message d'erreur et ne pas compter l'essai

                {
                    Console.WriteLine("Entrée invalide. Entrez 4 chiffres entre 1 et 6.");
                    attempt--; // Ne pas compter cet essai
                    continue;
                }

                // Affichage de la combinaison saisie
                Console.WriteLine("╔═══╦═══╦═══╦═══╗");                                     //
                Console.WriteLine($"║ {guess[0]} ║ {guess[1]} ║ {guess[2]} ║ {guess[3]} ║");//affichages de la combinaison entrée par l'utilisateur dans le quadrillage
                Console.WriteLine("╚═══╩═══╩═══╩═══╝");                                     //
                int correctPosition = 0;//variable qui compte les chiffres justes et bien placé 
                int correctNumber = 0;// variable qui compte les chiffres justes mais mal placé
                bool[] checkedSecret = new bool[4]; // variable qui Indique si une position de la combinaison secrète a déjà été utilisée.
                bool[] checkedGuess = new bool[4];//variable qui compte si un chiffre de l'entré de l'utilisateur a déjà été vérifié pour eviter qu'un chiffre soit 2 fois compté dans la variable correctposition

                // boucle qui verifie si des chiffres sont justes et bien placé
                for (int i = 0; i < 4; i++)
                {
                    if (guess[i] == combination[i])//si un nombre proposé est correct
                    {
                        correctPosition++;//ajouter 1 a la variable qui compte les numeros bien placés et corrects
                        checkedSecret[i] = true;//la position utilisé va se sotocker dans la variable pour eviter de répeter 2fois le meme chiffre
                        checkedGuess[i] = true;//variable qui indique si une position de l'entrée utilisateur a déjà été verifié
                    }
                }

                // boucle qui verifie si des chiffres sont justes mais mal placé
                for (int i = 0; i < 4; i++)
                {
                    if (!checkedGuess[i])//ignorer les chiffres déjà bien placé 
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (!checkedSecret[j] && guess[i] == combination[j])//si un chiffre est correct mais mal placé
                            {
                                correctNumber++;// ajouter 1 a la variable des nombres justes mais mal placé
                                checkedSecret[j] = true;//la position utilisé va se sotocker dans la variable pour eviter de répeter 2fois le meme chiffre
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine($"Résultat : {correctPosition}  correctes et bien placés, {correctNumber}  correctes et mal placés.");//affichage du nombres de chiffres justes et bien placé et le nombre de chiffres correctes mais mal placé

                if (correctPosition == 4)//si la combinaison complète est trouvée
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Félicitations ! Vous avez trouvé la combinaison secrète !");// affichage du message de reussite
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("LE JEU EST TERMINE ---> tapez sur n'importe quelle touche pour quitter le jeu");//affichage de la fin du jeu + proposition de rejouer
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);

                    
                    
                }

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nDésolé, vous avez épuisé tous vos essais. La combinaison secrète était : {string.Join(" ", combination)}");//quand les 10 essai passés, afficher solution combinaison
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LE JEU EST TERMINE ---> tapez 1 si vous voulez retourner au menu, tapez une touche quelconque pour quitter le jeu");//affichage de la fin du jeu + proposition de rejouer
            Console.ResetColor();
            string restartBoutton = Console.ReadLine();//variable qui stocke l'entrée de l'utilisateur pour rejouer ou quitter le jeu


            if (restartBoutton == "1") // Si l'utilisateur appuie sur "1", cela le renvoie à la méthode qui héberge le jeu
            {
                Menu();//redirection vers la methode de jeu 
            }
            else//si l'utilisateur clique sur une autre touche--> quitter le jeu
            {
                Environment.Exit(0);
            }



        }
    }
}







