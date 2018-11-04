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
    public partial class FrmPlaygame : Form
    {
        private Deck deck;
        private PictureBox[] playerCardPics;
        private PictureBox[] dealerCardPics;
        private Hand playerHand;
        private Hand dealerHand;
        private List<PictureBox> selectedCards = new List<PictureBox>();

        public FrmPlaygame() {
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
        }

        private void DealCards()
        {
            replaceCards.Enabled = true;
            deck.ShuffleDeck();
            CardType[] cards;

            cards = new CardType[5];
            int index = 0;
            foreach (PictureBox playerCardPic in playerCardPics)
            {
                CardType card = deck.NextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
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
                dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            dealerHand = new Hand(cards);

            CheckHand();
        }

        private void CheckHand()
        {
            Tuple<HandType, double> playerHT, dealerHT;
            String resultString = "IM MAD WHY WASNT I SET";

            playerHT = playerHand.getHandType();
            dealerHT = dealerHand.getHandType();

            playerHandType.Text = playerHT.Item1.ToString();
            dealerHandType.Text = dealerHT.Item1.ToString();

            chatBox.Items.Add("Dealer: " + dealerHT.Item2 + "(" + dealerHandType.Text + ")");
            chatBox.Items.Add("Player: " + playerHT.Item2 + "(" + playerHandType.Text + ")");

            if (playerHT.Item2 > dealerHT.Item2)
            {
                resultString = "Player Wins!";
            }
            else if (playerHT.Item2 < dealerHT.Item2)
            {
                resultString = "Dealer Wins!";
            }
            else
            {
                resultString = "It's a tie!";
            }

            if(replaceCards.Enabled == false)
                chatBox.Items.Add(resultString);

            chatBox.TopIndex = chatBox.Items.Count - 1;
        }

        private void ReplaceSelectedCards(object sender, EventArgs e)
        {
            // Disable buttons upon click
            foldButton.Enabled = false;
            replaceCards.Enabled = false;
            redealButton.Enabled = true;
            
            if (selectedCards.Count == 0) // Nothing selected, just return
            {
                CheckHand();
                return;
            }

            CardType[] cards = new CardType[5];

            int i = 0;
            foreach (PictureBox playerCardPic in playerCardPics) // Loop through players cards
            {
                if (selectedCards.Contains(playerCardPic)) // If the players card is selected, replace it with a new card and fix its placement
                {
                    CardType card = deck.NextCard();
                    //CardType card = new CardType(index, inde);
                    cards[i] = card;
                    playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);

                    playerCardPic.Location = new Point(playerCardPic.Location.X, playerCardPic.Location.Y + 10);
                }
                else // Otherwise just pass the card on
                {
                    cards[i] = playerHand.GetCardI(i);
                }
                i++;
            }
            playerHand = new Hand(cards); // Give the player their new hand
            
            selectedCards = new List<PictureBox>(); // Clear selectedCards
            CheckHand();

            // Enable after all else is done
            redealButton.Enabled = true;
        }

        private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e)
        {
            //foreach (Form f in Application.OpenForms)
            //  f.Close();
            Application.Exit();
        }


        private void FrmPlaygame_Load(object sender, EventArgs e)
        {
            deck = new Deck();
            DealCards();
            redealButton.Enabled = false;
        }
        //Need to add a way to disable clicking cards after new hand is dealt
        //Need to figure out if can stop from pressing more than once. Maybe change/ check the y value?

        private void redealButton_Click(object sender, EventArgs e)
        {
            chatBox.Items.Add("Dealer: GoodLuck!");
            redealButton.Enabled = false;
            replaceCards.Enabled = true;
            foldButton.Enabled = true;
            foreach (PictureBox singlebox in playerCardPics)
            {
                singlebox.Enabled = true;

            }
            DealCards();
        }

        private void chatSendButton_Click(object sender, EventArgs e)
        {
            AddtoChat();
            typeBox.Text = "Enter a message:";
            typeBox.ForeColor = Color.Gray;
        }

        private void AddtoChat()
        {
            if (VulgarityCheck())
            {
                chatBox.Items.Add("Your message was not sent! Please refrain from swearing!");
            }
            else
            {
                chatBox.Items.Add("Me: " + typeBox.Text);
            }
            typeBox.Text = "";
            chatBox.TopIndex = chatBox.Items.Count - 1;

        }

        private bool VulgarityCheck()
        {
            string textFile = Properties.Resources.blacklistWords;
            string[] swearWordList = textFile.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            foreach (string swearWord in swearWordList)
            {
                string test = typeBox.Text;

                if (test.IndexOf(swearWord, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    return true;
                }
            }
            return false;
        }

        private void CardClickHandler(object sender, EventArgs e)
        {
            if(replaceCards.Enabled)
            {
                PictureBox picSender = (PictureBox)sender;
			    if (!selectedCards.Contains(picSender))
			    {
				    picSender.Location = new Point(picSender.Location.X, picSender.Location.Y - 10);

				    chatBox.Items.Add(picSender.Name + " Selected");

				    selectedCards.Add(picSender);
			    }
			    else
			    {
				    picSender.Location = new Point(picSender.Location.X, picSender.Location.Y + 10);

				    chatBox.Items.Add(picSender.Name + " Unselected");

				    selectedCards.Remove(picSender);
			    }
                chatBox.TopIndex = chatBox.Items.Count - 1;
            }
        }

        private void foldButton_Click(object sender, EventArgs e)
        {
            foldButton.Enabled = false;
            replaceCards.Enabled = false;
            redealButton.Enabled = true;

			foreach (PictureBox singlebox in playerCardPics)
            {
                if (selectedCards.Contains(singlebox))
                {
                    singlebox.Location = new Point(singlebox.Location.X, singlebox.Location.Y + 10);
                }
                singlebox.Enabled = false;

				selectedCards.Remove(singlebox);

            }
            CheckHand();
        }
        private void TypeBox_Press_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddtoChat();
                e.SuppressKeyPress = true;
                
            }
        }




        private void TypeBox_Enter(object sender, EventArgs e)
        {
            if (typeBox.Text == "Enter a message:")
            {
                typeBox.Text = "";

                typeBox.ForeColor = Color.Black;
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
