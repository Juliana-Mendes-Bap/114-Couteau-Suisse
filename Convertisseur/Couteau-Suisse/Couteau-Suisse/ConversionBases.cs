using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couteau_Suisse
{
    internal class ConversionBases
    {
        int nombreConverti = 10;
        public void ChoisirTypeConversion()
        {
            Console.WriteLine("=== Convertisseur de bases ===");
            Console.WriteLine("1. Décimal > Binaire");
            Console.WriteLine("2. Binaire > Décimal ");
            Console.WriteLine("3. Binaire > Octal");
            Console.WriteLine("4. Octal > Binaire");
            do
            {
                Console.Write("Veuillez entrer votre choix : ");
                string entreeUtilisateur = Console.ReadLine();

                if(entreeUtilisateur == "")
                {
                    Console.WriteLine("Entrée invalide! Ressayer.\n");
                }
                else 
                {
                    Console.WriteLine($"\nRésultat de la conversion en code morse :\n{nombreConverti}");
                }

                switch (entreeUtilisateur)
                {
                    case "1":
                        Convertisseur10à2();
                        break;
                    case "2":
                        Convertisseur2à10();
                        break;
                    case "3":
                        Convertisseur2à8();
                        break;
                    case "4":
                        Convertisseur8à2();
                        break;
                }
            }
            while (true);
        }

        public int Convertisseur10à2()
        {
            return nombreConverti;
        }
        public int Convertisseur2à10()
        {
            return nombreConverti;
        }
        public int Convertisseur2à8()
        {
            return nombreConverti;
        }
        public int Convertisseur8à2()
        {
            return nombreConverti;
        }
        public void test()
        {
            /*string number = "100";
            int fromBase = 8;
            int toBase = 2;

            string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);

            Console.WriteLine(result);*/
        }
    }
}
