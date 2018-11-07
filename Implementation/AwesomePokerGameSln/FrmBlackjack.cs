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
    public partial class FrmBlackjack : Form
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
        private int playerHighAce;
        private int dealerHighAce;
        private bool playerWins;
        private bool dealerWins;
        private int playerRevealedCount;

        public FrmBlackjack()
        {
            InitializeComponent();
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
            redealButton.Enabled = false;
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
                if (index > 2)
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
            
            dealerCardPics[1].Visible = true;

            //Dealer logic. If the first two cards add up to less than 17, hit until they do.
            int i = 2;
            if (dealerHighAce > 0 && dealerValue > 21)
            {
                dealerHighAce--;
                dealerValue -= 10;
            }
            while (dealerValue < 17)
            {
                if (i == 5)
                    break;
                dealerValue += dealerNums[i];

                if (dealerNums[i] == 11)
                    dealerHighAce++;

                dealerCardPics[i].Visible = true;
                if (dealerHighAce > 0 && dealerValue > 21)
                {
                    dealerHighAce--;
                    dealerValue -= 10;
                }
                i++;
            }
            if (dealerValue == 21)
                dealerWins = true;

            EvaluateGameState();
        }

        private void SetBoard()
        {
            dealerValue = 0;
            dealerWins = false;
            dealerNums = new int[5];
            dealerHighAce = 0;

            for (int j = 0; j < dealerNums.Length; j++)
            {
                dealerNums[j] = dealerHand.GetCardI(j).Item1;
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
                }
            }
            dealerValue += (dealerNums[0] + dealerNums[1]);

            if (dealerNums[0] == 11)
                dealerHighAce++;
            if (dealerNums[1] == 11)
                dealerHighAce++;

            if (dealerValue > 21 && dealerHighAce > 0)
            {
                dealerHighAce--;
                dealerValue -= 10;
            }

            //Player logic. 
            playerValue = 0;
            playerHighAce = 0;
            playerWins = false;
            playerNums = new int[5];

            for (int j = 0; j < playerNums.Length; j++)
            {
                playerNums[j] = playerHand.GetCardI(j).Item1;
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
                    playerHighAce++;
                }
            }
            playerValue += (playerNums[0] + playerNums[1]);
            playerRevealedCount = 2;
            if (playerValue == 21)
            {
                playerWins = true;
            }
            else if (playerValue >= 21)
            {
                hitButton.Enabled = false;
                stayButton.Enabled = false;
            }

            if (!hitButton.Enabled)
                DealerPlay();
        }

        private void EvaluateGameState()
        {

            if (playerRevealedCount == 5 && playerValue <= 21)
                chatBox.Items.Add("Dealer: You win!");
            else if (playerValue == dealerValue)
                chatBox.Items.Add("It's a tie!");
            else if (playerWins && dealerWins)
                chatBox.Items.Add("Dealer: It's a tie!");
            else if (dealerWins || playerValue > 21)
                chatBox.Items.Add("Dealer: I win!");
            else if (playerWins || dealerValue > 21)
                chatBox.Items.Add("Dealer: You win!");
            else if (playerValue > dealerValue)
                chatBox.Items.Add("Dealer: You win!");
            else if (playerValue < dealerValue)
                chatBox.Items.Add("Dealer: I win!");
            chatBox.TopIndex = chatBox.Items.Count - 1;


            redealButton.Enabled = true;
            hitButton.Enabled = false;
            stayButton.Enabled = false;

        }


        private void FrmBlackjack_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            typeBox.Text = "Enter a message:";
            typeBox.ForeColor = Color.Gray;
            chatBox.TopIndex = chatBox.Items.Count - 1;
        }

        // Start a new game, reset all vals
        private void redealButton_Click(object sender, EventArgs e)
        {
            chatBox.Items.Add("Dealer: GoodLuck!");
            redealButton.Enabled = false;
            hitButton.Enabled = true;
            stayButton.Enabled = true;

            DealCards();
            SetBoard();
            chatBox.TopIndex = chatBox.Items.Count - 1;
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            if (playerNums[playerRevealedCount] == 11)
            {
                playerHighAce++;
            }

            playerValue += playerNums[playerRevealedCount];

            if (playerHighAce > 0 && playerValue > 21)
            {
                playerHighAce--;
                playerValue -= 10;
            }
            if (playerValue == 21)
            {
                playerWins = true;
            }
            playerCardPics[playerRevealedCount].Visible = true;

            playerRevealedCount++;
            if (playerValue > 21 || playerRevealedCount == 5)
            {
                hitButton.Enabled = false;
                stayButton.Enabled = false;
                
                if (playerValue > 21)
                {
                    playerWins = false;
                    EvaluateGameState();
                    return;
                }
            }
            

            if (!hitButton.Enabled)
            {
                DealerPlay();
            }
        }

        private void stayButton_Click(object sender, EventArgs e)
        {
            DealerPlay();
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
