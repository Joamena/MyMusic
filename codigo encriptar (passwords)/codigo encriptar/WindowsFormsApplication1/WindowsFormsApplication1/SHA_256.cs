using System;
using System.Collections.Generic;
using System.IO;//!!!!!!
using System.Linq;
using System.Security.Cryptography;//!!
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SHA_256
    {
        //----------------------CALCULANDO SHA256----------------------//
        //UTILIZAR SEMILLA UNICA (OBTENIDA YA SEA DEL USER TAMBIEN O LA FECHA DE NACIMIENTO)

        public string GetSHA_256(string ptext)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] message = UE.GetBytes(ptext);

            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            hashValue = hashString.ComputeHash(message);
            foreach (byte byteX in hashValue)
            {
                hex += String.Format("{0:x2}", byteX);
            }
            return hex;
        }

        //----------------------IMPRIMIR MSJ CONSOLA----------------------//
        public static void PrintByteArray(String pmsj )
        {
            Console.Write(pmsj);
            Console.WriteLine();
        }


    }
}
