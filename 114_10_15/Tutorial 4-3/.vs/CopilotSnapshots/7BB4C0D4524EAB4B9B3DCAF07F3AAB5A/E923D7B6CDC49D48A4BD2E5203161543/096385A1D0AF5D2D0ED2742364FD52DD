using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 按下「審核資格」按鈕時執行的事件處理函式
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 最低年薪與最低年資常數
            const decimal MINIMUM_SALARY = 1200000m;
            const int MINIMUM_YEARS = 2;

            decimal salary;      // 使用者輸入的年薪
            int yearsOnJob;      // 使用者輸入的現職年數

            try
            {
                // 取得並轉換使用者輸入的年薪與年資
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);
                // 判斷是否符合貸款資格
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS)
                    {
                        // 年薪與年資皆符合
                        decisionLabel.Text = "符合貸款資格";
                    }
                    else
                    {
                        // 年薪符合但年資不足
                        decisionLabel.Text = "不符合貸款資格";
                    }
                }
                else
                {
                    // 年薪不足
                    decisionLabel.Text = "不符合貸款資格";
                }
            }
            catch (Exception ex)
            {
                // 輸入格式錯誤時顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
        }

        // 按下「清除」按鈕時執行的事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空所有輸入欄位與結果標籤
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標移回年薪輸入欄位
            salaryTextBox.Focus();
        }

        // 按下「離開」按鈕時執行的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
