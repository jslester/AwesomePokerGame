using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomePokerGameSln
{
    public partial class AddFunds : Form
    {
        public int value;

        public AddFunds()
        {
            InitializeComponent();
            this.value = 0; 
        }

        private void cancelAddFunds_Click(object sender, EventArgs e)
        {
            this.value = 0;
            this.DialogResult = DialogResult.OK;
        }

        private void add1Hund_Click(object sender, EventArgs e)
        {
            this.value = 100;
            this.DialogResult = DialogResult.OK;

        }

        private void add5Hund_Click(object sender, EventArgs e)
        {
            this.value = 500;
            this.DialogResult = DialogResult.OK;
        }

        private void addThousand_Click(object sender, EventArgs e)
        {
            this.value = 1000;
            this.DialogResult = DialogResult.OK;
        }
    }
}
