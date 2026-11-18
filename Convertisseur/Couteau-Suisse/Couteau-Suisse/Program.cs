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
            ConvertisseurMorse Morse = new ConvertisseurMorse();

            Morse.ConvertirEnMorse();
        }
    }
}
