using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    // 主視窗類別：負責顯示城市清單並回傳對應的時區資訊。
    public partial class Form1 : Form
    {
        // 建構子：初始化元件。
        public Form1()
        {
            InitializeComponent();
        }

        // okButton 的 Click 事件處理器。
        // 當使用者按下「確定」按鈕時，檢查 ListBox 是否有選取項目，
        // 若有則取得選取的城市名稱並根據城市顯示對應的時區字串。
        private void okButton_Click(object sender, EventArgs e)
        {
            // 宣告一個變數來儲存選取的城市名稱。
            string city;

            // 檢查是否有選取項目：使用 SelectedIndex != -1 可以避免
            // 直接將 SelectedItem 與整數比較所可能產生的類型不相容問題。
            // SelectedIndex == -1 表示沒有任何項目被選取。
            if (cityListBox.SelectedIndex != -1)
            {
                // 取得選取項目的字串表示。
                city = cityListBox.SelectedItem.ToString();

                // 根據城市名稱使用 switch 判斷並設定 timeZoneLabel 的文字。
                // 這裡使用繁體中文的時區描述並包含對應的 UTC 偏移量，方便使用者理解。
                switch (city)
                {
                    case "丹佛":
                        // 丹佛位於美國山區時間（Mountain Time）
                        timeZoneLabel.Text = "山區時間 (UTC-7)";
                        break;
                    case "檀香山":
                        // 檀香山（Honolulu）使用夏威夷-阿留申標準時間
                        timeZoneLabel.Text = "夏威夷-阿留申標準時間 (UTC-10)";
                        break;
                    case "明尼阿波利斯":
                        // 明尼阿波利斯位於美國中部時間（Central Time）
                        timeZoneLabel.Text = "中部時間 (UTC-6)";
                        break;
                    case "紐約":
                        // 紐約位於美國東部時間（Eastern Time）
                        timeZoneLabel.Text = "東部時間 (UTC-5)";
                        break;
                    case "舊金山":
                        // 舊金山位於美國太平洋時間（Pacific Time）
                        timeZoneLabel.Text = "太平洋時間 (UTC-8)";
                        break;
                    default:
                        // 預設情況：若遇到未定義的城市，顯示提示文字。
                        timeZoneLabel.Text = "未知的城市 / 無對應時區";
                        break;
                }
            }
            else
            {
                // 若未選取城市則顯示錯誤訊息，提醒使用者先選擇。
                // MessageBox 的標題也使用繁體中文。
                MessageBox.Show("請先選擇一個城市。", "錯誤");
            }
        }

        // exitButton 的 Click 事件處理器。
        // 按下離開按鈕時關閉表單並結束應用程式。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗（End the form）。
            this.Close();
        }

        // Form 的載入事件：目前留空，但保留此方法以便未來擴充。
        // 可於此處初始化其他資料或設定預設值。
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
