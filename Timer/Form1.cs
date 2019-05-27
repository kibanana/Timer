using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Timer
{
    public partial class Form1 : Form
    {
        int CountOrgNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            ProcessTimer();
        }

        private void ProcessTimer()
        {
            if (IntCheck())
            {
                this.CountOrgNum = Convert.ToInt32(this.txtNum.Text);
                this.txtNum.ReadOnly = true;
                this.timer1.Enabled = true;
            }
            else
            {
                this.txtNum.Focus();
                this.txtNum.Text = "";
            }
        }

        private bool IntCheck()
        {
            if (Information.IsNumeric(this.txtNum.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("숫자만 입력해 주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(this.CountOrgNum < 1)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("펑!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNum.ReadOnly = false;
                this.txtNum.Text = "";
                this.txtNum.Focus();
            }
            else
            {
                this.CountOrgNum--;
                this.txtCountDown.Text = Convert.ToString(this.CountOrgNum);
            }
        }

        private void TxtCountDown_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
