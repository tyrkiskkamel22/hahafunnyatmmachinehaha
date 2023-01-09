using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {

        int saldo = 0;

        // VARIABLES LOOOOL
        bool lol = true;
        bool restartlol = false;
        bool mainer = false;
        bool hahafunny = true;
        string pinkode = "1234";
        string? enterpin;
        string? selection = "0";


        while (hahafunny)
        {
            while (restartlol)
            {
                lol = false;
                lol = true;
                mainer = false;
                restartlol = false;
            }

            while (lol)
            {
                Console.WriteLine("Indtast din pinkode");
                enterpin = Console.ReadLine();
                if (enterpin == pinkode)
                {
                    mainer = true;
                    lol = false;
                    Console.WriteLine("Korrekt pinkode...");
                    Thread.Sleep(500);
                }
                else if (enterpin == "funny")
                {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (enterpin != pinkode)
                {
                    Console.Clear();
                    Console.WriteLine("Forkert pinkode. Prøv igen");
                    Thread.Sleep(1500);
                    restartlol = true;
                }

                Console.Clear();
            }

            while (mainer)
            {
                // MAIN
                {
                    Console.WriteLine("Velkommen til din konto\nHer er dine muligheder\n");
                    Console.WriteLine("1. Saldo\n2. Indsæt beløb\n3. Hæv beløb\n4. Ændre pinkode\n5. Log ud\n");
                    selection = Console.ReadLine();
                }



                // SALDO / 1
                if (selection == "1")
                {
                    Console.Clear();
                    if (saldo < 1)
                    {
                        Console.WriteLine("Du har " + saldo + "kr på din konto. Fattige taber");
                    }

                    else
                    {
                        Console.WriteLine("Du har " + saldo + "kr på din konto");
                    }
                    Console.WriteLine("\nTryk Enter for at gå tilbage til hovedmenuen...");
                    Console.ReadKey();
                    Console.Clear();
                }

                // INDSÆT / 2
                if (selection == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Indtast beløbet du vil indsætte");
                    int deposit = int.Parse(Console.ReadLine());
                    if (deposit > 0)
                    saldo = saldo + deposit;
                    Console.WriteLine("Du har indsat " + deposit + "kr på din konto\nDu har nu " + saldo + "kr på din konto");
                    Console.WriteLine("\nTryk Enter for at gå tilbage til hovedmenuen...");
                    Console.ReadKey();
                    Console.Clear();
                }


                // HÆV / 3
                if (selection == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Indtast beløbet du vil hæve");
                    int withdraw = int.Parse(Console.ReadLine());
                    if (withdraw < saldo)
                    {
                        if (withdraw > 0)
                            saldo = saldo - withdraw;
                        Console.WriteLine("Du har hævet " + withdraw + "kr fra din konto\nDu har nu " + saldo + "kr på din konto");
                        Console.WriteLine("\nTryk Enter for at gå tilbage til hovedmenuen...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fejl! Ikke nok på kontoen");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                }

                // Ændre pinkode / 4
                if (selection == "4")
                {
                    string svar;
                    string securitycheck;
                    Console.Clear();
                    Console.WriteLine("Er du sikker på, at du vil skifte din pinkode?\nSvar med \"Ja/Nej\"");
                    svar = Console.ReadLine();
                    Console.Clear();
                    if (svar == "Ja" || svar == "ja")
                    {
                        Console.Clear();
                        Console.WriteLine("Angiv din nuværende pinkode");
                        securitycheck = Console.ReadLine();
                        if (securitycheck == pinkode)
                        {
                            Console.Clear();
                            Console.WriteLine("Indtast ny pinkode");
                            string newpin = Console.ReadLine();

                            int haha = Int32.Parse(newpin);
                            if (haha.ToString().Length != 4)
                                Console.WriteLine("Fejl! Pinkoden skal være 4 cifre");
                            else
                                pinkode = newpin;
                            Console.WriteLine("Din pinkode er blevet ændret");
                            Thread.Sleep(1000);
                        }
                        else
                            Console.WriteLine("Forkert pinkode");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                        Console.WriteLine("Fejl!");
                    Thread.Sleep(500);
                    Console.Clear();
                }


                // Log ud / 5
                if (selection == "5")
                {
                    mainer = false;
                    restartlol = true;
                    Console.Clear();
                    Console.WriteLine("Logger ud...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                // Haha funny!!
                if (selection == "69")
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine("Haha funny!!");
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }
        }
    }
}