using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.TeamA;
// using ALIAS
using PATB = ProjectA.TeamB;
// this is ambigus behvaior
//using ProjectA.TeamB;


    // PART A of LESSON 18
namespace lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Main method ");
            Console.WriteLine("----------------------");
            // way one to call print method
            //ProjectA.TeamA.ClassA.print();

            //way 2 to call this 
            // add using "using ProjectA.TeamA;" to NAMESPACES declaration then 
            // print from teamA
           ClassA.print();

            // print from teamA
            // using fully qulaify names 
            ProjectA.TeamB.ClassA.print();


            /*we can use NAMESPACE ALIAS INSTEAD OF MAKING AMBIGUITY
             PATB = ProjectA.TeamB;
             */
            Console.WriteLine("Hello called via ALLIAS PATB ");
            PATB.ClassA.print();

             
        }
    }
}

namespace ProjectA
{
    // name space inside name space
    namespace TeamA
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("Team A print Method");
            }
        }
    }
}

namespace ProjectA
{
    // name space inside name space
    namespace TeamB
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("Team B print Method");
            }
        }
    }
}