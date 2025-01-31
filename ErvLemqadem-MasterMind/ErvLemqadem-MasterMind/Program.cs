using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErvLemqadem_MasterMind
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void GameRule()
        {
            Console.WriteLine("\t\t\t\t\t╔═══════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t║           Règles du               ║");
            Console.WriteLine("\t\t\t\t\t║           MASTERMIND              ║");
            Console.WriteLine("\t\t\t\t\t╚═══════════════════════════════════╝");
            Console.CursorTop = 9;
            Console.WriteLine("Le mastermind est un jeu de société de déduction dont Le but est de deviner, par déductions successives," +
                " la couleur et la position de la combinaison secrète 4 pions cachés en 5 essais" +
                " Après chaque tentative, si il y a un ▲ qui s'affiche, c'est qu'une couleur est correcte et bien placée et si un ◘ s'affiche c'est que la couleur est correcte mais mal placée");
            Console.ReadLine();


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
            Console.WriteLine("\n\n\n\n\t\t\t\t    Choisissez une option en appuyant sur 1 ou 2 ");
            string UserChoice = Console.ReadLine();


        }
    } 
}
