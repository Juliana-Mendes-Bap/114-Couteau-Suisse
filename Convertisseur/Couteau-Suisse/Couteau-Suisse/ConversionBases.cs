using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Couteau_Suisse
{
    internal class ConversionBases
    {
        int intNombreUtilisateur;       // Reprend l'entrée de l'utilisateur pour le chiffre a convertir
        string strNombreUtilisateur;    // 
        public void ChoisirTypeConversion()
        {
            Console.WriteLine("=== Convertisseur de bases ===");
            Console.WriteLine("1. Décimal > Binaire");
            Console.WriteLine("2. Binaire > Décimal ");
            Console.WriteLine("3. Binaire > Octal");
            Console.WriteLine("4. Octal > Binaire");
            do
            {
                Console.Write("\nVeuillez entrer votre choix : ");
                string entreeUtilisateur = Console.ReadLine();

                if (Regex.IsMatch(entreeUtilisateur, "[^1-6]"))
                {
                    Console.WriteLine("Entrée invalide! Ressayer.\n");
                }
                else
                {
                    switch (entreeUtilisateur)
                    {
                        case "1":
                            Console.Clear();
                            ConvertirDe10a2();
                            break;
                        case "2":
                            Console.Clear();
                            ConvertirDe2a10();
                            break;
                        case "3":
                            Console.Clear();
                            ConvertirDe2a8();
                            break;
                        case "4":
                            Console.Clear();
                            ConvertirDe8a2();
                            break;
                    }
                }
            }
            while (true);
        }
        public void ConvertirDe10a2()
        {
            int binaire;                    //
            char[] binaireArray;            //
            string binaireResultat = "";    //

            do
            {
                Console.Write("Entrez un nombre en décimal : ");
                intNombreUtilisateur = Convert.ToInt32(Console.ReadLine());
                if (Regex.IsMatch(Convert.ToString(intNombreUtilisateur), "[^0-9]") || !Regex.IsMatch(strNombreUtilisateur, "[^a-z]") || !Regex.IsMatch(strNombreUtilisateur, "[^A-Z]"))
                {
                    Console.WriteLine("Entrée invalide! Ressayer.\n");
                }
                else
                {
                    while (intNombreUtilisateur > 0)
                    {
                        binaire = intNombreUtilisateur % 2;
                        binaireResultat += binaire;
                        intNombreUtilisateur = intNombreUtilisateur / 2;
                    }

                    // L'algorithm rend un binaire inversé, nous allons le remettre normal
                    // Il est stocker dans un Array pour l'inversé après
                    binaireArray = binaireResultat.ToCharArray();
                    Array.Reverse(binaireArray);
                    binaireResultat = new string(binaireArray);
                    Console.WriteLine($"Résultat en binaire : {binaireResultat}");
                    ContinuerProgram();
                }
            } while (true);
        }
        public void ConvertirDe2a10()
        {
            int valeurDecimal = 0;  // Le résultat de la conversion
            do
            {
                Console.Write("Entrez un nombre en binaire : ");
                strNombreUtilisateur = Console.ReadLine();
                if (Regex.IsMatch(strNombreUtilisateur, "[^0-1]") || !Regex.IsMatch(strNombreUtilisateur, "[^a-z]") || !Regex.IsMatch(strNombreUtilisateur, "[^A-Z]"))
                {
                    Console.WriteLine("Entrée invalide! Ressayer.\n");
                }
                else
                {
                    char[] array = strNombreUtilisateur.ToCharArray();
                    // Inverser puisque c'est 16-8-4-2-1 et pas 1-2-4-8-16
                    Array.Reverse(array);

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == '1')
                        {
                            if (i == 0)
                            {
                                valeurDecimal += 1;
                            }
                            else
                            {
                                valeurDecimal += (int)Math.Pow(2, i);
                            }
                        }
                    }
                    Console.WriteLine($"Résultat en décimal : {valeurDecimal}");
                    ContinuerProgram();
                }
            } while (true);
        }
        public void ConvertirDe2a8()
        {  
            int modulo;             // 
            int division;           //
            char[] nombreBinaire;   //
            char[] nombreOctal;     //
            string valeurOctal;     //
            do
            {
                Console.Write("Entrez un nombre en binaire : ");
                strNombreUtilisateur = Console.ReadLine();

                if (Regex.IsMatch(strNombreUtilisateur, "[^0-1]") || !Regex.IsMatch(strNombreUtilisateur, "[^a-z]") || !Regex.IsMatch(strNombreUtilisateur, "[^A-Z]"))
                {
                    Console.WriteLine("Entrée invalide! Ressayer.\n");
                }
                else
                {
                    modulo = strNombreUtilisateur.Length % 3;
                    strNombreUtilisateur = new string('0', 3 - modulo) + strNombreUtilisateur;

                    division = strNombreUtilisateur.Length / 3;
                    nombreBinaire = strNombreUtilisateur.ToCharArray();
                    Console.WriteLine(nombreBinaire);
                    nombreOctal = new char[division];
                    for (int i = 0; i < division; i++)
                    {
                        int digit = nombreBinaire.Skip(3 * i).Take(3).Aggregate(0,
                            (x, v) => (int)v - (int)'0' + 2 * x);
                        // x is the value accumulation
                        // v is a char '0' or '1' representing a bit and is converted to int 0, 1
                        nombreOctal[i] = (char)(digit + (int)'0');
                        // convert int to char digit
                    }
                    valeurOctal = new string(nombreOctal);
                    Console.WriteLine($"Résultat en octal : {valeurOctal}");
                    ContinuerProgram();
                }
            }
            while (true);
        }
        public void ConvertirDe8a2()
        {
            int p = 1;  // Declaration of variables
            int dec = 0, i = 1, j, d;
            int binaire = 0;

            do
            {
                Console.Write("Entrez un nombre en octal : ");
                intNombreUtilisateur = Convert.ToInt32(Console.ReadLine());
                if (Regex.IsMatch(Convert.ToString(intNombreUtilisateur), "[^0-9]") || !Regex.IsMatch(strNombreUtilisateur, "[^a-z]") || !Regex.IsMatch(strNombreUtilisateur, "[^A-Z]"))
                {
                    Console.WriteLine("Entrée invalide! Ressayer.\n");
                }
                else
                {
                    // Converting the octal number to its decimal equivalent
                    for (j = intNombreUtilisateur; j > 0; j = j / 10)
                    {
                        d = j % 10;
                        if (i == 1)
                            p = p * 1;
                        else
                            p = p * 8;

                        dec = dec + (d * p);
                        i++;
                    }

                    /* Converting the obtained decimal equivalent to its binary representation */
                    i = 1;
                    for (j = dec; j > 0; j = j / 2)
                    {
                        binaire = binaire + (dec % 2) * i;
                        i = i * 10;
                        dec = dec / 2;
                    }
                    Console.WriteLine($"Résultat en binaire : {binaire}");
                    ContinuerProgram();
                }
            } while (true);
        }
        public void ContinuerProgram()
        {
            do
            {
                Console.WriteLine("\n\nVoulez vous continuer a convertir? (O/N) : ");
                string entreeUser = Console.ReadLine().ToUpper();

                switch (entreeUser)
                {
                    case "O":
                        do
                        {
                            Console.WriteLine("Voulez vous changer de type de conversion? (O/N) : ");
                            string entreeUtilisateur = Console.ReadLine().ToUpper();
                            switch (entreeUtilisateur)
                            {
                                case "O":
                                    Console.Clear();
                                    Program.ChoisirConvertisseur();
                                    break;
                                case "N":
                                    Console.Clear();
                                    ChoisirTypeConversion();
                                    break;
                            }
                        }
                        while (true);
                    case "N":
                        Environment.Exit(0);
                        break;
                }
            }
            while (true);
        }
    }
}
