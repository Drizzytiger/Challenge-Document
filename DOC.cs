using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.WriteLine("What is the name of your document?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the context of your document?");
            string context = Console.ReadLine();
            int num = 0;
            foreach(char c in context)
            {
                if(char.IsLetter(c))
                {
                    num++;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter("name.txt");
                sw.WriteLine(name + " " + context);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!Error!Failed process!"+ e.Message);
            }
            finally
            {
                Console.WriteLine("File {0} was saved, it has {1} characters in its information",name,num);
            }
            Console.ReadKey();
        }
    }
}
