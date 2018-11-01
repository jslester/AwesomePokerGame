using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code {
    
    public enum HandType 
    {
        HIGH,
        ONE_PAIR,
        TWO_PAIRS,
        THREE,
        STRAIGHT,
        FLUSH,
        FULL_HOUSE,
        FOUR,
        STR_FLUSH,
        ROYAL_FLUSH
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

    public Tuple<HandType, float> getHandType() {
      HandType handType;
      float rawValue = 0;
      int ct, myNum = -1, myNum2 = -1; 
      handType = HandType.HIGH;
      // trash cards evaluated at the end since it is a default case
      trashCards.Clear();

      int[] faces = cards.Select(card => card.Item1).ToArray();
      List<int> sortedNums = faces.ToList();
      sortedNums.Sort();
      int uniqueCount = faces.Distinct().Count();
      
      for (int i=1; i<cards.Length+1; i++)
      {
        rawValue += (float)(sortedNums[i-1] / (Math.Pow(10,i*2)));
      }

      switch (uniqueCount) {
        // flush, straight, str_flush, ryl_flush
        case 5: {
            // flush
            int[] suits = cards.Select(card => card.Item2).ToArray();
            if (suits.Distinct().Count() == 1) {
              handType = HandType.FLUSH;
              rawValue = (int)handType;
              for (int i=1; i<cards.Length+1; i++)
              {
                rawValue += (float)(sortedNums[i-1] / (Math.Pow(10,i*2)));
              }
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
              rawValue = (int)handType;
              for (int i=1; i<cards.Length+1; i++)
              {
                rawValue += (float)(sortedNums[i-1] / (Math.Pow(10,i*2)));
              }
              // No cards to trash
            }
          }
          break;

        case 4:
            // one pair
            handType = HandType.ONE_PAIR;
            foreach (Tuple<int,int> item in cards){
                ct = cards.Count(card => card.Item1 == item.Item1);
                if(ct == 1){
                    trashCards.Add(item);
                }
                else if (ct == 2)
                {
                  myNum = item.Item1;
                  rawValue = (int)handType;
                  rawValue += (float)((item.Item1) / (Math.Pow(10,1*2)));   
                }
            }

            sortedNums.RemoveAll(item => item == myNum);

            for (int i=2; i<cards.Length+1; i++)
            {
              rawValue += (float)(sortedNums[i-2] / (Math.Pow(10,i*2)));
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
                rawValue = (int)handType;
                foreach (Tuple<int,int> item in cards){
                  ct = cards.Count(card => card.Item1 == item.Item1);
                  if(ct == 1){
                    trashCards.Add(item);
                  }
                  else if (ct == 2)
                  {
                    if (myNum == -1)
                      myNum = item.Item1;
                    else if (myNum2 == -1 && item.Item1 != myNum)
                      myNum2 = item.Item1;
                  
                       
                  }
                }
                if (myNum > myNum2)
                {
                  rawValue += (float)((myNum) / (Math.Pow(10,1*2)));
                  rawValue += (float)((myNum2) / (Math.Pow(10,2*2)));
                }
                else //if (myNum < myNum2)
                {
                  rawValue += (float)((myNum2) / (Math.Pow(10,1*2)));
                  rawValue += (float)((myNum) / (Math.Pow(10,2*2)));
                }
                sortedNums.RemoveAll(item => item == myNum);
                sortedNums.RemoveAll(item => item == myNum2);

                for (int i=3; i<cards.Length+1; i++)
                {
                  rawValue += (float)(sortedNums[i-3] / (Math.Pow(10,i*2)));
                }
              }
              else {
                handType = HandType.THREE;
                foreach (Tuple<int,int> item in cards){
                  ct = cards.Count(card => card.Item1 == item.Item1);
                  if(ct == 1){
                    trashCards.Add(item);
                  }
                  else if (ct == 3)
                  {
                    myNum = item.Item1;
                    rawValue = (int)handType;
                    rawValue += (float)((item.Item1) / (Math.Pow(10,1*2)));   
                  }
                }

                sortedNums.RemoveAll(item => item == myNum);

                for (int i=0; i<=cards.Length; i++)
                {
                  rawValue += (float)(sortedNums[i] / (Math.Pow(10,(i+3)*2)));
                }
              }
            }
            else if (freq == 2) {
              handType = HandType.TWO_PAIRS;
                rawValue = (int)handType;
                foreach (Tuple<int,int> item in cards){
                  ct = cards.Count(card => card.Item1 == item.Item1);
                  if(ct == 1){
                    trashCards.Add(item);
                  }
                  else if (ct == 2)
                  {
                    if (myNum == -1)
                      myNum = item.Item1;
                    else if (myNum2 == -1 && item.Item1 != myNum)
                      myNum2 = item.Item1;
                  
                       
                  }
                }
                if (myNum > myNum2)
                {
                  rawValue += (float)((myNum) / (Math.Pow(10,1*2)));
                  rawValue += (float)((myNum2) / (Math.Pow(10,2*2)));
                }
                else //if (myNum < myNum2)
                {
                  rawValue += (float)((myNum2) / (Math.Pow(10,1*2)));
                  rawValue += (float)((myNum) / (Math.Pow(10,2*2)));
                }
                sortedNums.RemoveAll(item => item == myNum);
                sortedNums.RemoveAll(item => item == myNum2);

                rawValue += (float)(sortedNums[0] / (Math.Pow(10,3*2)));
                
            }
            else if (freq == 3) {
              handType = HandType.THREE;
                foreach (Tuple<int,int> item in cards){
                  ct = cards.Count(card => card.Item1 == item.Item1);
                  if(ct == 1){
                    trashCards.Add(item);
                  }
                  else if (ct == 3)
                  {
                    myNum = item.Item1;
                    rawValue = (int)handType;
                    rawValue += (float)((item.Item1) / (Math.Pow(10,1*2)));   
                  }
                }

                sortedNums.RemoveAll(item => item == myNum);

                for (int i=0; i<=cards.Length; i++)
                {
                  rawValue += (float)(sortedNums[i] / (Math.Pow(10,(i+3)*2)));
                }
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
              rawValue = (int)handType;
              bool flagTwo = false, flagThree = false;
              foreach (Tuple<int,int> item in cards){
                ct = cards.Count(card => card.Item1 == item.Item1);
                  if(ct == 2 && !flagTwo)
                  {
                    flagTwo = true;
                    rawValue += (float)((item.Item1) / (Math.Pow(10,2*2)));
                  }
                  else if (ct == 3 && !flagThree)
                  {
                    flagThree = true;
                    rawValue += (float)((item.Item1) / (Math.Pow(10,1*2)));   
                  }
                }
            }
            else {
              handType = HandType.FOUR;
              foreach (Tuple<int,int> item in cards){
                ct = cards.Count(card => card.Item1 == item.Item1);
                  if (ct == 4)
                  {
                    myNum = item.Item1;
                    rawValue = (int)handType;
                    rawValue += (float)((item.Item1) / (Math.Pow(10,1*2)));   
                  }
                }

                sortedNums.RemoveAll(item => item == myNum);

                for (int i=0; i<=cards.Length; i++)
                {
                  rawValue += (float)(sortedNums[i] / (Math.Pow(10,(i+2)*2)));
                }
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
      return new Tuple<HandType, float>(handType, rawValue);
    }
  }
}
