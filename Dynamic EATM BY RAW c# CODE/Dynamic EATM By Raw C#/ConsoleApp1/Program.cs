using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Banking();
            Console.ReadLine();
        }

        public static void Banking()
        {

            Console.WriteLine("***************** WELCOME TO ATM BANKING-DEVELOPED BY TANVIR *****************\n");

            //**************************ACCOUNT NUMBER, BALANCE AND PIN SETUP************************

            var AccountNumber = new List<int>() { 255, 983, 456, 555 };

            var PinNumber = new List<int>() { 7978, 0101, 5050, 111 };

            var Balance = new List<int>() { 10000, 40000, 2000, 20000 };


            //*************USER INPUT FOR ACCOUNT NUMBER & PIN**************

            Console.Write("Please Enter your Account Number: ");

            var CardInput = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Your pin: ");

            var PinInput = int.Parse(Console.ReadLine());

            int p, l, n,i;

            //*************************ACCOUNT, PIN NUMBER CHECK & CHOICE SELECTION FOR TRANSACTION*******************

            for (p = 0; p < AccountNumber.Count; p++)
            {
                for (l = 0; l < PinNumber.Count; l++)
                {
                    for (n = 0; n < Balance.Count; n++)
                    {


                        if ((CardInput == AccountNumber[p] && PinInput == PinNumber[l]) && (p == n) && (p == l))
                        {
                            
                            for ( i = 0; i < 3; i++)
                            //****************LOOP FOR UPTO THREE TIME TRANSACTION PROCESS**************
                            {

                                Console.WriteLine("Please Choose Your Transaction: ");

                                Console.WriteLine("\t1. Withdraw Money\n\t2. Balance Check\n\t3. Exit");

                                Console.Write("Enter Your Choice Now: ");

                                var choice = int.Parse(Console.ReadLine());

                                // ***************WITHDRAW MONEY CODE***********

                                if (choice == 1)
                                {
                                    Console.Write("Enter Your Amount: ");

                                    var withdraw = int.Parse(Console.ReadLine());

                                    // **** FIRST ACCOUNT WITHDRAW MONEY ************
                                    

                                    if (CardInput == AccountNumber[p] && PinInput == PinNumber[l] && withdraw <= 1000)
                                    {

                                        var Balance1 = Balance[n];


                                        var CurrentBalance1 = Balance[n] - withdraw;

                                        Balance[n] = CurrentBalance1;

                                        if (CurrentBalance1 > 20)
                                        {
                                            Console.WriteLine("Success Withdraw. New Balance is: " + CurrentBalance1);

                                            Console.Write("Do you Want to Quit? Yes OR No: ");

                                            var quit1 = Console.ReadLine();

                                            if (quit1 == "yes")
                                            {
                                                Environment.Exit(0);
                                            }
                                            else if (quit1 == "no")
                                            {
                                                Console.WriteLine("OK.Try Again From Scratch");

                                            }
                                        }

                                        else
                                        {
                                            Console.WriteLine("Sorry Not Enough Balance!\nYour Balance is: " + Balance1);

                                            Console.Write("Do you Want to Quit? Yes OR No: ");

                                            var quit1 = Console.ReadLine();

                                            if (quit1 == "yes")
                                            {
                                                Environment.Exit(0);
                                            }
                                            else if (quit1 == "no")
                                            {
                                                Console.WriteLine("OK.Try Again From Scratch");

                                            }

                                        }

                                    }
                                    else
                                    {

                                        Console.WriteLine("You can not withdraw more than 1000 Tk\nTry Again");

                                    }




                                }

                                // **********ONLY BALANCE CHECK CODE*******************

                                else if (choice == 2)
                                {
                                    // **********ONLY BALANCE CHECK CODE FOR ACCOUNT ONE*******************

                                    if (CardInput == AccountNumber[p] && PinInput == PinNumber[l])
                                    {



                                        Console.WriteLine("Your Balance is:" + Balance[n]);

                                        Console.Write("Do you Want to Quit? Yes OR No: ");

                                        var quit1 = Console.ReadLine();

                                        if (quit1 == "yes")
                                        {
                                            Environment.Exit(0);
                                        }
                                        else if (quit1 == "no")
                                        {
                                            Console.WriteLine("OK.Try Again From Scratch");

                                        }


                                    }


                                }

                                // **********EXIT CODE*******************

                                else if (choice == 3)
                                {
                                    Environment.Exit(0);

                                }

                                // ********** CHOICE NOT MATCHED, CODE*******************

                                else
                                {

                                    Console.WriteLine("Sorry!! Wrong Choice!");

                                    Console.Write("Try Again From Scratch");

                                }
                            }
                        }


                    }

                }
            }
            // ********** THREE TIMES TRIED FOR THE USER. BUT FAILED or PIN AND ACCOUNT NOT MATCHED *******************

            Console.WriteLine("Sorry something wrong ");
        }

    }
}


