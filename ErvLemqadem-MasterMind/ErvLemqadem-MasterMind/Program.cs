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
            Console.WriteLine("LES REGLES DU MASTERMIND");

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
            Console.CursorTop = 7;
            Console.WriteLine("\t\t\t\t\t       ╔════════════════════╗");
            Console.WriteLine("\t\t\t\t\t       ║      1.JOUEUR      ║");
            Console.WriteLine("\t\t\t\t\t       ╚════════════════════╝");
            string UserChoice = Console.ReadLine();


        }
    } 
}
