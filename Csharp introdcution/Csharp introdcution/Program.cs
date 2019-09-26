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



                      string number = "100G";
                      int result2;

                      // TRYPARSE method  returns a bool indicator if convertion succeeded or not
                      bool conversionResult = int.TryParse(number, out result2);
                      Console.WriteLine("Conversion result is for result2 is {0} and the result is {1}\n", conversionResult, result2);
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
        int coffeCost = 0;
        // we use this label to jump to this point


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
    }
}



