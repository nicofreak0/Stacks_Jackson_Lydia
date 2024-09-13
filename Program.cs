using System;
using System.Collections.Generic;

namespace Stacks_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Diamonds"),
                new Card("Queen", "Clubs"),
                new Card("King", "Hearts"),
                new Card("8", "Spades"),
                new Card("4", "Hearts"),
                new Card("5", "Diamonds"),
                new Card("2", "Spades"),
                new Card("7", "Spades"),
            };

            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            Console.WriteLine("Cards in Deck:");

            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}.");
            }
        }
    }
}