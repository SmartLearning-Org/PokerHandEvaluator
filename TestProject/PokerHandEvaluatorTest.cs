using PokerHandEvaluator;
using Xunit;

namespace TestProject
{
    public class PokerHandEvaluatorTest
    {
        [Fact]
        public void Test_hand_with_no_score()
        {
            Card[] cards = {
                new Card() { Suit = Suit.Diamonds, Value = 5},
                new Card() { Suit = Suit.Hearts, Value = 7},
                new Card() { Suit = Suit.Clubs, Value = 10},
                new Card() { Suit = Suit.Diamonds, Value = 1},
                new Card() { Suit = Suit.Spades, Value = 13},
            };
            Hand hand = new Hand(cards);
            
            int score = HandEvaluator.GetHandScore(hand);

            Assert.Equal(0, score);
        }
    }
}