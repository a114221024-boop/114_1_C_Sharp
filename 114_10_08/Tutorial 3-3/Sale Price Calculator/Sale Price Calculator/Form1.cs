using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        // 當「計算特價」按鈕被點擊時執行的事件處理方法
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice = 0.0m;  // 商品原價
            decimal discountPercentage; // 折扣百分比
            decimal salePrice;  // 特價

            // 取得原價輸入框的文字並轉換為 decimal 型別
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            // 取得折扣百分比輸入框的文字並轉換為 decimal 型別
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text); 

            // 計算特價：原價乘以 (1 - 折扣百分比/100)
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);
            
            salePriceLabel.Text = salePrice.ToString("C"); // 將特價格式化為兩位小數並顯示在標籤上
            // TODO: 可將 salePrice 顯示在 salePriceLabel 上
        }

        // 當「離開」按鈕被點擊時執行的事件處理方法
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
