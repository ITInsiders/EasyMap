using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EM
{
    public class Helper
    {
        private static Helper instance = null;
        public static Helper Instance => instance ?? (instance = new Helper());



        public static string CodeGeneration(int Size = 6, string ABC = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")
        {
            string Code = "";
            Random R = new Random();
            R.Next();
            for (int i = 0; i < Size; ++i) Code += ABC[R.Next(0, ABC.Length)];
            return Code;
        }
    }
}