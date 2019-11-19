using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_39
{
    public delegate void SampleDelegate();
    public delegate int SampleReturnDelegate();
    public delegate void SampleOutDelegate(out int integer);


    class Program
    {
        static void Main(string[] args)
        {
            // A.
            // THIS WILL WORK WHEN THE DELEGATES HAS A VOID TYPE AND BASED ON THAT 
            // MEANS ALL THE METHODS REALTED TO THAT DELEGATES IS SAME TYPE

            // B. 
            // WHEN THE METHODS/DELEGEATES HAS A RETURN TYPE THE LAST VALUE WILL BE RETRIEVED 


            //----------------------------------A---------------------------------

            Console.WriteLine("-----------------A-------------------");
            // ------------------------------ WAY NR 1 --------------------------------------
            // ------------------------ MULTICASR DELEGATES ---------------------------------
            SampleDelegate del1, del2, del3, del4;

            // This Delegate is attached to SampleMethodOne
            del1 = new SampleDelegate(SampleMethodOne);
            // This Delegate is attached to SampleMethodTwo
            del2 = new SampleDelegate(SampleMethodTwo);
            // This Delegate is attached to SampleMethodThree
            del3 = new SampleDelegate(SampleMethodThree);
            // This Delegate is attached to SampleMethodOne + SampleMethodTwo + SampleMethodThree
            del4 = del1 + del2 + del3 ; // + is to add(register) a method with DELEGTES
                                        // - is to delete(unregister) a method with DELEGTES

            // this delegate calling multi methods
            del4();


            // ------------------------------ WAY NR 2 --------------------------------------
            // ------------------------ MULTICASR DELEGATES ---------------------------------
            // there is no need to build multi delegates

            // You need to attach this delegare to one method at start
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            // += is to add(register) a method with DELEGTES
            // -= is to delete(unregister) a method with DELEGTES 
            del += SampleMethodTwo;
            del += SampleMethodThree;
            Console.WriteLine("------------------------------------------");
            del();


            //----------------------------------B---------------------------------
            // INT METHODS
            SampleReturnDelegate delegate1, delegate2, delegate3;
            delegate1 = new SampleReturnDelegate(SampleReturnMethodOne);
            delegate2 = new SampleReturnDelegate(SampleReturnMethodTwo);

            delegate3 = delegate1 + delegate2;
            delegate3();
            Console.WriteLine("***************************************************");
            Console.WriteLine("-----------------B-------------------");
            Console.WriteLine("---INT METHODS---");
            Console.WriteLine(delegate3());


            // OUT METHODS
            Console.WriteLine("---OUT METHODS---");
            SampleOutDelegate DelOut;
            DelOut = new SampleOutDelegate(SampleOutOne);
            int delegateOutputParameter = -1;
            DelOut += SampleOutTwo;
            DelOut(out delegateOutputParameter);
            Console.WriteLine("The ouput variable is:{0}",delegateOutputParameter);

        }

        //----------------------------------A---------------------------------

        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodone invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree invoked");
        }

        //----------------------------------B---------------------------------
        // INT METHODS
        public static int SampleReturnMethodOne()
        {
            return 1;
        }
        public static int SampleReturnMethodTwo()
        {
            return 2;
        }

        // OUT METHODS
        public static void SampleOutOne(out int varible1)
        {
            varible1 = 1;
        }
        public static void SampleOutTwo(out int varible2)
        {
            varible2 = 2;
        }


    }
}
