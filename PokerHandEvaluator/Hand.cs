using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandEvaluator
{
    public class Hand
    {
        private Card[] cards;

        public Hand(Card[] value) { cards = value; }

        public Card GetCard(int i)
        {
            return cards[i];
        }

        
    }
}
