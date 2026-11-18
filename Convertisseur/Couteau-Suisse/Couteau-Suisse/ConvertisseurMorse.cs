using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couteau_Suisse
{
    internal class ConvertisseurMorse
    {
        string phraseAConvertir;

        public void ConvertirEnMorse()
        {
            do
            {
                Console.Write("Entrez le texte que vous voulez convertir : ");
                string entreeDUtilisateur = Console.ReadLine();
                entreeDUtilisateur = entreeDUtilisateur.Normalize(NormalizationForm.FormD);
                var texteNormal = entreeDUtilisateur.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
                string texteMajuscule = new string(texteNormal).Normalize(NormalizationForm.FormC).ToUpper();
                string convertirPhrase = AjouterCodeMorse(texteMajuscule);
                if (entreeDUtilisateur == "")
                {
                    Console.WriteLine("Entrée invalide! Ressayer.\n");
                }
                else
                {
                    Console.WriteLine($"\nRésultat de la conversion en code morse :\n{phraseAConvertir}");
                    Environment.Exit(0);
                }
            }
            while (true);
        }

        public string AjouterCodeMorse(string entreeUtilisateur)
        {
            foreach (var letter in entreeUtilisateur)
            {
                switch (letter)
                {
                    case 'A':
                        phraseAConvertir += ".-";
                        break;
                    case 'B':
                        phraseAConvertir += "-...";
                        break;
                    case 'C':
                        phraseAConvertir += "-.-.";
                        break;
                    case 'D':
                        phraseAConvertir += "-..";
                        break;
                    case 'E':
                        phraseAConvertir += ".";
                        break;
                    case 'F':
                        phraseAConvertir += "..-.";
                        break;
                    case 'G':
                        phraseAConvertir += "--.";
                        break;
                    case 'H':
                        phraseAConvertir += "....";
                        break;
                    case 'I':
                        phraseAConvertir += "..";
                        break;
                    case 'J':
                        phraseAConvertir += ".---";
                        break;
                    case 'K':
                        phraseAConvertir += "-.-";
                        break;
                    case 'L':
                        phraseAConvertir += ".-..";
                        break;
                    case 'M':
                        phraseAConvertir += "--";
                        break;
                    case 'N':
                        phraseAConvertir += "-.";
                        break;
                    case 'O':
                        phraseAConvertir += "---";
                        break;
                    case 'P':
                        phraseAConvertir += ".--.";
                        break;
                    case 'Q':
                        phraseAConvertir += "--.-";
                        break;
                    case 'R':
                        phraseAConvertir += ".-.";
                        break;
                    case 'S':
                        phraseAConvertir += "...";
                        break;
                    case 'T':
                        phraseAConvertir += "-";
                        break;
                    case 'U':
                        phraseAConvertir += "..-";
                        break;
                    case 'V':
                        phraseAConvertir += "...-";
                        break;
                    case 'W':
                        phraseAConvertir += ".--";
                        break;
                    case 'X':
                        phraseAConvertir += "-..-";
                        break;
                    case 'Y':
                        phraseAConvertir += "-.--";
                        break;
                    case 'Z':
                        phraseAConvertir += "--..";
                        break;
                    case '0':
                        phraseAConvertir += "-----";
                        break;
                    case '1':
                        phraseAConvertir += ".----";
                        break;
                    case '2':
                        phraseAConvertir += "..---";
                        break;
                    case '3':
                        phraseAConvertir += "...--";
                        break;
                    case '4':
                        phraseAConvertir += "....-";
                        break;
                    case '5':
                        phraseAConvertir += ".....";
                        break;
                    case '6':
                        phraseAConvertir += "-....";
                        break;
                    case '7':
                        phraseAConvertir += "--...";
                        break;
                    case '8':
                        phraseAConvertir += "---..";
                        break;
                    case '9':
                        phraseAConvertir += "----.";
                        break;
                    case ' ':
                        phraseAConvertir += "/";
                        break;
                    default:
                        break;
                }
                phraseAConvertir += " ";
            }
            return phraseAConvertir;
        }
    }
}
