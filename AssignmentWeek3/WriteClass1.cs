using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentWeek3
{
    internal class WriteClass1
    {
        public static void Main(string[] args)
        {
           
            string filePath = "C:\\CSharp\\input.txt";
            string Containfile = "test write";
            File.WriteAllText(filePath, Containfile);
            
        }
    }
}
