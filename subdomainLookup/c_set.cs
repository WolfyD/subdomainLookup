using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subdomainLookup
{
    class c_set
    {
        public static void setupCharset(int set, out string chars, out int len)
        {

            switch (set)
            {
                case 1:
                    chars = "abcdefghijklmnopqrstuvwxyz";
                    len = 26;
                    break;

                case 2:
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    len = 26;
                    break;

                case 3:
                    chars = "0123456789";
                    len = 10;
                    break;

                case 4:
                    chars = "abcdefghijklmnopqrstuvwxyz0123456789";
                    len = 36;
                    break;

                case 5:
                    chars = "abcdefghijklmnopqrstuvwxyz0123456789-._:/?@,;=";
                    len = 36;
                    break;

                case 6:
                    chars = "abcdefghijklmnopqrstuvwxyz0123456789-._~:/?#[]@!$&'()*+,;=";
                    len = 62;
                    break;

                default:
                    chars = "";
                    len = 0;
                    break;
            }
        }

        public static void updateArray(int[] charsInt, int currentLen)
        {
            charsInt = new int[currentLen];
            for (int i = 0; i < currentLen; i++)
            {
                charsInt[i] = 1;
            }
        }

        public static void updateSet(int[] charsInt, int currentLen, out int newCurrentLen, int len, string currentSet, out string newCurrentSet, string chars)
        {
            for (int i = currentLen; i > 0; i--)
            {
                while (i > 0 && charsInt[i - 1] == len)
                {
                    charsInt[i - 1] = 1;
                    i--;
                }

                if (i > 0) { charsInt[i - 1]++; break; }
                else { currentLen++; updateArray(charsInt, currentLen); break; }
            }

            newCurrentLen = currentLen;

            currentSet = "";
            foreach (int i in charsInt)
            {
                try { currentSet += chars[i - 1]; } catch { }
            }

            newCurrentSet = currentSet;
        }
    }
}
