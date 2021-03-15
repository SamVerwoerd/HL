using System;
using System.Threading;
using System.Collections.Generic;

namespace ProjectHigherLower
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Variables
            

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Age Check                    
            Program.WriteLineSlow("Welcome to H & L - The card guessing game.");

            // Info 
            Console.Clear();
            Console.WriteLine("Please enter a name");
            string Name = Console.ReadLine();
            Program.WriteLineSlow("Your name has been saved as " + Name + ".");

            Console.ResetColor();
            // Rules & Instructions
            Console.Clear();
            Program.WriteLineSlow("How to play Higher lower");
            Program.WriteLineSlow("Its simple");
            Program.WriteLineSlow("You need to guess if the card is higher or lower.");
            Program.WriteLineSlow("You get 1 point for each right answer.");

            // start
            Program.WriteLineSlow("The computer is generating the deck of cards...");
            int score = 0; 
            bool temp = true;
            string Continue;
            while (temp == true)
            {
               

                string[] card2 = {  "\u2666", "\u2665", "\u2663", "\u2660" };
                string[] cardValue = Card.GetAllowedCardValues();
       

                Random rnd = new Random();
                string[] card3 = { cardValue[rnd.Next(0, 13)], card2[rnd.Next(0, 4)] };
                string[] card4 = { cardValue[rnd.Next(0, 13)], card2[rnd.Next(0, 4)] };

                int cardmake3()
                {
                    int cijfer = 3;
                    int plus = 0;
                    for (int i = 2; i < 15; i++)
                    {
                        if (card3[0] == cardValue[plus])
                        {
                            cijfer = i;
                            plus++;
                        }
                        else
                        {
                            plus++;
                        }

                    }
                    return cijfer;
                }

                int cardmake2()
                {
                    int cijfer = 3;
                    int plus = 0;
                    for (int i = 2; i < 15; i++)
                    {
                        if (card4[0] == cardValue[plus])
                        {
                            cijfer = i;
                            plus++;
                        }
                        else
                        {
                            plus++;
                        }

                    }
                    return cijfer;
                }
                Console.Clear();
                Console.WriteLine("card: ");
                if (cardmake3() >= 10)
                {
                  Console.WriteLine(cardmake3());
                }
                else
                {
                  Console.WriteLine(cardmake3());
                }
                Console.WriteLine(card3[1]);
                Console.WriteLine(Name + " choose, h or l (Higher or Lower)");
                string guess = Console.ReadLine();
                if (guess == "H") 
                {
                    guess = "h";
                }
                else if (guess == "L")
                {
                    guess = "l";
                }
                if (guess == "h" && cardmake3() < cardmake2())
                {
                    //goed antwoord
                    Console.WriteLine("the card was : ");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine(cardmake2());
                    }
                    else
                    {
                        Console.WriteLine(cardmake2());
                    }
                    Console.WriteLine(card4[1]);
                    score++;
                    Program.WriteLineSlow("good");
                    Program.WriteLineSlow("your score is now: " + score);


                    Console.Clear();

                }
                else if (guess == "h" && cardmake3() > cardmake2())
                {
                    //fout antwoord
                    Console.WriteLine("the card was : ");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine(cardmake2());
                    }
                    else
                    {
                        Console.WriteLine(cardmake2());
                    }
                    Console.WriteLine(card4[1]);
                    Program.WriteLineSlow("wrong");
   
                    Console.Clear();
                    Program.WriteLineSlow("Do you want to continue? ");
                    Program.WriteLineSlow("Type n if you would like to stop");
                    Program.WriteLineSlow("Type y if you would like to continue");
                    Continue = Console.ReadLine();
                    if ((Continue == "n") || (Continue == "N"))
                    {
                        Program.WriteLineSlow("Your final score is: " + score);
                        temp = false;
                        
                    }
                }
                else if (guess == "l" && cardmake3() > cardmake2())
                {
                    //goed antwoord
                    Console.WriteLine("the card was : ");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine(cardmake2());
                    }
                    else
                    {
                        Console.WriteLine(cardmake2());
                    }
                    Console.WriteLine(card4[1]);
                    Program.WriteLineSlow("good");
                    score++;
                    Program.WriteLineSlow("your score is now: " + score);

                    Console.Clear();
                }

                else if (guess == "l" && cardmake3() < cardmake2())
                {
                    //fout antwoord
                    Console.WriteLine("the card was : ");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine(cardmake2());
                    }
                    else
                    {
                        Console.WriteLine(cardmake2());
                    }
                    Console.WriteLine(card4[1]);
                    Program.WriteLineSlow("wrong");
  
                    Console.Clear();
                    Program.WriteLineSlow("Do you want to continue? ");
                    Program.WriteLineSlow("Type n if you would like to stop");
                    Program.WriteLineSlow("Type y if you would like to continue");
                    Continue = Console.ReadLine();
                    if ((Continue == "n") ||(Continue == "N"))
                    {
                        temp = false;
                    }
                }
                else if (cardmake3() == cardmake2())
                {
                    // kaart is gelijk
                    Console.WriteLine("the card was : ");
                    if (cardmake3() >= 10)
                    {
                        Console.WriteLine(cardmake2());
                    }
                    else
                    {
                        Console.WriteLine(cardmake2());
                    }
                    Console.WriteLine(card4[1]);
                    Program.WriteLineSlow("equal");
                    score++;
                    Program.WriteLineSlow("your score is now: " + score);

                    Console.Clear();
                }
            }
        }
            public static void WriteLineSlow(string message)
            {
                Console.WriteLine(message);
                Thread.Sleep(1500);
            }
    }
}
