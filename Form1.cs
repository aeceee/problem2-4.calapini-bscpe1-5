using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2_4.calapini_bscpe1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare variables
            int days = 1;
            int total = 0;

            for (days = 1; days <= 7; days++)
            {
                if (days <= 7)
                {
                    total = (int)Math.Pow(2, days - 1);
                    listBox1.Items.Add("Day: " + days + "   Total: " + total);
                }
            }
        }
    }
}
