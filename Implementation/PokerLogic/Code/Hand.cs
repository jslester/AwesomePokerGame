using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code {
  public enum HandType {
    ROYAL_FLUSH,
    STR_FLUSH,
    FOUR,
    FULL_HOUSE, // DOESNT WORK
    FLUSH,
    STRAIGHT,
    THREE,
    TWO_PAIRS,
    ONE_PAIR,
    HIGH
  }

  public class Hand {
    private Tuple<int, int>[] cards;
    private List<Tuple<int,int>> trashCards;
        public int GetLength()
        {
            return cards.Length;
        }

        public Tuple<int, int> GetCardI (int index)
        {
            return cards[index];
        }

    public Hand(Tuple<int, int>[] cards) {
        trashCards = new List<Tuple<int, int>>();
        this.cards = cards;
    }

    public HandType getHandType() {
      HandType handType = HandType.HIGH;
      // trash cards evaluated at the end since it is a default case
      trashCards.Clear();

      int[] faces = cards.Select(card => card.Item1).ToArray();
      int uniqueCount = faces.Distinct().Count();
      switch (uniqueCount) {
        // flush, straight, str_flush, ryl_flush
        case 5: {
            // flush
            int[] suits = cards.Select(card => card.Item2).ToArray();
            if (suits.Distinct().Count() == 1) {
              handType = HandType.FLUSH;
              // No cards to trash
            }

            // straight
            Array.Sort(faces);
            int min = faces[0];
            int max = faces[faces.Length - 1];
            // A 2 3 4 5
            if ((max == 12 && faces[faces.Length - 2] == 3) ||
                 max - min == faces.Length - 1) {
              if (handType == HandType.FLUSH) {
                if (max == 12 && faces[faces.Length - 2] == 11)
                  handType = HandType.ROYAL_FLUSH;
                else
                  handType = HandType.STR_FLUSH;
              }
              else {
                handType = HandType.STRAIGHT;
              }
              // No cards to trash
            }
          }
          break;

        case 4:
            // one pair
            handType = HandType.ONE_PAIR;
            int ct;
            foreach (Tuple<int,int> item in cards){
                ct = cards.Count(card => card.Item1 == item.Item1);
                if(ct == 1){
                    trashCards.Add(item);
                }  
            }


            break;

        case 3: {
            // two pair, three of a kind
            int x = faces[0];
            int freq = cards.Count(card => card.Item1 == x);
            if (freq == 1) {
              x = faces[1];
              freq = cards.Count(card => card.Item1 == x);
              if (freq == 2) {
                handType = HandType.TWO_PAIRS;
              }
              else {
                handType = HandType.THREE;
              }
            }
            else if (freq == 2) {
              handType = HandType.TWO_PAIRS;
            }
            else if (freq == 3) {
              handType = HandType.THREE;
            }
            // Trash any single occurence cards
            foreach (Tuple<int,int> item in cards){
                ct = cards.Count(card => card.Item1 == item.Item1);
                if(ct == 1){
                    trashCards.Add(item);
                }  
            }

          }
          break;

        // full house or four of a kind
        case 2: {
            int x = faces[0];
            int freq = cards.Count(card => card.Item1 == faces[0]);
            if (freq == 2 || freq == 3) {
              handType = HandType.FULL_HOUSE;
            }
            else {
              handType = HandType.FOUR;
            }
          }
          // No beneficial cards to trash (replacing a card in FOUR does nothing)

          break;

      }

      if(handType == HandType.HIGH){
            int highCard = 0;
            foreach(Tuple<int,int> item in cards){
                if(item.Item1 > highCard)
                        highCard = item.Item1;
            }
            foreach(Tuple<int,int> item in cards){
                if(item.Item1 != highCard)
                        trashCards.Add(item);
            }
      }

      return handType;
    }
  }
}
