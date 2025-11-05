using System;
using System.Windows.Forms;

namespace radioButtondeomo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form 載入時的事件處理函式。
        // 在這裡做簡單的初始化或綁定按鈕事件，避免在 Designer 以外遺漏綁定。        
        private void Form1_Load(object sender, EventArgs e)
        {
            // 將送出按鈕的 Click 事件綁定到 Sendbutton1_Click 方法
            // 這樣使用者按下「送出訂單」時會顯示目前選擇的項目。
            sendbutton1.Click += Sendbutton1_Click;
            // 若要在載入時顯示預設提示或設定預設選項，可在此加入。
        }

        // 送出按鈕的事件處理：組合飲料與三明治的選擇並顯示結果。
        private void Sendbutton1_Click(object? sender, EventArgs e)
        {
            // 宣告兩個變數來儲存使用者的選擇。
            // 使用語意化的變數名稱並以中文註解說明用途。
            string drink = string.Empty;      // 使用者選的飲料
            string sandwich = string.Empty;   // 使用者選的三明治

            // 注意：下面的 RadioButton 名稱必須和 Designer 中定義的欄位一致。
            // Designer 檔案中分別為 coffeeradioButton, miketearadioButton,
            // blacktearadioButton3, juiceradioButton4。

            // 判斷哪個飲料被勾選，並把對應的中文名稱放入 drink 變數中。
            if (coffeeradioButton.Checked)
            {
                drink = "咖啡"; // 使用者選擇咖啡
            }
            else if (miketearadioButton.Checked)
            {
                drink = "奶茶"; // 使用者選擇奶茶
            }
            else if (blacktearadioButton3.Checked)
            {
                drink = "紅茶"; // 使用者選擇紅茶
            }
            else if (juiceradioButton4.Checked)
            {
                drink = "果汁"; // 使用者選擇果汁
            }

            // 判斷三明治的選擇，Designer 中分別為 JamsandwichradioButton1,
            // HamsandwichradioButton2, TunasandwichradioButton3。
            if (JamsandwichradioButton1.Checked)
            {
                sandwich = "果醬三明治"; // 果醬三明治
            }
            else if (HamsandwichradioButton2.Checked)
            {
                sandwich = "火腿三明治"; // 火腿三明治
            }
            else if (TunasandwichradioButton3.Checked)
            {
                sandwich = "鮪魚三明治"; // 鮪魚三明治
            }

            // 組合輸出訊息：如果任一項沒選或兩項都沒選會給予適當提示。
            string message;
            if (string.IsNullOrEmpty(drink) && string.IsNullOrEmpty(sandwich))
            {
                message = "您尚未選擇飲料與三明治。";
            }
            else if (string.IsNullOrEmpty(drink))
            {
                message = $"您尚未選擇飲料。三明治：{sandwich}";
            }
            else if (string.IsNullOrEmpty(sandwich))
            {
                message = $"您尚未選擇三明治。飲料：{drink}";
            }
            else
            {
                message = $"訂單：飲料：{drink}，三明治：{sandwich}。";
            }

            // 顯示結果給使用者（使用系統對話視窗）。
            MessageBox.Show(message, "訂單摘要", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
