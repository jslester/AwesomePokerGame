﻿using System;

namespace AwesomePokerGameSln {
    partial class FrmPlaygame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaygame));
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCard5 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.redealButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.chatSendButton = new System.Windows.Forms.Button();
            this.dealerHandType = new System.Windows.Forms.Label();
            this.replaceCards = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.placeBet = new System.Windows.Forms.Button();
            this.resetBet = new System.Windows.Forms.Button();
            this.betNum = new System.Windows.Forms.Label();
            this.poolNum = new System.Windows.Forms.Label();
            this.poolLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.playerHandType = new System.Windows.Forms.Label();
            this.fiveChip = new System.Windows.Forms.PictureBox();
            this.tenChip = new System.Windows.Forms.PictureBox();
            this.twentyFiveChip = new System.Windows.Forms.PictureBox();
            this.addFundsChip = new System.Windows.Forms.PictureBox();
            this.hundredChip = new System.Windows.Forms.PictureBox();
            this.fiftyChip = new System.Windows.Forms.PictureBox();
            this.walletLabel = new System.Windows.Forms.Label();
            this.walletNum = new System.Windows.Forms.Label();
            this.fiveLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.fiveChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFundsChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundredChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyChip)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard1
            // 
            this.picCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard1.Location = new System.Drawing.Point(76, 220);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(100, 150);
            this.picCard1.TabIndex = 0;
            this.picCard1.TabStop = false;
            this.picCard1.Click += new System.EventHandler(this.CardClickHandler);
            // 
            // picCard3
            // 
            this.picCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard3.Location = new System.Drawing.Point(345, 220);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(100, 150);
            this.picCard3.TabIndex = 1;
            this.picCard3.TabStop = false;
            this.picCard3.Click += new System.EventHandler(this.CardClickHandler);
            // 
            // picCard4
            // 
            this.picCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard4.Location = new System.Drawing.Point(480, 220);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(100, 150);
            this.picCard4.TabIndex = 2;
            this.picCard4.TabStop = false;
            this.picCard4.Click += new System.EventHandler(this.CardClickHandler);
            // 
            // picCard5
            // 
            this.picCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard5.Location = new System.Drawing.Point(619, 220);
            this.picCard5.Name = "picCard5";
            this.picCard5.Size = new System.Drawing.Size(100, 150);
            this.picCard5.TabIndex = 3;
            this.picCard5.TabStop = false;
            this.picCard5.Click += new System.EventHandler(this.CardClickHandler);
            // 
            // picCard2
            // 
            this.picCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCard2.Location = new System.Drawing.Point(211, 220);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(100, 150);
            this.picCard2.TabIndex = 4;
            this.picCard2.TabStop = false;
            this.picCard2.Click += new System.EventHandler(this.CardClickHandler);
            // 
            // redealButton
            // 
            this.redealButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.redealButton.Location = new System.Drawing.Point(296, 385);
            this.redealButton.Name = "redealButton";
            this.redealButton.Size = new System.Drawing.Size(179, 86);
            this.redealButton.TabIndex = 6;
            this.redealButton.Text = "New Game";
            this.redealButton.UseVisualStyleBackColor = false;
            this.redealButton.Click += new System.EventHandler(this.redealButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(211, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 150);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(619, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 150);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(480, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 150);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(345, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 150);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(76, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 150);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
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
            this.dealerHandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.dealerHandType.Location = new System.Drawing.Point(80, 172);
            this.dealerHandType.Name = "dealerHandType";
            this.dealerHandType.Size = new System.Drawing.Size(108, 37);
            this.dealerHandType.TabIndex = 16;
            this.dealerHandType.Text = "label2";
            // 
            // replaceCards
            // 
            this.replaceCards.BackColor = System.Drawing.Color.CornflowerBlue;
            this.replaceCards.Location = new System.Drawing.Point(553, 383);
            this.replaceCards.Margin = new System.Windows.Forms.Padding(2);
            this.replaceCards.Name = "replaceCards";
            this.replaceCards.Size = new System.Drawing.Size(112, 34);
            this.replaceCards.TabIndex = 17;
            this.replaceCards.Text = "Re-Draw Cards";
            this.replaceCards.UseVisualStyleBackColor = false;
            this.replaceCards.Click += new System.EventHandler(this.ReplaceSelectedCards);
            // 
            // foldButton
            // 
            this.foldButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.foldButton.Location = new System.Drawing.Point(553, 430);
            this.foldButton.Margin = new System.Windows.Forms.Padding(2);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(112, 32);
            this.foldButton.TabIndex = 18;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = false;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.Deck;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(784, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 150);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // placeBet
            // 
            this.placeBet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.placeBet.Location = new System.Drawing.Point(553, 532);
            this.placeBet.Name = "placeBet";
            this.placeBet.Size = new System.Drawing.Size(112, 32);
            this.placeBet.TabIndex = 20;
            this.placeBet.Text = "Place Bet";
            this.placeBet.UseVisualStyleBackColor = false;
            this.placeBet.Click += new System.EventHandler(this.placeBetButton_Click);
            // 
            // resetBet
            // 
            this.resetBet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.resetBet.Location = new System.Drawing.Point(553, 494);
            this.resetBet.Name = "resetBet";
            this.resetBet.Size = new System.Drawing.Size(112, 32);
            this.resetBet.TabIndex = 21;
            this.resetBet.Text = "Reset Bet";
            this.resetBet.UseVisualStyleBackColor = false;
            this.resetBet.Click += new System.EventHandler(this.resetBetButton_Click);
            // 
            // betNum
            // 
            this.betNum.BackColor = System.Drawing.Color.Transparent;
            this.betNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.betNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betNum.Location = new System.Drawing.Point(435, 518);
            this.betNum.Name = "betNum";
            this.betNum.Size = new System.Drawing.Size(112, 44);
            this.betNum.TabIndex = 22;
            this.betNum.Text = "label1";
            this.betNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poolNum
            // 
            this.poolNum.BackColor = System.Drawing.Color.Transparent;
            this.poolNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poolNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poolNum.Location = new System.Drawing.Point(890, 116);
            this.poolNum.Name = "poolNum";
            this.poolNum.Size = new System.Drawing.Size(122, 46);
            this.poolNum.TabIndex = 23;
            this.poolNum.Text = "label1";
            this.poolNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poolLabel
            // 
            this.poolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poolLabel.Location = new System.Drawing.Point(890, 96);
            this.poolLabel.Name = "poolLabel";
            this.poolLabel.Size = new System.Drawing.Size(122, 20);
            this.poolLabel.TabIndex = 24;
            this.poolLabel.Text = "Pool:";
            this.poolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // betLabel
            // 
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(435, 494);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(112, 20);
            this.betLabel.TabIndex = 25;
            this.betLabel.Text = "Amount to Bet:";
            this.betLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerHandType
            // 
            this.playerHandType.AutoSize = true;
            this.playerHandType.BackColor = System.Drawing.Color.Transparent;
            this.playerHandType.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.playerHandType.Location = new System.Drawing.Point(77, 385);
            this.playerHandType.Name = "playerHandType";
            this.playerHandType.Size = new System.Drawing.Size(108, 37);
            this.playerHandType.TabIndex = 7;
            this.playerHandType.Text = "label2";
            // 
            // fiveChip
            // 
            this.fiveChip.Image = global::AwesomePokerGameSln.Properties.Resources.pokerchip;
            this.fiveChip.Location = new System.Drawing.Point(12, 439);
            this.fiveChip.Name = "fiveChip";
            this.fiveChip.Size = new System.Drawing.Size(75, 75);
            this.fiveChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiveChip.TabIndex = 26;
            this.fiveChip.TabStop = false;
            this.fiveChip.Tag = "";
            this.fiveChip.Click += new System.EventHandler(this.fiveChip_Click);
            // 
            // tenChip
            // 
            this.tenChip.Image = global::AwesomePokerGameSln.Properties.Resources.pokerchip;
            this.tenChip.Location = new System.Drawing.Point(93, 439);
            this.tenChip.Name = "tenChip";
            this.tenChip.Size = new System.Drawing.Size(75, 75);
            this.tenChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tenChip.TabIndex = 27;
            this.tenChip.TabStop = false;
            this.tenChip.Click += new System.EventHandler(this.tenChip_Click);
            // 
            // twentyFiveChip
            // 
            this.twentyFiveChip.Image = global::AwesomePokerGameSln.Properties.Resources.pokerchip;
            this.twentyFiveChip.Location = new System.Drawing.Point(174, 439);
            this.twentyFiveChip.Name = "twentyFiveChip";
            this.twentyFiveChip.Size = new System.Drawing.Size(75, 75);
            this.twentyFiveChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twentyFiveChip.TabIndex = 28;
            this.twentyFiveChip.TabStop = false;
            this.twentyFiveChip.Click += new System.EventHandler(this.twentyFiveChip_Click);
            // 
            // addFundsChip
            // 
            this.addFundsChip.Image = global::AwesomePokerGameSln.Properties.Resources.pokerchip;
            this.addFundsChip.Location = new System.Drawing.Point(174, 539);
            this.addFundsChip.Name = "addFundsChip";
            this.addFundsChip.Size = new System.Drawing.Size(75, 75);
            this.addFundsChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addFundsChip.TabIndex = 31;
            this.addFundsChip.TabStop = false;
            this.addFundsChip.Click += new System.EventHandler(this.addFundsChip_Click);
            // 
            // hundredChip
            // 
            this.hundredChip.Image = global::AwesomePokerGameSln.Properties.Resources.pokerchip;
            this.hundredChip.Location = new System.Drawing.Point(93, 539);
            this.hundredChip.Name = "hundredChip";
            this.hundredChip.Size = new System.Drawing.Size(75, 75);
            this.hundredChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hundredChip.TabIndex = 30;
            this.hundredChip.TabStop = false;
            this.hundredChip.Click += new System.EventHandler(this.hundredChip_Click);
            // 
            // fiftyChip
            // 
            this.fiftyChip.Image = global::AwesomePokerGameSln.Properties.Resources.pokerchip;
            this.fiftyChip.Location = new System.Drawing.Point(12, 539);
            this.fiftyChip.Name = "fiftyChip";
            this.fiftyChip.Size = new System.Drawing.Size(75, 75);
            this.fiftyChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiftyChip.TabIndex = 29;
            this.fiftyChip.TabStop = false;
            this.fiftyChip.Click += new System.EventHandler(this.fiftyChip_Click);
            // 
            // walletLabel
            // 
            this.walletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletLabel.Location = new System.Drawing.Point(296, 494);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(112, 20);
            this.walletLabel.TabIndex = 33;
            this.walletLabel.Text = "Wallet:";
            this.walletLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // walletNum
            // 
            this.walletNum.BackColor = System.Drawing.Color.Transparent;
            this.walletNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.walletNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletNum.Location = new System.Drawing.Point(296, 518);
            this.walletNum.Name = "walletNum";
            this.walletNum.Size = new System.Drawing.Size(112, 44);
            this.walletNum.TabIndex = 32;
            this.walletNum.Text = "label1";
            this.walletNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fiveLabel
            // 
            this.fiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.fiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveLabel.Location = new System.Drawing.Point(12, 516);
            this.fiveLabel.Name = "fiveLabel";
            this.fiveLabel.Size = new System.Drawing.Size(75, 20);
            this.fiveLabel.TabIndex = 34;
            this.fiveLabel.Text = "$5";
            this.fiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "$50";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "$25";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "$10";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Add Funds";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "$100";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPlaygame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 645);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fiveLabel);
            this.Controls.Add(this.walletLabel);
            this.Controls.Add(this.walletNum);
            this.Controls.Add(this.addFundsChip);
            this.Controls.Add(this.hundredChip);
            this.Controls.Add(this.fiftyChip);
            this.Controls.Add(this.twentyFiveChip);
            this.Controls.Add(this.tenChip);
            this.Controls.Add(this.fiveChip);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.poolLabel);
            this.Controls.Add(this.poolNum);
            this.Controls.Add(this.betNum);
            this.Controls.Add(this.resetBet);
            this.Controls.Add(this.placeBet);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.replaceCards);
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
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.picCard5);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.picCard1);
            this.Name = "FrmPlaygame";
            this.Text = "FrmPlaygame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPlaygame_FormClosed);
            this.Load += new System.EventHandler(this.FrmPlaygame_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.fiveChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFundsChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundredChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyChip)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
                private System.Windows.Forms.ListBox chatBox;
                private System.Windows.Forms.TextBox typeBox;
                private System.Windows.Forms.Button chatSendButton;
                private System.Windows.Forms.Label dealerHandType;
        private System.Windows.Forms.Button replaceCards;
        private System.Windows.Forms.Button foldButton;
		private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button placeBet;
        private System.Windows.Forms.Button resetBet;
        private System.Windows.Forms.Label betNum;
        private System.Windows.Forms.Label poolNum;
        private System.Windows.Forms.Label poolLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label playerHandType;
        private System.Windows.Forms.PictureBox fiveChip;
        private System.Windows.Forms.PictureBox tenChip;
        private System.Windows.Forms.PictureBox twentyFiveChip;
        private System.Windows.Forms.PictureBox addFundsChip;
        private System.Windows.Forms.PictureBox hundredChip;
        private System.Windows.Forms.PictureBox fiftyChip;
        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.Label walletNum;
        private System.Windows.Forms.Label fiveLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}