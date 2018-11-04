using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardType = System.Tuple<int, int>;

namespace AwesomePokerGameSln.Code
{
    public enum HandType
    {
        HIGH,
        ONE_PAIR,
        TWO_PAIRS,
        THREE,
        STRAIGHT,
        FLUSH,
        FULL_HOUSE, // DOESNT WORK
        FOUR,
        STR_FLUSH,
        ROYAL_FLUSH      
    }

    public class Hand
    {
        private CardType[] cards;
        private List<CardType> trashCards;

        // Constructor
        public Hand(CardType[] cards)
        {
            trashCards = new List<CardType>();
            this.cards = cards;
        }

        public CardType GetCardI(int index)
        {
            return cards[index];
        }

        public List<CardType> GetTrash()
        {
            return trashCards;
        }

        public Tuple<HandType, double> getHandType()
        {
            HandType handType = HandType.HIGH;
            // trash cards evaluated at the end since it is a default case
            trashCards.Clear();

            int[] faces = cards.Select(card => card.Item1).ToArray();
            int uniqueCount = faces.Distinct().Count();
            switch (uniqueCount)
            {
                // flush, straight, str_flush, ryl_flush
                case 5:
                {
                    // flush
                    int[] suits = cards.Select(card => card.Item2).ToArray();
                    if (suits.Distinct().Count() == 1)
                    {
                        handType = HandType.FLUSH;
                        // No cards to trash
                    }
                    // straight
                    Array.Sort(faces);
                    int min = faces[0];
                    int max = faces[faces.Length - 1];
                    // A 2 3 4 5
                    if ((max == 12 && faces[faces.Length - 2] == 3) || max - min == faces.Length - 1)
                    {
                        if (handType == HandType.FLUSH)
                        {
                            if (max == 12 && faces[faces.Length - 2] == 11)
                                handType = HandType.ROYAL_FLUSH;
                            else
                                handType = HandType.STR_FLUSH;
                        }
                        else
                        {
                            handType = HandType.STRAIGHT;
                        }
                        // No cards to trash
                    }
                }
                break;

                case 4:
                {
                    // one pair
                    handType = HandType.ONE_PAIR;
                    int ct;
                    foreach (CardType item in cards)
                    {
                        ct = cards.Count(card => card.Item1 == item.Item1);
                        if (ct == 1)
                        {
                            trashCards.Add(item);
                        }
                    }
                    break;
                }
                case 3:
                {
                    // two pair, three of a kind
                    int x = faces[0];
                    int freq = cards.Count(card => card.Item1 == x);
                    if (freq == 1)
                    {
                        x = faces[1];
                        freq = cards.Count(card => card.Item1 == x);
                        if (freq == 2)
                        {
                        handType = HandType.TWO_PAIRS;
                        }
                        else
                        {
                        handType = HandType.THREE;
                        }
                    }
                    else if (freq == 2)
                    {
                        handType = HandType.TWO_PAIRS;
                    }
                    else if (freq == 3)
                    {
                        handType = HandType.THREE;
                    }
                    // Trash any single occurence cards
                    int ct;
                    foreach (CardType item in cards)
                    {
                        ct = cards.Count(card => card.Item1 == item.Item1);
                        if(ct == 1)
                        {
                            trashCards.Add(item);
                        }  
                    }

                }
                break;

                // full house or four of a kind
                case 2:
                {
                    int x = faces[0];
                    int freq = cards.Count(card => card.Item1 == faces[0]);
                    if (freq == 2 || freq == 3)
                    {
                    handType = HandType.FULL_HOUSE;
                    }
                    else
                    {
                    handType = HandType.FOUR;
                    }
                }
                // No beneficial cards to trash (replacing a card in FOUR does nothing)
                break;
            }

            if (handType == HandType.HIGH)
            {
                int highCard = 0;
                foreach(CardType item in cards)
                {
                    if(item.Item1 > highCard)
                    highCard = item.Item1;
                }
                foreach(CardType item in cards)
                {
                    if(item.Item1 != highCard)
                    trashCards.Add(item);
                }
            }

            double rawValue = (int)handType + getHandHighValue();

            return new Tuple<HandType, double>(handType, rawValue);
        }

        private double getHandHighValue()
        {
            Dictionary<int, int> cardCounter = new Dictionary<int, int>();
            double decoratorValue = 0;
            int powNum = 2;

            foreach (CardType item in cards)
            {
                if (cardCounter.ContainsKey(item.Item1))
                {
                    cardCounter[item.Item1]++;
                }
                else
                {
                    cardCounter.Add(item.Item1, 1);
                }
            }
            List<List<int>> holder = new List<List<int>>();
            holder.Add(new List<int>());
            holder.Add(new List<int>());
            holder.Add(new List<int>());
            holder.Add(new List<int>());

            foreach (KeyValuePair<int, int> entry in cardCounter)
            {
                holder[entry.Value].Add(entry.Key);
            }
            
            foreach (List<int> nums in holder)
            {
                nums.Sort();
                nums.Reverse();
            }
            holder.Reverse();

            foreach (List<int> valueList in holder)
            {
                foreach (int cardNumber in valueList)
                {
                    decoratorValue += cardNumber / Math.Pow(10, powNum);
                    powNum += 2;
                }
            }

            return decoratorValue;
        }
    }
}
