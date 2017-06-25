using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] deck =
            {
                new Card("Ace", "Hearts"),
                new Card("2", "Hearts"),
                new Card("3", "Hearts"),
                new Card("4", "Hearts"),
                new Card("5", "Spades"),
                new Card("6", "Spades"),
                new Card("7", "Spades"),
                new Card("8", "Spades"),
                new Card("9", "Clubs"),
                new Card("10", "Clubs"),
                new Card("King", "Clubs"),
                new Card("Queen", "Clubs")
            };

            Stack<Card> myStack = new Stack<Card>();

            Console.WriteLine("Before pushing onto stack: ");
            foreach (Card c in deck)
            {
                Console.WriteLine(c.Number + " " + c.Suit);
            }

            Console.WriteLine("\nNow pushing onto stack...");
            Console.ReadLine();

            int divider = 0;
            foreach (Card c in deck)
            {
                if (divider < 4)
                {
                    myStack.Push(c);
                    divider++;
                }
                else if (divider >= 4 && divider < 7)
                {
                    myStack.Push(c);
                    divider++;
                }
                else if (divider >= 7)
                {
                    myStack.Push(c);
                    divider++;
                }
            }

            Console.WriteLine("Stack contains: ");
            foreach(Card c in myStack)
            {
                Console.WriteLine(c.Number + " " + c.Suit);
            }

            Console.WriteLine("\nPopping stack contents into same array");
            Console.ReadLine();

            for (int i = deck.Length - 1; i <= 0; i--)
            {
                deck[i] = myStack.Pop();
            }

            Console.WriteLine("Array contents are now: ");
            foreach (Card c in deck)
            {
                Console.WriteLine(c.Number + " " + c.Suit);
            }

            

            


        }
    }
}
