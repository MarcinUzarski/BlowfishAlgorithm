using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowfishAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods.hexConvert("01000011101100110010100001100010");
            var cipherText = string.Empty;
            Console.Write("Podaj treść do zaszyfrowania: ");
            var inputTxt = Console.ReadLine();
            Console.Write("Podaj klucz do szyfrowania: ");
            var key = Console.ReadLine();

            Methods.generateKey(Methods.ConvertKey(key));
            inputTxt = Methods.ConvertInputText(inputTxt);

            while (inputTxt.Length != 0)
            {
                if (inputTxt.Length < 16)
                    inputTxt = inputTxt.PadLeft(16, '0');
                cipherText += Methods.encrypt(inputTxt.Substring(0, 16));
                inputTxt = inputTxt.Remove(0, 16);
            }



            Console.Write("Zaszyfrowana wiadomość: {0}", cipherText);
            Console.ReadLine();


        }


    }
}
