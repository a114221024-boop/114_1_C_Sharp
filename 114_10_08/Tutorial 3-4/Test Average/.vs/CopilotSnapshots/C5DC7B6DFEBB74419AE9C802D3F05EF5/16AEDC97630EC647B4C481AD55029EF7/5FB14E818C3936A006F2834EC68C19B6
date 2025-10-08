using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3;
            // 取得三個分數並計算平均
            if (double.TryParse(test1TextBox.Text, out test1) &&
                double.TryParse(test2TextBox.Text, out test2) &&
                double.TryParse(test3TextBox.Text, out test3))
            {
                double average = (test1 + test2 + test3) / 3;
                averageLabel.Text = average.ToString("n2");
            }
            else
            {
                MessageBox.Show("請輸入有效的分數！");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
