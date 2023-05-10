using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homepage
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void button_search_MouseEnter(object sender, EventArgs e)
        {
            label_searchbutton.Visible = true;
        }

        private void button_search_MouseLeave(object sender, EventArgs e)
        {
            label_searchbutton.Visible = false;
        }

        private void button_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.Visible = true;
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.Visible = false;
        }


        private void textBox_searchmember_Enter(object sender, EventArgs e)
        {
            if (textBox_searchmember.Text == "Enter Gym no or name")
            {
                textBox_searchmember.Text = "";
            }
          
        }

        private void textBox_searchmember_Leave(object sender, EventArgs e)
        {
            if (textBox_searchmember.Text == "")
            {
                textBox_searchmember.Text = "Enter Gym no or name";
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_searchmember.Clear();
        }


    }
}
