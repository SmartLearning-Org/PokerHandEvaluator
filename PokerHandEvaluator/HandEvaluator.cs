using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandEvaluator
{
    public static class HandEvaluator
    {
        public static int GetHandScore(Hand hand)
        {
            if (IsRoyalFlush(hand))
            {
                return 10;
            }
            if (IsFlush(hand))
            {
                return 5;
            }
            if (IsStraight(hand))
            {
                return 4;
            }
            return 0;
        }

        private static bool IsRoyalFlush(Hand hand)
        {
            if (!(IsFlush(hand)) && IsStraight(hand))
            {
                return false;
            }

            for (int i = 0; i < 5; i++)
            {
                if (hand.GetCard(i).Value == 13)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsStraight(Hand hand)
        {
            int[] values = new int[5];
            for (int i = 0; i < 5; i++)
            {
                values[i] = hand.GetCard(i).Value;
            }
            Array.Sort(values);
            for(int i = 0; i < 4; i++)
            {
                if (values[i] != values[i + 1] - 1)
                {
                    return false;
                }
            }
            return true;
        }
        private static bool IsFlush(Hand hand)
        {
            for (int i = 0; i < 4; i++)
            {
                if (hand.GetCard(i).Suit != hand.GetCard(i+1).Suit)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
