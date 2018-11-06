namespace AwesomePokerGameSln
{
    partial class AddFunds
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
            this.add1Hund = new System.Windows.Forms.Button();
            this.add5Hund = new System.Windows.Forms.Button();
            this.addThousand = new System.Windows.Forms.Button();
            this.cancelAddFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add1Hund
            // 
            this.add1Hund.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1Hund.Location = new System.Drawing.Point(12, 30);
            this.add1Hund.Name = "add1Hund";
            this.add1Hund.Size = new System.Drawing.Size(75, 75);
            this.add1Hund.TabIndex = 0;
            this.add1Hund.Text = "$100";
            this.add1Hund.UseVisualStyleBackColor = true;
            // 
            // add5Hund
            // 
            this.add5Hund.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.add5Hund.Location = new System.Drawing.Point(108, 30);
            this.add5Hund.Name = "add5Hund";
            this.add5Hund.Size = new System.Drawing.Size(75, 75);
            this.add5Hund.TabIndex = 1;
            this.add5Hund.Text = "$500";
            this.add5Hund.UseVisualStyleBackColor = true;
            // 
            // addThousand
            // 
            this.addThousand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addThousand.Location = new System.Drawing.Point(202, 30);
            this.addThousand.Name = "addThousand";
            this.addThousand.Size = new System.Drawing.Size(75, 75);
            this.addThousand.TabIndex = 2;
            this.addThousand.Text = "$1000";
            this.addThousand.UseVisualStyleBackColor = true;
            // 
            // cancelAddFunds
            // 
            this.cancelAddFunds.Location = new System.Drawing.Point(297, 42);
            this.cancelAddFunds.Name = "cancelAddFunds";
            this.cancelAddFunds.Size = new System.Drawing.Size(75, 50);
            this.cancelAddFunds.TabIndex = 3;
            this.cancelAddFunds.Text = "Cancel";
            this.cancelAddFunds.UseVisualStyleBackColor = true;
            this.cancelAddFunds.Click += new System.EventHandler(this.cancelAddFunds_Click);
            // 
            // AddFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 136);
            this.Controls.Add(this.cancelAddFunds);
            this.Controls.Add(this.addThousand);
            this.Controls.Add(this.add5Hund);
            this.Controls.Add(this.add1Hund);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddFunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Funds";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add1Hund;
        private System.Windows.Forms.Button add5Hund;
        private System.Windows.Forms.Button addThousand;
        private System.Windows.Forms.Button cancelAddFunds;
    }
}