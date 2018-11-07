using AwesomePokerGameSln.Code;
using AwesomePokerGameSln;
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
    public partial class FrmShit : Form
    {
        private Deck deck;
        private PictureBox[] playerCardPics;
        private PictureBox[] dealerCardPics;
        private Hand playerHand;
        private Hand dealerHand;
        private int[] playerNums;
        private int[] dealerNums;
        private int playerValue;
        private int dealerValue;
        private bool playerHighAce;
        private bool dealerHighAce;
        private bool playerWins;
        private bool dealerWins;
        private int playerRevealedCount;

        public FrmShit()
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

        private void DealCards()
        {
            deck.ShuffleDeck();
            Tuple<int, int>[] cards = new Tuple<int, int>[5];
            int index = 0;
            foreach (PictureBox playerCardPic in playerCardPics)
            {
                CardType card = deck.NextCard();
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
                CardType card = deck.NextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
                if (index > 1)
                {
                    dealerCardPic.Visible = false;
                }
                dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            dealerHand = new Hand(cards);

            SetBoard();
        }

        private void DealerPlay()
        {
            //Dealer logic
            dealerValue = 0;
            dealerHighAce = false;
            

            //Dealer logic. If the first two cards add up to less than 17, hit until they do.
            int i = 2;
            if (dealerHighAce == true && dealerValue > 21)
            {
                dealerHighAce = false;
                dealerValue -= 10;
            }
            if (dealerValue == 21)
            {
                dealerWins = true;
            }
            while (dealerValue < 17)
            {
                dealerValue += dealerNums[i];
                dealerCardPics[i].Visible = true;
                if (dealerHighAce == true && dealerValue > 21)
                {
                    dealerHighAce = false;
                    dealerValue -= 10;
                }
                i++;
            }
            EvaluateGameState();
        }

        private void SetBoard()
        {
            dealerWins = false;
            dealerNums = new int[5];

            for (int j = 0; j < dealerNums.Length; j++)
            {
                dealerNums[j] = dealerHand.GetCardI(j).Item2;
            }

            //Replace array values for faces with actual values
            for (int j = 0; j < 5; j++)
            {
                if (dealerNums[j] < 9)
                    dealerNums[j] += 2;
                else if (dealerNums[j] >= 9 && dealerNums[j] < 12)
                    dealerNums[j] = 10;
                else
                {
                    //Assume high ace until proven otherwise
                    dealerNums[j] = 11;
                    dealerHighAce = true;
                }
            }
            dealerValue += (dealerNums[0] + dealerNums[1]);

            //Player logic. 
            playerValue = 0;
            playerHighAce = false;
            playerWins = false;
            playerNums = new int[5];

            for (int j=0; j<playerNums.Length; j++)
            {
                playerNums[j] = playerHand.GetCardI(j).Item2;
            }

            for (int k = 0; k < 5; k++)
            {
                if (playerNums[k] < 9)
                    playerNums[k] += 2;
                else if (playerNums[k] >= 9 && playerNums[k] < 12)
                    playerNums[k] = 10;
                else
                {
                    playerNums[k] = 11;
                    playerHighAce = true;
                }
            }
            playerValue += (playerNums[0] + playerNums[1]);
            playerRevealedCount = 2;
            if(playerValue == 21)
            {
                playerWins = true;
            }
            else if(playerValue >= 21)
            {
                hitButton.Enabled = false;
            }

            if (!hitButton.Enabled)
                EvaluateGameState();
        }

        private void EvaluateGameState()
        {
            
            if (playerWins && dealerWins)
                chatBox.Items.Add("Dealer: It's a tie!");
            else if (dealerWins || playerValue > 21)
                chatBox.Items.Add("Dealer: I win!");
            else if (playerWins || dealerValue > 21)
                chatBox.Items.Add("Dealer: You win!");
            

        }


        private void FrmBlackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                f.Close();
        }

        private void FrmBlackjack_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            DealCards();
        }
        //Need to add a way to disable clicking cards after new hand is dealt
        //Need to figure out if can stop from pressing more than once. Maybe change/ check the y value?

        private void chatSendButton_Click(object sender, EventArgs e)
        {
            chatBox.Items.Add("Me: " + typeBox.Text);
            typeBox.Text = "";
        }

        // Start a new game, reset all vals
        private void redealButton_Click(object sender, EventArgs e)
        {

            chatBox.Items.Add("Dealer: GoodLuck!");
            redealButton.Enabled = false;
            foldButton.Enabled = true;
            foreach (PictureBox singlebox in playerCardPics)
            {
                singlebox.Enabled = true;
            }

            DealCards();
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            if (playerNums[playerRevealedCount] == 11)
            {
                playerHighAce = true;
            }

            playerValue += playerNums[playerRevealedCount];

            if (playerHighAce && playerValue > 21)
            {
                playerHighAce = false;
                playerValue -= 10;
            }
            if (playerValue == 21)
            {
                playerWins = true;
            }
            playerCardPics[playerRevealedCount].Visible = true;
            
            if (playerValue > 21)
            {
                hitButton.Enabled = false;
            }
            playerRevealedCount++;

            if (!hitButton.Enabled)
            {
                EvaluateGameState();
            }
        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            EvaluateGameState();   
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
