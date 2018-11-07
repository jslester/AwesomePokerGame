using System;

namespace AwesomePokerGameSln
{
    partial class FrmBlackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCard5 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.redealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.stayButton = new System.Windows.Forms.Button();
            this.playerHandType = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.chatSendButton = new System.Windows.Forms.Button();
            this.dealerHandType = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.DeckImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeckImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard1
            // 
            this.picCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard1.Location = new System.Drawing.Point(76, 219);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(100, 150);
            this.picCard1.TabIndex = 0;
            this.picCard1.TabStop = false;
            // 
            // picCard3
            // 
            this.picCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard3.Location = new System.Drawing.Point(345, 219);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(100, 150);
            this.picCard3.TabIndex = 1;
            this.picCard3.TabStop = false;
            // 
            // picCard4
            // 
            this.picCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard4.Location = new System.Drawing.Point(480, 219);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(100, 150);
            this.picCard4.TabIndex = 2;
            this.picCard4.TabStop = false;
            // 
            // picCard5
            // 
            this.picCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard5.Location = new System.Drawing.Point(619, 219);
            this.picCard5.Name = "picCard5";
            this.picCard5.Size = new System.Drawing.Size(100, 150);
            this.picCard5.TabIndex = 3;
            this.picCard5.TabStop = false;
            // 
            // picCard2
            // 
            this.picCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard2.Location = new System.Drawing.Point(211, 219);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(100, 150);
            this.picCard2.TabIndex = 4;
            this.picCard2.TabStop = false;
            // 
            // redealButton
            // 
            this.redealButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.redealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.redealButton.Location = new System.Drawing.Point(190, 387);
            this.redealButton.Name = "redealButton";
            this.redealButton.Size = new System.Drawing.Size(178, 86);
            this.redealButton.TabIndex = 6;
            this.redealButton.Text = "New Game";
            this.redealButton.UseVisualStyleBackColor = false;
            this.redealButton.Click += new System.EventHandler(this.redealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hitButton.Location = new System.Drawing.Point(585, 387);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(178, 86);
            this.hitButton.TabIndex = 6;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stayButton
            // 
            this.stayButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.stayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.stayButton.Location = new System.Drawing.Point(391, 387);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(178, 86);
            this.stayButton.TabIndex = 6;
            this.stayButton.Text = "Stay";
            this.stayButton.UseVisualStyleBackColor = false;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // playerHandType
            // 
            this.playerHandType.AutoSize = true;
            this.playerHandType.BackColor = System.Drawing.Color.Transparent;
            this.playerHandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHandType.Location = new System.Drawing.Point(72, 408);
            this.playerHandType.Name = "playerHandType";
            this.playerHandType.Size = new System.Drawing.Size(104, 33);
            this.playerHandType.TabIndex = 7;
            this.playerHandType.Text = "Player";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(211, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 150);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(619, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 150);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(480, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 150);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(345, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 150);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(76, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 150);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.Location = new System.Drawing.Point(784, 166);
            this.chatBox.Margin = new System.Windows.Forms.Padding(2);
            this.chatBox.Name = "chatBox";
            this.chatBox.ScrollAlwaysVisible = true;
            this.chatBox.Size = new System.Drawing.Size(228, 251);
            this.chatBox.TabIndex = 13;
            this.chatBox.SelectedIndexChanged += new System.EventHandler(this.chatBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.typeBox.Location = new System.Drawing.Point(784, 421);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(150, 41);
            this.typeBox.TabIndex = 14;
            this.typeBox.Text = "Enter a message:";
            this.typeBox.Enter += new System.EventHandler(this.TypeBox_Enter);
            this.typeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypeBox_Press_Enter);
            this.typeBox.Leave += new System.EventHandler(this.TypeBox_Leave);
            // 
            // chatSendButton
            // 
            this.chatSendButton.Location = new System.Drawing.Point(938, 421);
            this.chatSendButton.Margin = new System.Windows.Forms.Padding(2);
            this.chatSendButton.Name = "chatSendButton";
            this.chatSendButton.Size = new System.Drawing.Size(74, 41);
            this.chatSendButton.TabIndex = 15;
            this.chatSendButton.Text = "Send Message";
            this.chatSendButton.UseVisualStyleBackColor = true;
            this.chatSendButton.Click += new System.EventHandler(this.chatSendButton_Click);
            // 
            // dealerHandType
            // 
            this.dealerHandType.AutoSize = true;
            this.dealerHandType.BackColor = System.Drawing.Color.Transparent;
            this.dealerHandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerHandType.Location = new System.Drawing.Point(80, 172);
            this.dealerHandType.Name = "dealerHandType";
            this.dealerHandType.Size = new System.Drawing.Size(107, 33);
            this.dealerHandType.TabIndex = 16;
            this.dealerHandType.Text = "Dealer";
            this.dealerHandType.Click += new System.EventHandler(this.dealerHandType_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.Deck;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(211, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 150);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // DeckImg
            // 
            this.DeckImg.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.Deck;
            this.DeckImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeckImg.Location = new System.Drawing.Point(784, 11);
            this.DeckImg.Name = "DeckImg";
            this.DeckImg.Size = new System.Drawing.Size(100, 150);
            this.DeckImg.TabIndex = 20;
            this.DeckImg.TabStop = false;
            // 
            // FrmBlackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.TableFabric;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 497);
            this.Controls.Add(this.DeckImg);
            this.Controls.Add(this.dealerHandType);
            this.Controls.Add(this.chatSendButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerHandType);
            this.Controls.Add(this.redealButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.picCard5);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.picCard1);
            this.Controls.Add(this.pictureBox6);
            this.Name = "FrmBlackjack";
            this.Text = "FrmBlackjack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBlackjack_FormClosed);
            this.Load += new System.EventHandler(this.FrmBlackjack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeckImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dealerHandType_Click(object sender, EventArgs e)
        {

        }

        private void chatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard4;
        private System.Windows.Forms.PictureBox picCard5;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.Button redealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button stayButton;
        private System.Windows.Forms.Label playerHandType;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button chatSendButton;
        private System.Windows.Forms.Label dealerHandType;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button WHERETHEFUCK;
        private System.Windows.Forms.PictureBox DeckImg;
    }
}