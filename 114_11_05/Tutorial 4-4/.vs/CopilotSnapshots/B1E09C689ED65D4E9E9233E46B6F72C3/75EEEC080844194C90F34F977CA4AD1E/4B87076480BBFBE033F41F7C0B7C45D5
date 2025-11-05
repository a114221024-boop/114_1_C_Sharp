using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    // 主表單類別：負責處理使用者輸入、驗證資料，並計算每公升行駛公里數
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕的點擊處理程序
        // 功能：
        // 1. 從 milesTextBox 讀取公里數字串並嘗試轉成 double（使用 TryParse 避免例外）
        // 2. 從 litersTextBox 讀取使用公升數字串並嘗試轉成 double
        // 3. 若兩者皆為有效數字且公升不為零，則計算每公升的公里數並顯示於 economyLabel
        // 4. 若任一輸入不合法，顯示訊息提示並將焦點移回該輸入框，方便使用者修正
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // kms: 使用者輸入的公里數
            // liters: 使用者輸入的消耗公升數
            // fueiEconomy: 計算出的每公升公里數（km/L）
            double kms;
            double liters;
            double fueiEconomy;

            // 先嘗試解析公里數輸入（使用 TryParse 可避免拋出 FormatException）
            if (double.TryParse(milesTextBox.Text, out kms))
            {
               // 若公里數解析成功，接著解析公升數
               if (double.TryParse(litersTextBox.Text, out liters))
                {
                    // 避免除以零：若公升為 0，數學上無意義，應提示使用者
                    if (liters == 0.0)
                    {
                        // 顯示錯誤訊息並將焦點回到輸入框
                        MessageBox.Show("公升數不得為 0，請輸入大於 0 的數值。", "輸入錯誤");
                        litersTextBox.Focus();
                        litersTextBox.SelectAll();
                        return;
                    }

                    // 計算每公升公里數，並以數值格式顯示到 economyLabel（保留兩位小數）
                    fueiEconomy = kms / liters;
                    // 使用中文單位與固定小數格式（n2 會依文化顯示千分符號，若不需要千分符號可改為 F2）
                    economyLabel.Text = fueiEconomy.ToString("n2") + " 公里/公升";
                }
                else
                {
                    // 當公升輸入非數字時顯示錯誤提示，並將焦點設回輸入框以便使用者修正
                    MessageBox.Show("請輸入有效的公升數字。", "輸入錯誤");
                    litersTextBox.Focus();
                    litersTextBox.SelectAll();
                }
            }
            else
            {
                // 當公里數輸入非數字時顯示錯誤提示，並將焦點設回輸入框以便使用者修正
                MessageBox.Show("請輸入有效的公里數字。", "輸入錯誤");
                milesTextBox.Focus();
                milesTextBox.SelectAll();
            }
        }

        // 結束按鈕的點擊處理程序：關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單並結束應用程式（若是主要表單）
            this.Close();
        }
    }
}
