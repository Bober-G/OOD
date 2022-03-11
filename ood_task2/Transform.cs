using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Transform
    {
        public static string depth(DummyNode node, string s)
        {
            string str = "|"; 
            while (node.Parent != null)
            {
                str += "-";
                node = node.Parent;
            }
            str += s;
            return str;
        }

        public static string removeHypens(string s)
        {
            return s.Replace("-", string.Empty);
        }

        public static string newLine(string s)
        {
            return s += '\n';
        }

        public static string cipher(string s)
        {
            string str = string.Empty;
            reverseString(s);
            foreach (char c in s)
            {
                int copyString = c - 25;

                str = (char)copyString + str;

            }
            return str;
        }
        public static string reverseString(string s)
        {
            char[] c = s.ToCharArray();
            char[] res = new char[c.Length];
            for(int i = 0, j = s.Length-1; i < s.Length; i++, j--)
            {
                res[i] = c[j]; 
            }
            return new string(res);
        }
    }
}

