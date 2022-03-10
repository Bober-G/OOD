using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Iteration
    {
        public static void BFS(DummyNode root)
        {
            var cur = root.FirstChild;
           
            if (cur.Next != null)
            {
                while (cur.Next != null)
                {
                    Console.WriteLine(cur.GetPrintableName());
                    if (!cur.IsDir())
                        Console.WriteLine(cur.GetPrintableContent());
                    cur = cur.Next;
                }
            }
            Console.WriteLine(cur.GetPrintableName());
            
            if (!cur.IsDir())
                Console.WriteLine(cur.GetPrintableContent());
            
            cur = root.FirstChild;
           
            if (cur.Next != null)
            {
                while (cur.Next != null)
                    if (cur.IsDir())
                   {
                        BFS((DummyDirectory)cur);
                        cur = cur.Next;
                   }
            }
           
            if (cur.IsDir())
            {
                BFS((DummyDirectory)cur);
            }

        }
       
        public static void DFS(DummyDirectory root)
        {
            var cur = root.FirstChild;
            
            if (cur.Next != null)
                while (cur.Next != null)
                {
                    printTransformedDFS(cur);
                    if (cur.IsDir())
                    {
                        DFS((DummyDirectory)cur);
                        cur = cur.Next;
                    }
                }
            
            printTransformedDFS(cur);
            if (cur.IsDir())
            {
                DFS((DummyDirectory)cur);
            }
        }

        public static void printTransformedDFS(DummyNode root)
        {
            string name = root.GetPrintableName();
            name = Transform.depth(root, name);
            Console.WriteLine(name);

            if (!root.IsDir())
            {
                string[] s = name.Split('.');
                string ext = s[s.Length - 1];
                string str = root.GetPrintableContent();
                str = Transform.removeHypens(str);

                if (ext != "cipher")
                    str = Transform.newLine(str);
                else
                    str = Transform.cipher(str);
                Console.WriteLine(str);
            }
        }
    }
}
