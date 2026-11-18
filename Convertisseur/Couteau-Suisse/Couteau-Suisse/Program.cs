using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couteau_Suisse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChoisirConvertisseur();
        }

        public static void ChoisirConvertisseur()
        {
            ConvertisseurMorse Morse = new ConvertisseurMorse();
            ConversionBases Bases = new ConversionBases();

            Console.WriteLine("=== Couteau Suisse – Utilitaires ===");
            Console.WriteLine("1. Convertir du texte en code Morse");
            Console.WriteLine("2. Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal)");
            Console.WriteLine("3. (à venir)");
            do
            {
                Console.Write("Veuillez entrer votre choix : ");
                string entreeUtilisateur = Console.ReadLine();

                switch (entreeUtilisateur)
                {
                    case "1":
                        Console.Clear();
                        Morse.ConvertirEnMorse();
                        break;
                    case "2":
                        Console.Clear();
                        Bases.test();
                        break;
                }
            }
            while (true);
        }
    }
}
