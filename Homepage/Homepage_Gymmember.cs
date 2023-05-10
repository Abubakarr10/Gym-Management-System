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
    public partial class Homepage_Gymmember : Form
    {
        public Homepage_Gymmember()
        {
            InitializeComponent();
        }

        private void bttn_new_admission_MouseEnter(object sender, EventArgs e)
        {
            bttn_new_admission.ForeColor = Color.DarkOrange;
        }

        private void bttn_new_admission_MouseLeave(object sender, EventArgs e)
        {
            bttn_new_admission.ForeColor = Color.White;
        }

        private void bttn_search_member_MouseEnter(object sender, EventArgs e)
        {
            bttn_search_member.ForeColor = Color.DarkOrange;
        }

        private void bttn_search_member_MouseLeave(object sender, EventArgs e)
        {
            bttn_search_member.ForeColor = Color.White;
        }

        private void bttn_member_fee_MouseEnter(object sender, EventArgs e)
        {
            bttn_member_fee.ForeColor = Color.DarkOrange;
        }

        private void bttn_member_fee_MouseLeave(object sender, EventArgs e)
        {
            bttn_member_fee.ForeColor = Color.White;
        }

        private void bttn_search_member_fee_MouseEnter(object sender, EventArgs e)
        {
            bttn_search_member_fee.ForeColor = Color.DarkOrange;
        }

        private void bttn_search_member_fee_MouseLeave(object sender, EventArgs e)
        {
            bttn_search_member_fee.ForeColor = Color.White;
        }

        private void bttn_new_admission_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewAdmission a1 = new NewAdmission();
            a1.ShowDialog();
            this.Show();
        }

        private void bttn_search_member_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMember as1 = new SearchMember();
            as1.ShowDialog();
            this.Show();
        }

        private void bttn_member_fee_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberFee as2 = new MemberFee();
            as2.ShowDialog();
            this.Show();
        }

        private void bttn_search_member_fee_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMemberFee as3 = new SearchMemberFee();
            as3.ShowDialog();
            this.Show();
        }

        private void button_package_MouseEnter(object sender, EventArgs e)
        {
            button_package.ForeColor = Color.DarkOrange;
        }

        private void button_package_MouseLeave(object sender, EventArgs e)
        {
            button_package.ForeColor = Color.White;
        }

        private void button_help_member_MouseEnter(object sender, EventArgs e)
        {
            button_help_member.ForeColor = Color.DarkOrange;
        }

        private void button_help_member_MouseLeave(object sender, EventArgs e)
        {
            button_help_member.ForeColor = Color.White;
        }
    }
}
