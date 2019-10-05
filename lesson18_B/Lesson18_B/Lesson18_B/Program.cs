using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace Lesson18_B
{
    // THIS PROJECT CONATINS C# CLASS LIBRARY (.DLL) FILES AND CONNECT THE MAIN PROJECT TO OTHER PROJECTS(CLASS LIBRARY)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MAIN METHOD");
            Console.WriteLine("---------------");
            PATA.ClassA.print();

            Console.WriteLine("-------CALLING IN TWO WAYS--------");
            PATB.ClassA.print();
            // we can call the methid in other way
            ProjectA.TeamB.ClassA.print();
        }
    }
}
