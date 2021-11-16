using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandEvaluator
{
    public enum Suit { Hearts, Diamonds, Spades, Clubs };
    public class Card
    {
        public Suit Suit { get; set; }  
        public int Value { get; set; }
    }
}
