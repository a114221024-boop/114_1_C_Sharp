using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕事件：計算總薪資（含加班）
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 基本工時常數（40小時）
            const decimal BASE_HOURS = 40m;
            // 加班倍率常數（1.5倍）
            const decimal OT_MULTIPLIER = 1.5m;
            decimal hoursWorked;      // 實際工時
            decimal hourlyPayRate;    // 時薪
            decimal grossPay;         // 總薪資

            try
            {
                // 取得工時與時薪輸入並轉為decimal
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                // 判斷是否有加班
                if (hoursWorked <= BASE_HOURS)
                {
                    // 未超過基本工時，直接計算
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    // 超過基本工時，計算加班薪資
                    grossPay = (BASE_HOURS * hourlyPayRate) +
                               ((hoursWorked - BASE_HOURS) *
                               (hourlyPayRate * OT_MULTIPLIER));
                }
                // 顯示計算結果（貨幣格式）
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                // 輸入格式錯誤時顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
        }

        // 清除按鈕事件：清空所有輸入與結果
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空工時、時薪與總薪資欄位
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標移回工時輸入框
            hoursWorkedTextBox.Focus();
        }

        // 離開按鈕事件：關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}
