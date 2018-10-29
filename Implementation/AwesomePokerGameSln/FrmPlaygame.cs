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

namespace AwesomePokerGameSln {
    public partial class FrmPlaygame : Form {
        private Deck deck;
        private PictureBox[] playerCardPics;
        private PictureBox[] dealerCardPics;
        private Hand playerHand;
        private Hand dealerHand;
        private List<PictureBox> selectedCards = new List<PictureBox>();

        public FrmPlaygame() {
            InitializeComponent();
            playerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++) {
                playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
            }
            dealerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++) {
                dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
            }
        }

        private void dealCards() {
            replaceCards.Enabled = true;
            deck.shuffleDeck();
            Tuple<int, int>[] cards = new Tuple<int, int>[5];
            int index = 0;
            foreach (PictureBox playerCardPic in playerCardPics) {
                CardType card = deck.nextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
                playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            playerHand = new Hand(cards);
            cards = new CardType[5];
            index = 0;
            foreach (PictureBox dealerCardPic in dealerCardPics) {
                CardType card = deck.nextCard();
                //CardType card = new CardType(index, inde);
                cards[index++] = card;
                dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }
            dealerHand = new Hand(cards);
            CheckHand();

            
        }

        private void CheckHand()
        {
            HandType playerHT, dealerHT;
            String resultString = "IM MAD WHY WASNT I SET";

            playerHT = playerHand.getHandType();
            dealerHT = dealerHand.getHandType();

            playerHandType.Text = playerHT.ToString();
            dealerHandType.Text = dealerHT.ToString();

            chatBox.Items.Add("Player: " + (int)playerHT + "(" + playerHandType.Text + ")");
            chatBox.Items.Add("Dealer: " + (int)dealerHT + "(" + dealerHandType.Text + ")");

            if ((int)playerHT < (int)dealerHT)
            {
                resultString = "Player Wins!";
            }
            else if ((int)playerHT > (int)dealerHT)
            {
                resultString = "Dealer Wins!";
            }
            else
            {
                resultString = "It's a tie!";
            }
            chatBox.Items.Add(resultString);
        }

        private void ReplaceSelectedCards(object sender, EventArgs e)
        {

            if (selectedCards.Count == 0)
            {
                return;
            }
            int i;
            List<int> indexes = new List<int>();
            CardType[] cards = new CardType[5];
            foreach (PictureBox cardToReplace in selectedCards)
            {
                i = 0;
                foreach (PictureBox myCard in playerCardPics)
                {
                    if (cardToReplace.Name.Equals(myCard.Name))
                    {
                        indexes.Add(i);
                    }
                    i++;
                }
            }
            i = 0;
            foreach (PictureBox playerCardPic in playerCardPics)
            {
                if (indexes.Contains(i))
                {
                    CardType card = deck.nextCard();
                    //CardType card = new CardType(index, inde);
                    cards[i] = card;
                    playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
                }
                else
                {
                    cards[i] = playerHand.GetCardI(i);
                }
                i++;
            }
            playerHand = new Hand(cards);
            
            foreach (PictureBox singlebox in playerCardPics)
            {
                if (selectedCards.Contains(singlebox))
                {
                    singlebox.Location = new Point(singlebox.Location.X, singlebox.Location.Y + 10);
                }
                singlebox.Enabled = false;

            }
            selectedCards = new List<PictureBox>();
            CheckHand();

            foldButton.Enabled = false;
            replaceCards.Enabled = false;
            redealButton.Enabled = true;
        }

        private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e) {
            //foreach (Form f in Application.OpenForms)
            //  f.Close();
            Application.Exit();
        }

        private void FrmPlaygame_Load(object sender, EventArgs e) {
            deck = new Deck();
            dealCards();
            CheckHand();
            redealButton.Enabled = false;
        }
        //Need to add a way to disable clicking cards after new hand is dealt
        //Need to figure out if can stop from pressing more than once. Maybe change/ check the y value?

        private void redealButton_Click(object sender, EventArgs e) {
            chatBox.Items.Add("Dealer: GoodLuck!");
            redealButton.Enabled = false;
            foldButton.Enabled = true;
            foreach (PictureBox singlebox in playerCardPics)
            {
                singlebox.Enabled = true;

            }
            dealCards();
        }

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

				chatBox.Items.Add(picSender.Name + " Selected");

				selectedCards.Add(picSender);
			}
			else
			{
				picSender.Location = new Point(picSender.Location.X, picSender.Location.Y + 10);

				chatBox.Items.Add(picSender.Name + " Unselected");

				selectedCards.Remove(picSender);
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

        }

		private void dealerHandType_Click(object sender, EventArgs e)
		{

		}
	}
}
