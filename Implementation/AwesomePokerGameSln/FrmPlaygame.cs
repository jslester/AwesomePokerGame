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
        private int betVal = 0;
        private int walletVal = 0;
        private int poolVal = 0;
        Random rand = new Random();
        int dealBet;

        public FrmPlaygame()
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
            betNum.Text = "$" + betVal.ToString();
            walletNum.Text = "$" + walletVal.ToString();
            poolNum.Text = "$" + poolVal.ToString();
            dealerHandType.Text = "DEALER";
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

            // dealer makes his bet
            chatBox.Items.Add("Dealer: Place your bets!");
            dealBet = 5 * rand.Next(20, 200);
            poolVal = +dealBet;
            poolNum.Text = "$" + poolVal.ToString();
            chatBox.Items.Add(string.Format("Dealer added ${0} to pool", dealBet));
            poolNum.Update();
        }

        private void CheckHand()
        {
            Tuple<HandType, double> playerHT, dealerHT;
            String resultString = "IM MAD WHY WASNT I SET";
            
            dealerHT = dealerHand.getHandType();
            playerHT = playerHand.getHandType();
            playerHandType.Text = playerHT.Item1.ToString();
            
            
                chatBox.Items.Add("Dealer: " + dealerHT.Item2 + "(" + dealerHandType.Text + ")");
                chatBox.Items.Add("Player: " + playerHT.Item2 + "(" + playerHandType.Text + ")");

                if (playerHT.Item2 > dealerHT.Item2)
                {
                    resultString = "Player Wins!";
                    // award player's wallet pool
                    walletVal += poolVal;
                    walletNum.Text = "$" + walletVal.ToString();
                    chatBox.Items.Add(string.Format("Player awarded ${0}", poolVal.ToString()));
                    poolVal = 0;
                    poolNum.Text = "$" + poolVal.ToString();
                }
                else if (playerHT.Item2 < dealerHT.Item2)
                {
                    resultString = "Dealer Wins!";
                    // reset pool (aka other player awarded pool)
                    chatBox.Items.Add(string.Format("Dealer awarded ${0}", poolVal.ToString()));
                    poolVal = 0;
                    poolNum.Text = "$" + poolVal.ToString();
                }
                else
                {
                    resultString = "It's a tie!";
                }


            if(replaceCards.Enabled == false)
                chatBox.Items.Add(resultString);

            chatBox.TopIndex = chatBox.Items.Count - 1;
        }

        // Start a new game, reset all vals
        private void redealButton_Click(object sender, EventArgs e)
        {

            chatBox.Items.Add("Dealer: GoodLuck!");
            redealButton.Enabled = false;
            replaceCards.Enabled = true;
            foldButton.Enabled = true;
            dealerHandType.Text = "DEALER";
            foreach (PictureBox singlebox in playerCardPics)
            {
                singlebox.Enabled = true;
            }

            DealCards();
        }

        // Stage 2 of the game, player and dealer trade in cards and recheck their hands
        private void ReplaceSelectedCards(object sender, EventArgs e)
        {
            // Disable buttons upon click
            // Deliberately excluding Redeal button until end of function for security
            foldButton.Enabled = false;
            replaceCards.Enabled = false;
                        

            // Dealer acts, replaces "trash cards"
            CardType[] dcards = new CardType[5];
            List<CardType> trash = dealerHand.GetTrash();
            for(int k=0; k <5; k++)
            {
                if (trash.Contains(dealerHand.GetCardI(k)))
                {
                    CardType newCard = deck.NextCard();
                    dcards[k] = newCard;
                    dealerCardPics[k].BackgroundImage = CardImageHelper.cardToBitmap(newCard);
                }
                else
                {
                    dcards[k] = dealerHand.GetCardI(k);
                }

            }
            dealerHand = new Hand(dcards); // Give the player their new hand
            // Dealer's selected cards are changed out

            // Player acts, replaces selected cards
            if (selectedCards.Count == 0) // Nothing selected, just return
            {
                CheckHand();
                dealerHandType.Text = dealerHand.getHandType().Item1.ToString();
                // Enable after all else is done
                redealButton.Enabled = true;
                return;
            }

            CardType[] pcards = new CardType[5];
            int i = 0;
            foreach (PictureBox playerCardPic in playerCardPics) // Loop through players cards
            {
                if (selectedCards.Contains(playerCardPic)) // If the players card is selected, replace it with a new card and fix its placement
                {
                    CardType card = deck.NextCard();
                    //CardType card = new CardType(index, inde);
                    pcards[i] = card;
                    playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);

                    playerCardPic.Location = new Point(playerCardPic.Location.X, playerCardPic.Location.Y + 10);
                }
                else // Otherwise just pass the card on
                {
                    pcards[i] = playerHand.GetCardI(i);
                }
                i++;
            }
            playerHand = new Hand(pcards); // Give the player their new hand
            
            selectedCards = new List<PictureBox>(); // Clear selectedCards
            CheckHand();
            dealerHandType.Text = dealerHand.getHandType().Item1.ToString();

            // Enable after all else is done
            redealButton.Enabled = true;
            playerHand.getHandType();
            dealerHand.getHandType();
        }


        ///////////////////////////
        // Chatbox Segment
        ///////////////////////////
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

        // "Selecting" a card to replace
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

        // Fold your hand, dealer automatically wins
        private void foldButton_Click(object sender, EventArgs e)
        {
            foldButton.Enabled = false;
            replaceCards.Enabled = false;
            redealButton.Enabled = true;

            // Disable and reset selecting cards
            foreach (PictureBox singlebox in playerCardPics)
            {
                if (selectedCards.Contains(singlebox))
                {
                    singlebox.Location = new Point(singlebox.Location.X, singlebox.Location.Y + 10);
                }
                singlebox.Enabled = false;

                selectedCards.Remove(singlebox);
            }
            chatBox.Items.Add("Player Folds, Dealer Wins!");
            // reset pool (aka other player awarded pool)
            chatBox.Items.Add(string.Format("Dealer awarded ${0}", poolVal.ToString()));
            poolVal = 0;
            poolNum.Text = "$" + poolVal.ToString();
            chatBox.TopIndex = chatBox.Items.Count - 1;
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

        ///////////////////////////
        // Betting
        ///////////////////////////
        
        // Place bet
        private void placeBetButton_Click(object sender, EventArgs e)
        {
            chatBox.Items.Add(string.Format("Player added ${0} to pool",betVal));
            poolVal = poolVal + betVal;
            poolNum.Text = "$" + poolVal.ToString();
            poolNum.Update();
            betVal = 0;
            betNum.Text = "$" + betVal.ToString();
            betNum.Update();
        }

        private void resetBetButton_Click(object sender, EventArgs e)
        {
            walletVal += betVal;
            walletNum.Text = "$" + walletVal.ToString();
            walletNum.Update();

            betVal = 0;
            betNum.Text = "$" + betVal.ToString();
            betNum.Update();
        }
        // Winning Hand 

        // Clicking chips
        private void fiveChip_Click(object sender, EventArgs e)
        {
            if(walletVal > 0 && walletVal-5 >= 0)
            {
                walletVal -= 5;
                betVal += 5;
                walletNum.Text = "$" + walletVal.ToString();
                walletNum.Update();
                betNum.Text = "$" + betVal.ToString();
                betNum.Update();
            }
            else
            {
                chatBox.Items.Add("Insufficient Funds. Please add more.");
            }
        }

        private void tenChip_Click(object sender, EventArgs e)
        {
            if (walletVal > 0 && walletVal - 10 >= 0)
            {
                walletVal -= 10;
                betVal += 10;
                walletNum.Text = "$" + walletVal.ToString();
                walletNum.Update();
                betNum.Text = "$" + betVal.ToString();
                betNum.Update();
            }
            else
            {
                chatBox.Items.Add("Insufficient Funds. Please add more.");
            }
        }

        private void twentyFiveChip_Click(object sender, EventArgs e)
        {
            if (walletVal > 0 && walletVal - 25 >= 0)
            {
                walletVal -= 25;
                betVal += 25;
                walletNum.Text = "$" + walletVal.ToString();
                walletNum.Update();
                betNum.Text = "$" + betVal.ToString();
                betNum.Update();
            }
            else
            {
                chatBox.Items.Add("Insufficient Funds. Please add more.");
            }
        }

        private void fiftyChip_Click(object sender, EventArgs e)
        {
            if (walletVal > 0 && walletVal - 50 >= 0)
            {
                walletVal -= 50;
                betVal += 50;
                walletNum.Text = "$" + walletVal.ToString();
                walletNum.Update();
                betNum.Text = "$" + betVal.ToString();
                betNum.Update();
            }
            else
            {
                chatBox.Items.Add("Insufficient Funds. Please add more.");
            }
        }

        private void hundredChip_Click(object sender, EventArgs e)
        {
            if (walletVal > 0 && walletVal - 100 >= 0)
            {
                walletVal -= 100;
                betVal += 100;
                walletNum.Text = "$" + walletVal.ToString();
                walletNum.Update();
                betNum.Text = "$" + betVal.ToString();
                betNum.Update();
            }
            else
            {
                chatBox.Items.Add("Insufficient Funds. Please add more.");
            }
        }

        private void addFundsChip_Click(object sender, EventArgs e)
        {
            AddFunds addFunds = new AddFunds();
            addFunds.ShowDialog();
            int addedFunds = addFunds.value;
            switch (addedFunds)
            {
                case 100:
                    walletVal += 100;
                    walletNum.Text = "$" + walletVal.ToString();
                    walletNum.Update();
                    break;
                case 500:
                    walletVal += 500;
                    walletNum.Text = "$" + walletVal.ToString();
                    walletNum.Update();
                    break;
                case 1000:
                    walletVal += 1000;
                    walletNum.Text = "$" + walletVal.ToString();
                    walletNum.Update();
                    break;
                default:
                    walletVal += 0;
                    walletNum.Text = "$" + walletVal.ToString();
                    walletNum.Update();
                    break;
            }

        }

        ////////////////////
        // Backend Handlers
        ////////////////////
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
    }
}
