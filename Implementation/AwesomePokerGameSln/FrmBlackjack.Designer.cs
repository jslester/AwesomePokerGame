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
        private void InitializeComponentBlackjack()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBlackjack));
            this.picCard1       = new System.Windows.Forms.PictureBox();
            this.picCard3       = new System.Windows.Forms.PictureBox();
            this.picCard4       = new System.Windows.Forms.PictureBox();
            this.picCard5       = new System.Windows.Forms.PictureBox();
            this.picCard2       = new System.Windows.Forms.PictureBox();
            this.redealButton   = new System.Windows.Forms.Button();
            this.hitButton      = new System.Windows.Forms.Button();
            this.stayButton      = new System.Windows.Forms.Button();
            this.playerHandType = new System.Windows.Forms.Label();
            this.pictureBox1    = new System.Windows.Forms.PictureBox();
            this.pictureBox2    = new System.Windows.Forms.PictureBox();
            this.pictureBox3    = new System.Windows.Forms.PictureBox();
            this.pictureBox4    = new System.Windows.Forms.PictureBox();
            this.pictureBox5    = new System.Windows.Forms.PictureBox();
            this.chatBox        = new System.Windows.Forms.ListBox();
            this.typeBox        = new System.Windows.Forms.TextBox();
            this.chatSendButton = new System.Windows.Forms.Button();
            this.dealerHandType = new System.Windows.Forms.Label();
            //this.replaceCards = new System.Windows.Forms.Button();
            this.foldButton     = new System.Windows.Forms.Button();
            this.pictureBox6    = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard1
            // 
            this.picCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard1.Location = new System.Drawing.Point(114, 338);
            this.picCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(150, 231);
            this.picCard1.TabIndex = 0;
            this.picCard1.TabStop = false;
            this.picCard1.Click += new System.EventHandler(this.cardClickHandler);
            // 
            // picCard3
            // 
            this.picCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard3.Location = new System.Drawing.Point(518, 338);
            this.picCard3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(150, 231);
            this.picCard3.TabIndex = 1;
            this.picCard3.TabStop = false;
            this.picCard3.Click += new System.EventHandler(this.cardClickHandler);
            // 
            // picCard4
            // 
            this.picCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard4.Location = new System.Drawing.Point(720, 338);
            this.picCard4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(150, 231);
            this.picCard4.TabIndex = 2;
            this.picCard4.TabStop = false;
            this.picCard4.Click += new System.EventHandler(this.cardClickHandler);
            // 
            // picCard5
            // 
            this.picCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard5.Location = new System.Drawing.Point(928, 338);
            this.picCard5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard5.Name = "picCard5";
            this.picCard5.Size = new System.Drawing.Size(150, 231);
            this.picCard5.TabIndex = 3;
            this.picCard5.TabStop = false;
            this.picCard5.Click += new System.EventHandler(this.cardClickHandler);
            // 
            // picCard2
            // 
            this.picCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard2.Location = new System.Drawing.Point(316, 338);
            this.picCard2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(150, 231);
            this.picCard2.TabIndex = 4;
            this.picCard2.TabStop = false;
            this.picCard2.Click += new System.EventHandler(this.cardClickHandler);
            // 
            // redealButton
            // 
            this.redealButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.redealButton.Location = new System.Drawing.Point(444, 592);
            this.redealButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redealButton.Name = "redealButton";
            this.redealButton.Size = new System.Drawing.Size(268, 132);
            this.redealButton.TabIndex = 6;
            this.redealButton.Text = "New Game";
            this.redealButton.UseVisualStyleBackColor = false;
            this.redealButton.Click += new System.EventHandler(this.redealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.hitButton.Location = new System.Drawing.Point(484, 592);
            this.hitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(268, 132);
            this.hitButton.TabIndex = 6;
            this.hitButton.Text = "New Game";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // stayButton
            // 
            this.stayButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.stayButton.Location = new System.Drawing.Point(484, 642);
            this.stayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(268, 132);
            this.stayButton.TabIndex = 6;
            this.stayButton.Text = "New Game";
            this.stayButton.UseVisualStyleBackColor = false;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // playerHandType
            // 
            this.playerHandType.AutoSize = true;
            this.playerHandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHandType.Location = new System.Drawing.Point(120, 611);
            this.playerHandType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHandType.Name = "playerHandType";
            this.playerHandType.Size = new System.Drawing.Size(145, 52);
            this.playerHandType.TabIndex = 7;
            this.playerHandType.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(316, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 231);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(928, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 231);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(720, 18);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 231);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(518, 18);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 231);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(114, 18);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 231);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 20;
            this.chatBox.Location = new System.Drawing.Point(1176, 255);
            this.chatBox.Name = "chatBox";
            this.chatBox.ScrollAlwaysVisible = true;
            this.chatBox.Size = new System.Drawing.Size(340, 384);
            this.chatBox.TabIndex = 13;
            this.chatBox.SelectedIndexChanged += new System.EventHandler(this.chatBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.typeBox.Location = new System.Drawing.Point(1176, 648);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(223, 61);
            this.typeBox.TabIndex = 14;
            this.typeBox.Text = "Enter a message:";
            this.typeBox.Enter += new System.EventHandler(this.TypeBox_Enter);
            this.typeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypeBox_Press_Enter);
            this.typeBox.Leave += new System.EventHandler(this.TypeBox_Leave);
            // 
            // chatSendButton
            // 
            this.chatSendButton.Location = new System.Drawing.Point(1407, 648);
            this.chatSendButton.Name = "chatSendButton";
            this.chatSendButton.Size = new System.Drawing.Size(111, 63);
            this.chatSendButton.TabIndex = 15;
            this.chatSendButton.Text = "Send Message";
            this.chatSendButton.UseVisualStyleBackColor = true;
            this.chatSendButton.Click += new System.EventHandler(this.chatSendButton_Click);
            // 
            // dealerHandType
            // 
            this.dealerHandType.AutoSize = true;
            this.dealerHandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerHandType.Location = new System.Drawing.Point(120, 265);
            this.dealerHandType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerHandType.Name = "dealerHandType";
            this.dealerHandType.Size = new System.Drawing.Size(145, 52);
            this.dealerHandType.TabIndex = 16;
            this.dealerHandType.Text = "label2";
            this.dealerHandType.Click += new System.EventHandler(this.dealerHandType_Click);
            // 
            // replaceCards
            // 
            //this.replaceCards.BackColor = System.Drawing.Color.CornflowerBlue;
            //this.replaceCards.Location = new System.Drawing.Point(830, 589);
            //this.replaceCards.Name = "replaceCards";
            //this.replaceCards.Size = new System.Drawing.Size(168, 52);
            //this.replaceCards.TabIndex = 17;
            //this.replaceCards.Text = "Re-Draw Cards";
            //this.replaceCards.UseVisualStyleBackColor = false;
            //this.replaceCards.Click += new System.EventHandler(this.ReplaceSelectedCards);
            // 
            // foldButton
            // 
            this.foldButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.foldButton.Location = new System.Drawing.Point(830, 662);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(168, 49);
            this.foldButton.TabIndex = 18;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = false;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.Deck;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1176, 18);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 231);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // FrmPlaygame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1563, 765);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.foldButton);
            //this.Controls.Add(this.replaceCards);
            this.Controls.Add(this.dealerHandType);
            this.Controls.Add(this.chatSendButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.playerHandType);
            this.Controls.Add(this.redealButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.picCard5);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.picCard1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBlackjack";
            this.Text = "FrmBlackjack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBlackjack_FormClosed);
            this.Load += new System.EventHandler(this.FrmBlackjack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button chatSendButton;
        private System.Windows.Forms.Label dealerHandType;
        //private System.Windows.Forms.Button replaceCards;
        private System.Windows.Forms.Button foldButton;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}