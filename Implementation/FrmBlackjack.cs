using AwesomePokerGameSln.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardType = System.Tuple<int, int>;

namespace AwesomePokerGameSln
{
    public partial class FrmBlackjack : Form
    {
        private Deck deck;
        private PictureBox[] playerCardPics;
        private PictureBox[] dealerCardPics;
        private Hand playerHand;
        private Hand dealerHand;
        private List<PictureBox> selectedCards = new List<PictureBox>();

        public FrmBlackjack()
        {
            InitializeComponentBlackjack();
            playerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++)
            {
                playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
            }
            dealerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++)
            {
                dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
            }
        }

        private void dealCards()
        {
            deck.shuffleDeck();
            Tuple<int, int>[] cards = new Tuple<int, int>[5];
            int index = 0;
            foreach (PictureBox playerCardPic in playerCardPics)
            {
                CardType card = deck.nextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
                if(index>1)
                {
                    playerCardPic.Visible = false;
                }
                playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            playerHand = new Hand(cards);
            cards = new CardType[5];
            index = 0;
            foreach (PictureBox dealerCardPic in dealerCardPics)
            {
                CardType card = deck.nextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
                if (index > 1)
                {
                    dealerCardPic.Visible = false;
                }
                dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            dealerHand = new Hand(cards);
            CheckHand();
        }

        private void CheckHand()
        {
            String resultString = "IM MAD WHY WASNT I SET";

            //Dealer logic
            int dealerCount = 0;
            bool dealerHighAce = false;
            bool dealerWins = false;
            bool dealerBusts = false;
            int[] dealerCards = dealerHand.Select(card >= card.Item2).ToArray();

            //Replace array values for faces with actual values
            for (int j = 0; j < 5; j++)
            {
                if (dealerCards[j] < 9)
                    dealerCards[j] += 2;
                else if (dealerCards[j] >= 9 && dealerCards[j] < 12)
                    dealerCards[j] = 10;
                else
                {
                    //Assume high ace until proven otherwise
                    dealerCards[j] = 11;
                    dealerHighAce = true;
                }
            }
            dealerCount += (dealerCards[0] + dealerCards[1]);

            //Dealer logic. If the first two cards add up to less than 17, hit until they do.
            int i = 2;
            if(dealerHighAce == true && dealerCount > 21)
            {
                dealerHighAce = false;
                dealerCount -= 10;
            }
            if(dealerCount == 21)
            {
                dealerWins = true;
            }
            while (dealerCount < 17)
            {
                dealerCount += dealerCards[i];
                dealerCardPics[i].Visible = true;
                if (dealerHighAce == true && dealerCount > 21)
                {
                    dealerHighAce = false;
                    dealerCount -= 10;
                }
            }
            if(dealerCount > 21)
            {
                dealerBusts = true;
            }
            
            //Player logic. 
            int playerCount = 0;
            bool playerHighAce = false;
            bool playerWins = false;
            bool playerBusts = false;
            int[] playerCards = playerHand.Select(card => card.Item2).ToArray();

            //Same as above for replacing array values with face values
            for (int k = 0; k < 5; k++)
            {
                if (playererCards[k] < 9)
                    playerCards[k] += 2;
                else if (playerCards[k] >= 9 && playerCards[k] < 12)
                    playerCards[k] = 10;
                else
                {
                    //Assume high ace until proven otherwise
                    playerCards[k] = 11;
                    playerHighAce = true;
                }
            }
            //Win/Lose conditions
            playerCount += (playerCards[0] + playerCards[1]);
            if(playerCount == 21)
            {
                playerWins = true;
            }
            else
            {
                while (playerBusts == false && (hit.Enabled == true || stay.Enabled == false)
                {
                    if(playerCount >= 21)
                    {
                        hit.Enabled = false;
                    }
                }
                
            }

            chatBox.Items.Add("Player: " + playerCount);

            if (playerCount > dealerCount && playerBusts == false)
            {
                resultString = "Player Wins!";
            }
            else if (playerCount < dealerCount && dealerBusts == false)
            {
                resultString = "Dealer Wins!";
            }
            else
            {
                resultString = "It's a tie!";
            }
            chatBox.Items.Add(resultString);
        }


        private void FrmBlackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                f.Close();
        }

        private void FrmBlackjack_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            dealCards();
        }
        //Need to add a way to disable clicking cards after new hand is dealt
        //Need to figure out if can stop from pressing more than once. Maybe change/ check the y value?

        private void chatSendButton_Click(object sender, EventArgs e)
        {
            chatBox.Items.Add("Me: " + typeBox.Text);
            typeBox.Text = "";
        }

        private void cardClickHandler(object sender, EventArgs e)
        {
            PictureBox picSender = (PictureBox)sender;
            if (!selectedCards.Contains(picSender))
            {
                picSender.Location = new Point(picSender.Location.X, picSender.Location.Y - 10);

                chatBox.Items.Add(picSender.Name);

                selectedCards.Add(picSender);
            }

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void foldButton_Click(object sender, EventArgs e)
        {
            foldButton.Enabled = false;
        }

        private void TypeBox_Enter(object sender, EventArgs e)
        {
            if (typeBox.Text == "Enter a message:")
            {
                typeBox.Text = "";

                typeBox.ForeColor = Color.Black;
            }
        }

        private void TypeBox_Press_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chatBox.Items.Add("Me: " + typeBox.Text);
                e.SuppressKeyPress = true;
                typeBox.Text = "";
                chatBox.TopIndex = chatBox.Items.Count - 1;
            }
        }

        private void TypeBox_Leave(object sender, EventArgs e)
        {
            if (typeBox.Text == "")
            {
                typeBox.Text = "Enter a message:";
                typeBox.ForeColor = Color.Gray;
            }
        }
    }
}
