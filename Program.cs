using System;
using System.Collections.Generic;

namespace Stacks_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an array of card objects with their card names
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

            // creates a stack card from the array of card objects
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            //output the cards in the deck 
            Console.WriteLine("Cards in Deck:");

            //goes through each card in the stack and prints its details
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}.");
            }

            // display the numbers of cards in the deck
            Console.WriteLine($"Cards in the Deck: {startingDeck.Count}");

            //Create a List<Card> to represent a hand of cards
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Clubs"));
            myHand.Add(new Card("9", "Spades"));
            myHand.Add(new Card("Ace", "Clubs"));

            //Check if the deck has any cards before popping one to add to the hand
            Console.WriteLine("Got Any 8'?");
            if(startingDeck.Count > 0)
            {
                // adds top card from the deck to hand
                myHand.Add(startingDeck.Pop());
            }

            // display the updated number of cards in deck
            Console.WriteLine($"Cards in the Deck: {startingDeck.Count}");

            //return a card from the hand to the deck and remove it from hand
            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            // Output the remaining cards
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}.");
            }

           



        }
    }
}