using System;
    

    class Program
    {
        static void Main()
    {


        /**/    //Lesson1 

        /*------
        using write command
        Console.WriteLine("hello world");
        ------*/

        //Lesson2 

        /*------
        Console.WriteLine("Please enter your first name");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name");
        string LastName = Console.ReadLine();
        Console.WriteLine("Hello {0}, {1}", FirstName, LastName);
        ------*/

        /**/    //Lesson3 

        /*------
               int i;byte b; sbyte s;long l;short sh; ulong ul;ushort ush; float f; double d; decimal dec;
               ------*/

        /**/  //Lesson4 
              // showing the esacpe sequence how we can use backslash to print special characters e.g \" = showing "

        /*------
         string name = "\"Mouhammad\"\t Ali";
         string sign = "one \n two \n three ";
         // printing out special character using verbatim literal to make code more east to read insted of C:\\Program Files\\Common Files
         string path = @"C:\Program Files\Common Files";

         Console.WriteLine(sign);
         Console.WriteLine(path);
         ------*/


        /**/    //Lesson5 
                //Showing the common operators in C#  Assignment operator "=",Arithmetic operaters"+-/*% reminder(baki)", Comparsion operators "== != < <= > >=",
                // Conditional operators "&& ||" ,Ternary operator "?:", Null Coalescing operator "??"

        /* ------
        // Assignment operator "="
        int i = 5;
        
        //Arithmetic operaters"+-/*% reminder(baki)"
        int nominator = 10; int dominator = 2;
        int result = nominator / dominator;
        int remain = nominator % dominator;
        Console.WriteLine("The result is {0} and the reminder is {1}", result, remain);

        //Comparsion operators "== != < <= > >="
        if (i != 1)
        {
            Console.WriteLine("Hello");
        }
        // Conditional operators "&& ||"
        int number = 5; int otherNumber = 10;
        if( number == 5 && otherNumber != 15)
        {
            Console.WriteLine("Hello");
        }
        //Ternary operator "?:"
        int num = 10;
        bool Isnum10;
        if (num == 10)
        {
            Isnum10 = true;
        }
        else
        {
            Isnum10 = false;
        }
        Console.WriteLine("The number = 10 {0}", Isnum10);
        // the same code but used one statement with ternary opertator
        bool isnumber10 = num == 10 ? true : false;
        Console.WriteLine("The number = 10 {0}", isnumber10);
        ------*/


        /**/  //Lesson6 
              //Showing differences between Nullable types and reference types
              // ? is converting value types to null value like ARE YOU MAJOR Question ?
              // using opertators ?? null coalesing

        /*
                                                            // WAY nr 1
                                                            string namn = null;
                                                            int counter = 5;
                                                            int? i = null; // changing the value type to nullable 
                                                            bool? Gender = null; // this means that Gender can be a null value , ? before BOOL added null value besides TRUE or FALSE

                                                            if (Gender == true)
                                                            {
                                                                Console.WriteLine("You are Man");
                                                            }
                                                            else if (Gender == false)
                                                            {
                                                                Console.WriteLine("You are woman");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("User has not select any thing\n");
                                                            }

                                                            // WAY nr 2

                                                            int? TicketsonSale = 10000;
                                                            int NumberofTickets;
                                                            if (TicketsonSale == null)
                                                            {
                                                                Console.WriteLine("NumberofTickets is 0");
                                                            }
                                                            else 
                                                            {
                                                                NumberofTickets = (int)TicketsonSale; // this is correct because we convert nullable value to INT value
                                                                int NumberofTickets2 = TicketsonSale.Value; //THis is correct because we are using value method that return int value
                                                                Console.WriteLine("NumberofTickets is {0},",NumberofTickets);
                                                            }

                                                            // WAY nr 3

                                                            int? ticketsONSALE = null;
                                                            int availableTickets = ticketsONSALE ?? 0;
                                                            Console.WriteLine("NumberofTickets is ------{0}\n", availableTickets);




                                                            //------------------ TRUE and FALSE -------SHORT IF STATMENT
                                                            int number = 15;
                                                            bool isnumberequals10 = number == 10 ? true : false;
                                                            Console.WriteLine("Number is equals to 10 : {0}\n",isnumberequals10);
                                                              /* OTHER EXAMPLE
                                                            int? Ticketsonsale = null;
                                                            int AvaailableTickets = Ticketsonsale ?? 0 ;

                                                            bool? gender = null;
                                                            bool man = gender ?? true;
                                                            Console.Write("{0}\n\n", man);
                                                            */


        /**/  //Lesson7 
              //Data type conversion


        /*
                      int f = 112;
                      //this called implicit converter which happens automatically (small to bigger types)
                      float g = f;

                      float num = 1223222222223334.5332F;
                      // converting happens by using CAST() operator, this will not throw an exception with big values
                      int i = (Int32)num;
                      Console.WriteLine("i is {0}",i);
                      // Converting via convert class this will  throw an exception with big values
                      int gh = Convert.ToInt32(num);
                      Console.WriteLine("gh is {0}", gh);

        
                      string number = "100";
                      int result2;

                      // TRYPARSE method  returns a bool indicator if convertion succeeded or not
                      bool conversionResult = int.TryParse(number, out result2);
                      Console.WriteLine("Conversion result is for result2 is {0} and the result is {1}\n", conversionResult, result2);
                      Console.WriteLine(result2.GetType());
                      // PARSE method convert with throwing an exception when the data is incorrect
                      int result1 = int.Parse(number);
                      Console.WriteLine("Conversion result is for result1 is {0}\n", result1);
              */

        /**/  //Lesson8 
              //Arrays


        /*
                int[] oddNumbers = new int[3];
                oddNumbers[0] = 1;
                oddNumbers[1] = 3;
                oddNumbers[2] = 5;

                Console.WriteLine("Printing ODD Numbers");
                Console.Write("[");
                for (int i=0;i<oddNumbers.Length;i++)
                {
                    if (i != oddNumbers.Length-1)
                    Console.Write("{0} ",oddNumbers[i]);
                    else
                    {
                        Console.Write("{0}", oddNumbers[i]);
                    }
                }
                Console.WriteLine("]");

                int[] EvenNumber = { 2, 4, 6 };
                for (int i = 0; i <EvenNumber.Length; i++)
                {
                    Console.WriteLine(EvenNumber[i]);
                }
                */

        /**/  //Lesson9 
              //Comments

        /*
         sampleclass
/// <summary>
/// This is Sample class and documentation
/// </summary>
public class sampleclass
{

}
*/

        /**/  //Lesson10 
              //IF Statment
              /*
                      Console.WriteLine("Please enter a number");
                     string userInput = Console.ReadLine();
                      int userNumber = int.Parse(userInput);
                      int userNumberinput;

                         if(int.TryParse(userInput, out userNumberinput ) == true)
                          {

                      if (userNumber == 10)
                      {
                          Console.WriteLine("The number that you entered is 10");
                      }
                      else if (userNumber == 20)
                      {
                          Console.WriteLine("The number that you entered is 20");
                      }
                      else if (userNumber == 30)
                      {
                          Console.WriteLine("The number that you entered is 30");
                      }
                      else
                      {
                          Console.WriteLine("The number that you entered is not valid");
                      }


                      }
              */

        /**/  //Lesson11 
              //SWITCH Statment

        /*  Console.WriteLine("Please enter a number");
                  string userInput = Console.ReadLine();
                  int userNumber = int.Parse(userInput);
                  switch (userNumber)
                  {
                    //    case 10:
                    //    Console.WriteLine("The number that you entered is 10");
                    //    break;
                    //    case 20:
                    //    Console.WriteLine("The number that you entered is 20");
                    //    break;
                    //    case 30:
                    //    Console.WriteLine("The number that you entered is 30");
                    //    break;

                    //default:
                    //    Console.WriteLine("The number that you entered is not valid");
                    //    break;

                    //--------- you can join more than one case statment like that------------------ // 

                    case 10:
                    case 20:
                    case 30:
                        Console.WriteLine("The number that you entered is {0}", userNumber);
                        break;

                    default:
                        Console.WriteLine("The number that you entered is not 10 or 20 or 30");
                        break;

                }

                */

        /**/  //Lesson12
              //SWITCH Statment WITH GOTO
              /*
      int coffeCost = 0;
           // we use this label to jump to this point
       start:
           Console.WriteLine("Welcome to our shop, choose your size of coffe");
           Console.WriteLine("1- Small, 2- Medium, 3- Large");
           int userChoise = int.Parse(Console.ReadLine());
           switch (userChoise)
           {
               case 1:
                   coffeCost += 1;
               break;

               case 2:
                   coffeCost += 2;
               break;

               case 3:
                   coffeCost += 3;
                   break;

               default:
                   Console.WriteLine("Your choice is invalid");
               break;
           }
           // label 
           userDecision:
           Console.WriteLine("Do you want to buy another coffe? answer by 'YES' or 'NO' please ");
           string buyChoice = Console.ReadLine();
           switch (buyChoice.ToLower())
           {
               case "yes":
                   goto start;
               case "no":
                   // you can use goto to other case 
                   //goto case "yes";

                   break;
               default:
                   Console.WriteLine("Your choice {0} is invalid, please write yes or no",buyChoice);
                   goto userDecision;
                   break;
           }



           Console.WriteLine("Thank you for shopping with us");
           Console.WriteLine(" Your bill amount is : {0} Euro ", coffeCost);
           */

        /**/  //Lesson13
              //SWITCH Statment WITH WHILE loop

        /*
                Console.WriteLine("Please enter your target");
                int usertarget = int.Parse(Console.ReadLine());
                int start = 0;

                // it is important to set a brake statement to the condition 
                while (start <= usertarget)
                {
                    Console.Write("{0} ",start);
                    start += 2;
                }
                Console.WriteLine();
                */

        // example coffe machine with do/while loop (without GOTO statement)

        // this code is fixed :)
        /*
                 int coffeCost = 0;
                 Console.WriteLine("Welcome to our shop, choose your size of coffe");
                 int userChoise;
                 string userDecision = "";
                 do
                 {
                     do
                     {
                         Console.WriteLine("1- Small, 2- Medium, 3- Large");
                         userChoise = int.Parse(Console.ReadLine());

                         switch (userChoise)
                         {
                             case 1:
                                 coffeCost += 1;
                                 break;

                             case 2:
                                 coffeCost += 2;
                                 break;

                             case 3:
                                 coffeCost += 3;
                                 break;

                             default:
                                 Console.WriteLine("Your choice is invalid");
                                 break;
                         }
                     } while (userChoise != 1 && userChoise != 2 && userChoise != 3);

                     Console.WriteLine("Do you want to buy another coffe? answer by 'YES' or 'NO' please ");
                     userDecision = Console.ReadLine();
                     do
                     {
                         if (userDecision.ToLower() != "yes" && userDecision.ToLower() != "no")
                         {
                             Console.WriteLine("Your answer is INVALID. answer by 'YES' or 'NO' please ");
                         }
                     } while (userDecision.ToLower() != "yes" && userDecision.ToLower() != "no");


                 } while (userDecision.ToLower() == "yes");


                 Console.WriteLine("Thank you for shopping with us");
                 Console.WriteLine(" Your bill amount is : {0} Euro ", coffeCost);

              */


        /**/  //Lesson14
              //DO -  WHILE loop
              /*
                                  string userChoice = string.Empty;

                                  do
                                  {
                                      Console.WriteLine("Please enter your target number");
                                      int target = 0;
                                      int userInput = int.Parse(Console.ReadLine());

                                      while (target <= userInput)
                                      {
                                          Console.Write("{0} ", target);
                                          target += 2;
                                      }
                                      Console.WriteLine();

                                      do
                                      {
                                          Console.WriteLine("Do you want to continue - YES or NO");
                                          userChoice = Console.ReadLine();
                                          if (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no")
                                          {
                                              Console.WriteLine("your choice is INVALID, type -  YES or NO");
                                          }

                                      } while (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no");
                                  } 


                                  while (userChoice == "yes") ;
                                 */



        /**/  //Lesson15
              //for each loop
              /*
                       int[] numbers = new int[3];
                       int[] oddnumbers = {1,3,5,7};

                       // FOR LOOP
                       Console.WriteLine("--For loop--");
                       for (int i = 0; i < oddnumbers.Length; i++)
                       {
                           Console.WriteLine(oddnumbers[i]);
                       }


                       // WHILE LOOP
                       Console.WriteLine("--while loop--");
                       int j = 0;
                       while (j <oddnumbers.Length)
                       {
                           Console.WriteLine(oddnumbers[j]);
                           j++;
                       }

                       // FOREACH LOOP
                       Console.WriteLine("--FOREACH loop--");
                       foreach (var item in oddnumbers)
                       {
                           Console.WriteLine(item);
                       }
                       */

        // BREAK & CONTINUE STATMENTS
        /*
                      // BREAK
                      Console.WriteLine("--BREAK--");
                      for (int i = 0; i < 20; i++)
                      {
                          Console.WriteLine(i);
                          if (i == 10)

                              break;

                      }

                      // CONTINUE
                      Console.WriteLine("--CONTINUE--");
                      for (int j = 0; j <= 20; j++)
                      {

                          if (j % 2 == 1)
                           continue;

                        Console.WriteLine(j);

                      }
                      */

        /**/  //Lesson16
              //METHODS (basic introduction)
              // calling methods from MAIN
              /*
                   // calling instance methods
             Program p = new Program();
             // printing even numbers from 0 to number 20
             Console.WriteLine("------Calling instance method without parameters----");
             Console.WriteLine("------printing even numbers from 0 to number 20----");
             p.Evennumbers();
             // printing even numbers from 0 to number that the user put
             Console.WriteLine("------Calling instance method with parameters----");
             Console.WriteLine("------printing even numbers from 0 to number 30----");
             p.Evennumbers(30);
             Console.WriteLine("------Calling static method with parameters----");
             Console.WriteLine("------Static method----");
             // calling static method 
             int sum = Program.Addnumbers(14, 22);
             Console.WriteLine("Sum : {0}",sum);
             */

        /**/  //Lesson17
              //METHODS PARAMETERS

        //1. ---------- passing by vaule ------------
        /*      
               int i = 0;
               SimpleMethod(i);
               Console.WriteLine("Value of 'I' PASS BY VALUE  is : {0}", i);
               Console.WriteLine("--------------------------------------");
               //2. ---------- passing by refernes ------------
               int s = 0;
               SimpleMethodRef(ref s);
               Console.WriteLine("Value of 'S' PASS BY VALUE is : {0}", s);
               Console.WriteLine("--------------------------------------");
               //3. ---------- passing by OUT ------------
               // returning a SUM and Multiplication result from function 
               int total, PRO = 0;
               Calculate(50,10,out total,out PRO);
               Console.WriteLine("PASS BY OUT");
               Console.WriteLine("SUM: {0} and Product {1}", total,PRO);
               Console.WriteLine("--------------------------------------");
               //4. ---------- passing by PARAMS ------------
               // passing an array and empty array
               int[] numbers = new int[3];
               numbers[0] = 101;
               numbers[1] = 102;
               numbers[2] = 103;
               Console.WriteLine("PASS BY PARAMS");
               Console.WriteLine("---------empty array---------");
               // you can call this because of there is PARAMS key word, this show no elements in the array.
               ParamMethod();
               Console.WriteLine("---------Numbers array---------");
               ParamMethod(numbers);
               // other possiblity to call it directly
               ParamMethod(1, 2, 3, 4, 5, 6);
       */

        /**/  //Lesson18
              //NAME SPACES LOCATED AT LESSON18 folder *EASY USE with one project*
              //NAME SPACES LOCATED AT LESSON18_B folder *USE one project to call C# class library dll files* 
              // LOCATION DOWN:
              //  C:\Users\Station\Documents\Visual Studio 2015\Projects\LearningCsharp\lesson18
              //  C:\Users\Station\Documents\Visual Studio 2015\Projects\LearningCsharp\lesson18_B


        /**/  //Lesson19
              //Introduction to classes
              /*
                      // class with default values based on the first constructor
                      Customer C1 = new Customer();
                      // class called based on second constructor
                      Customer C2 = new Customer("Ahmad","Johansson");
                      // class called based on third constructor
                      Customer C3 = new Customer("Ahmad", "Johansson",27);
                      // class called based on Fourth constructor
                      Customer C4 = new Customer("Ali", 27);

                      C1.PrintFullName();
                      C2.PrintFullName();
                      C3.PrintFullName();
                      C4.PrintFullName();
              */

        /**/  //Lesson20
              //Static and instance class members(events,methods,proberties) 


        /*
        Circle c1 = new Circle(5);
        float Area1 = c1.CalculateArea();
        Console.WriteLine("Radius = {0}", c1._radius);
        Console.WriteLine("Area = {0}",Area1);
        Circle c2 = new Circle(6);
        float Area2 = c2.CalculateArea();
        Console.WriteLine("Radius = {0}", c2._radius);
        Console.WriteLine("Area = {0}", Area2);
        
         
        // * this line will call/show that static constructor is first called before instance constructor and without any calling to constructor
        // * this line we use without using the seven lines mentioned above
        
        Console.WriteLine(Circle._PI);
       
          */

        /**/  //Lesson21
              // Inheritance in c#

        //-------------------------- PART 1 ------------------------
        /*
              PartTimeEmployee pte = new PartTimeEmployee();
              pte._firstName = "Ahmad";
              pte._lastName = "Johansson";
              pte.Hourlyrate = 680;
              pte.PrintFullName();


              FullTimeEmployee fte = new FullTimeEmployee();
              fte._firstName = "Dalida";
              fte._lastName = "Matsson";
              fte.AnuualSalary = 650000;
              fte.PrintFullName();

              // child to Parttime class which is inhertied from Employee class and in that way , A class has both class proberties
              A a1 = new A();
              */
        //-------------------------- PART 2 ------------------------
        /*  ChildClass cc = new ChildClass();
             */

        /**/  //Lesson22
              // Method hiding in c#
              /*
        PartTimeEmployee pte = new PartTimeEmployee();
        pte._lastName = "Adi";
        pte._firstName = "Daniel";
        // this method in the child class will hide the same method in the parent class
        pte.PrintFullName();
        // This statement will call PrintFullName method which is located in the Parent class by converting the pte object to 
        //* Employee object and the print Employee method 
        // ((Employee)pte).PrintFullName();

        //* other way to call Parent method is to use the statement below
        Employee PTE = new PartTimeEmployee();
        PTE._lastName = "Abbarof";
        PTE._firstName = "Johan";
        PTE.PrintFullName();

        */

        /**/  //Lesson23
              // Polymorphism in c#

        /*
               Employee[] employees = new Employee[4];
               employees[0] = new Employee();
               employees[1] = new PartTimeEmployee();
               employees[2] = new FullTimeEmployee();
               employees[3] = new TemporaryEmployee();

               foreach (var item in employees)
               {
                   item.PrintFullName();
               }
               */
        /**/  //Lesson24
              // Difference between method overriding and method hiding in c#
              /*
                                                  BaseClass B = new BaseClass();
                                                  B.Print();
                                                  // calling with OVERRIDE KEYWORD type in the derived class will call PRINT method in derived class
                                                  // calling with NEW KEYWORD in the derived class will call PRINT method in base class and hide PRINT METHOD in the child
                                                  BaseClass b = new DerivedClass();
                                                  b.Print();

                                                  DerivedClass D = new DerivedClass();
                                                  D.Print();

                                          */

        /**/  //Lesson25
              // Method overloading in c#

        // calling this method will show variants of this methods
        // add();

        /**/  //Lesson26
              // Properties in c#
              /*
                      Student S = new Student();
                      S.SetID(200);

                      Console.WriteLine("Student ID: {0}", S.GetID());
                      Console.WriteLine("Student Name: {0}", S.GetName());
                      Console.WriteLine("Student Pass mark: {0}", S.GetPassMark());

                      S.Print();

                      */

        /**/  //Lesson27
              // Properties in c# with SET and GET methods
              /*
                                                                Student st = new Student();
                                                                st.ID = 101;
                                                                st.Name = "MARK";

                                                                Console.WriteLine("Student ID : {0}",st.ID);
                                                                Console.WriteLine("Student Name : {0}", st.Name);
                                                                Console.WriteLine("Student Passmark : {0}", st.Passmark);
                                                                */

        /**/  //Lesson28
              // Structs in c# 
              /*
                      // one method for calling
                      Customer c1 = new Customer(102,"Mark");
                      c1.Print();
                      // Second method for calling
                      Customer c2 = new Customer();
                      c2.Id = 111;
                      c2.Name = "Walid";
                      c2.Print();
                      // Third method for calling (object intializer syntax)
                      Customer c3 = new Customer()
                      {
                          Id = 222, Name = "John"
                      } ;
                      c3.Print();

                      */

        /**/  //Lesson29
              //  Difference between classes and structs in c# 
/*
        // *Struct is a value type
        // class is a refernce type
        // *struct stored in Stack
        // class stored in Heap
        // *Value type destroyed after the end of it's scope
        // refernce varible destroyed after the end of it's scope but the refernce object destroys when the garbage collector clean the HEAP
        // *when you copy a struct to another the new copy is a defined object in it self and it will not effect the copy of it.
        // classes when it copys each other it still refer to the same place in the memory 
        // *struct can not have destructors while class CAN have
        // *Struct can not have an expicit parameterless where class CAN
        // *Struct can not inherit from another where class CAN (inherit is a SEALED type)
        // Classes and structs(BOTH) can inherit from an interface
        // Struct can not be a base inhertiance(parent class/struct) for a struct or class which means
        // a class or struct can not be derived from a struct


        int i = 10;
        if (i == 10)
        {
            int j = 20;
            Customer c1 = new Customer();
            c1.Id = 101;
            c1.Name = "Paul";
        }

        // i is a struct which destroyed in line 771
        // j is a struct which destroyed in line 765 (must be available in if block and dies after IF statement)
        // C1 is a refence object variable stored in stack but the object it self stored in HEAP.

        int I = 10;
        int J = i;
        J++;
        Console.WriteLine("I = {0}, J = {1} ",I,J);
        // operations on J will not affect I because they are value type.Each varible will not affect the other because it refers to it's 
        // own fixed place in the memory.
        Customer C1 = new Customer();
        C1.Id = 101;
        C1.Name = "Paul";

        Customer C2 = C1;
        C2.Name = "Mary";
        Console.WriteLine("C1.Name = {0}, C2.Name = {1} ", C1.Name, C2.Name);
        // operations on C1 will affect C2 because they are refence type.Each varible will affect the other because they refer to the same 
        // place in the memory(same object).
*/







    }

    // ------------------------------------------ METHODS NOT IN MAIN -------------------------------------------
    /**/  //Lesson16
          //METHODS
          // making methods
          /*
                        // instance method with no parameters
                        // call it from main method with making an instance of the class object :- program p = new program() -> p.Evennumbers()
                        public void Evennumbers()
                        {
                            int start = 0;
                            while (start < 20)
                            {
                                Console.WriteLine(start);
                                start += 2;
                            }

                        }
                        // instance method with parameters
                        // call it from main method with making an instance of the class object :- program p = new program() -> p.Evennumbers(30)
                        public void Evennumbers(int target)
                        {
                            int start = 0;
                            while (start < target)
                            {
                                Console.WriteLine(start);
                                start += 2;
                            }
                        }
                        // static method with parameters
                        // call it from main method  program.Addnumbers
                        public static int Addnumbers(int FN,int SN)
                        {
                            return FN + SN;
                        }
                    */


    //Lesson17
    //METHODS PARAMETERS

    /*
        // 1. method which pass value parameter
        public static void SimpleMethod(int j)
        {
            j = 101;
        }

        // 2. method which pass reference parameter
        public static void SimpleMethodRef(ref int j)
        {
            j = 101;
        }

        // 3. method which pass OUT parameter (Sending back the sum and mutliplication result) 
        // VOID NOT INT because it returns two output varibales
        public static void Calculate(int FN, int SN, out int Sum, out int product)
        {
            Sum=  FN + SN;
            product = FN * SN;
        }

        // 4. method which pass PARAMS parameter 
        // PARAMS PARAMETER  makes your input to method as optional even if you do not put the variable it will not be a problem
        // PARAMS should be the last parameter and just only one
            public static void ParamMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements in the array", Numbers.Length);
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);

            }
        }
        */

    /**/  //Lesson25
          // Method overloading in c#

    /*
       public static void  add(int FN, int SN, int TN)
       {
           Console.WriteLine("Sum = {0}", FN + SN + TN);
       }

       // overloading is possbile because this method contains not the same amount of arguments
       public static void add(int FN, int SN)
       {
           Console.WriteLine("Sum = {0}", FN + SN );
       }

       // overloading is possbile because the Type of parameter is differ from the first method(float SN)
       public static void add(int FN,float SN, int TN)
       {
           Console.WriteLine("Sum = {0}", FN + SN + TN);
       }

       // overloading is possbile because the Type of parameter is differ from the first method (out int TN)
       public static void add(int FN, int SN, out int TN)
       {
           Console.WriteLine("Sum = {0}", FN + SN );
           TN = FN + SN;
       }

       // overloading is not possbile if we have the same method but different type (from VOID to INT) or have a PARAMS modifier
       //---------------------------------MAIN Example (from VOID to INT)------------------------------------
       public static void Sub(int FN, int SN)
       {
           Console.WriteLine("Sum = {0}", FN - SN);
       }
       // this will be ERROR (the same method but different returning type)
       public static int Sub(int FN, int SN)
       {
           Console.WriteLine("Sum = {0}", FN - SN);
           return FN - SN;
       }
       //------------------------  PARAMS ----------------------------
       public void Mul(int FN,params int[] SN)
       {
           Console.WriteLine("Sum = {0}");
       }
       public int Mul(int FN, int[] SN)
       {
           Console.WriteLine("Sum = {0}");
           return FN ;
       }

       */


}

// ------------------------------------- CLASSES NOT IN MAIN ---------------------------------------------------
/**/  //Lesson19
      //Introduction to classes
      /*
             * class Customer
           {
               //-------------- class attributes --------------
               string _firstName;
               string _lastName;
               int age;

               //-------------- class constructor --------------
               // this is used to intial the class attributes
               public Customer() 
                   : this("Oh","No",30)
                  // this line is added to make the default instructor containing these values
               {

               }
               public Customer(string FirstName, string LastName)
               {
                   this._firstName = FirstName;
                   this._lastName = LastName;
               }

               public Customer(string firstName, string lastName, int Age)
               {
                   this._firstName = firstName;
                   this._lastName = lastName;
                   this.age = Age;
               }

               public Customer(string _lastName, int age)
               {
                   this._lastName = _lastName;
                   this.age = age;
               }


               //-------------- class behaviour --------------
               // this means all class methods that is used in the class like Write Full name method
               public void PrintFullName()
               {
                   Console.WriteLine("Full name is :" + this._firstName + " " + this._lastName);
                   Console.WriteLine("Age is :" + this.age);
               }

               // ------------- deconstructor-----------------
               // this is the style of deconstructor which is used to free the momory of the used object 
               ~Customer()
               {
                   // CODE TO CLEAN
               }
           }
           */

/**/  //Lesson20
      //Static and instance class members(events,methods,proberties) 
      /*
     class Circle
     {
         // proberties
         // STATIC word added because it is fixed number which is used every time we make an instance of this object.
         // This will be called once to reduce the amount of memory in each object
         public static float _PI;
         public int _radius; // { get; set; }

         // STatic constructor is built to call once when intial values for first time and this reduce the amount of memory called in
         // every time we call the CIRCLE CLASS
         static Circle()
         {
             Console.WriteLine("Static constructor called");
             _PI = 3.14F;
         }

         // consturctor
         public Circle(int Radius)
         {
             Console.WriteLine("Instance constructor called");
             this._radius = Radius;
         }

         // behaviour (methods)
         public float CalculateArea()
         {
             return Circle._PI * this._radius * this._radius;
         }

     }

         */

/**/  //Lesson21
      // Inheritance in c#

//-------------------------- PART 1 ------------------------
/*
// BASE CLASS -- PARENT CLASS

public class Employee
{
public string _firstName;
public string _lastName;
public string _Email;

// constructor

// methods : behavior
public void PrintFullName()
{
Console.WriteLine("Full name:" + this._firstName + " " + this._lastName);
}

}
// child class is derived from Parent class
public class PartTimeEmployee : Employee  
{
public float Hourlyrate;
}

// child class is derived from Parent class
public class FullTimeEmployee : Employee
{
public float AnuualSalary;
}

public class A : FullTimeEmployee
{
// child to Parttime class which is inhertied from Employee class and in that way , A class has both class proberties
}
*/
//-------------------------- PART 2 ------------------------
/*
class ParentClass
{
public ParentClass()
{
  Console.WriteLine("Parent class called");
}
public ParentClass(string Message)
{
  Console.WriteLine("Parent class called with string Message" + Message);
}
}

class ChildClass : ParentClass
{
public ChildClass() 
  : base("Hello guys")
// this line of code calling the PARENT class constructor which contains String MESSAGE not the default one
//* When there is no  : base("Hello guys") line so it will take the default constructor from the PARENT CLASS
{
  Console.WriteLine("Child class called");
}
}

*/

/**/  //Lesson22
      // Method hiding in c#
      /*
          //PARENT CLASS
          class Employee
      {
          public string _firstName;
          public string _lastName;

          public void PrintFullName()
          {
              Console.WriteLine(this._firstName + " " + this._lastName);
          }
      }

      // Child class
      class PartTimeEmployee : Employee
      {
          public float Hourlyrate;
          public new void PrintFullName()
          {
              // This statement to call the PrintFullName which is PARENT method which is overriden by child method with the same name
              //  base.PrintFullName();

              Console.WriteLine(this._firstName + " " + this._lastName + "      --- contractor");
          }

      }
      */



/**/  //Lesson23
      // Polymorphism in c#
      /*
          // Parent class

      class Employee
      {
          public string _firstname = "FN";
          public string _lastname = "LN";

          //virtual  is used to mention that method can be overriden by child class which contains the same name of method
          public virtual void PrintFullName()
          {
              Console.WriteLine(this._firstname + " " + this._lastname);
          }
      }

      // CHILD CLASSES
      class TemporaryEmployee : Employee
      {
          public override void PrintFullName()
          {
              Console.WriteLine(this._firstname + " " + this._lastname + "-- Temperary Employee");
          }
      }
      class PartTimeEmployee : Employee
      {
          public override void PrintFullName()
          {
              Console.WriteLine(this._firstname + " " + this._lastname + "-- Part Time Employee");
          }

      }
      class FullTimeEmployee : Employee
      {
          public override void PrintFullName()
          {
              Console.WriteLine(this._firstname + " " + this._lastname + "-- Full Time Employee");
          }
      }

      */


/**/  //Lesson24
      // Difference between method overriding and method hiding in c#
      /*
      class BaseClass
      {
          public virtual void Print()
          {
              Console.WriteLine("Base class method called");
          }
      }
      class DerivedClass : BaseClass
      {
          public override void Print() //OR new void Print()
          {
              Console.WriteLine("Derived class method called");
          }
      }
      */


/**/  //Lesson26
      // Why properties in c#
      /*
          class Student
      {
         int _studentID;
         string _name;
         int _markpass = 35;

          // -------------- ID -----------------
          public void SetID(int ID)
          {
              if (ID <= 0)
              {
                  throw new Exception("Student ID must be non negative value");
              }
              this._studentID = ID;
          }
      public int GetID()
          {
              return this._studentID;
          }
          // -------------- NAME -----------------
          public void SetName(string NAME)
          {
              if(string.IsNullOrEmpty(NAME)== true)
              {
                  throw new Exception("Name can not be set to NULL");
              }
              this._name = NAME;
          }
          public string GetName()
          {
           return string.IsNullOrEmpty(this._name) ? "\"No Name\"" : this._name;

          }
          // -------------- Pass Mark -----------------
          public int GetPassMark()
          {
              return this._markpass;
          }

          public void Print()
          {
              Console.WriteLine("Student ID: {0} , Name: {1}, PassMark: {2}",GetID(),GetName(),GetPassMark());
          }
      }
      */


/**/  //Lesson27
      //properties in c# with SET and GET methods (SET and GET proberties)

      /*
class Student
{   string _name;
int _passmark = 35;
int _id;

// ID with SET and GET method as proberty
public int ID{
get {
return this._id;
}
set
{
if ( value <= 0)
{
    throw new Exception("Student ID must be non negativ");
}
this._id = value;
}
}
// Name with SET and GET method as proberty
public string Name {
get
{
return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
}
set
{
if (string.IsNullOrEmpty(value))
{
    throw new Exception("Name must not be a NULL or empty value");
}
else
    this._name = value;
}
}
// ID with GET method as proberty
public int Passmark {
get
{
return this._passmark;
}
}
public string City{ get; set; }
public string Email { get; set; }
}
*/

/**/  //Lesson28
      // Structs in c# 

      /*
public struct Customer
{
// fields
int _id;
string _name;



// public proberties
public string Name
{
get
{
  return _name;
}

set
{
  _name = value;
}
}
public int Id
{
get
{
  return _id;
}

set
{
  _id = value;
}
}


// constructor
public Customer(int ID, string Name)
{
this._id = ID;
this._name = Name;
}

// behavior (Methods)

public void Print()
{
Console.WriteLine("Customer ID :{0}, Name: {1}", this._id, this._name);
}
}
*/

/**/  //Lesson29
      //  Difference between classes and structs in c# 

      /*
    public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}
*/