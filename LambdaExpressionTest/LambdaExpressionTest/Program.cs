using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("Vaibhav");
            name.Add("srivastava");

            string result = name.Find(SearchName);

            if (result == null)
            {
                Console.WriteLine("Name not found ...");
            }
            else
                Console.WriteLine("Name found");
        }

        public static bool SearchName(string name)
        {
            return name.Equals(name);
        }

        
    }
}
