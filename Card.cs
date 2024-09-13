using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Jackson_Lydia
{
    internal class Card
    {
        // property to get the number of the card
        public string Number { get; }

        // property to get the suit of the card
        public string Suit {  get; }

        // constructor to initialize a new card object with specified number and suit
        public Card(string numParam, string suitParam)
        {
            // assigns a parameter to number and suit
            Number = numParam;
            Suit = suitParam;
        }


    }
}
