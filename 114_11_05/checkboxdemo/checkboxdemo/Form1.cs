namespace checkboxdemo
{
    // Form1 為應用程式的主要視窗之一，包含數個 Checkbox 與一個按鈕
    // 使用部分類別(partial class)的方式，設計器產生的程式碼會放在 Form1.Designer.cs
    public partial class Form1 : Form
    {
        // 建構子：初始化元件（由設計器產生的 InitializeComponent 方法）
        // 在此可以加入額外的初始化程式碼，例如變數預設值或事件綁定
        public Form1()
        {
            InitializeComponent();
        }

        // 按鈕的 Click 事件處理器：當使用者按下按鈕時會觸發此方法
        // 本方法會檢查多個 CheckBox 的勾選狀態並組合一個顯示用的訊息
        private void button1_Click(object sender, EventArgs e)
        {
            // message 變數用來累積使用者選擇的口味字串
            String message = "";

            // 以下以 if / else if 判斷每個 CheckBox 是否被勾選。
            // 注意：使用 else if 的寫法代表當第一個條件成立時，後續條件不會再被檢查，
            // 因此此範例只會顯示第一個被判定為 true 的口味；若要允許多選，應改用多個獨立的 if。

            if(checkBox1.Checked)
            {
                // 當 checkBox1 被勾選時，將「夏威夷」加入 message
                message += "夏威夷\n";
            }
             if(checkBox2.Checked) 
                // 當 checkBox1 未勾選且 checkBox2 被勾選時，將「章魚燒」加入 message
                message += "章魚燒\n";
            if (checkBox3.Checked)
                // 當前兩個都未勾選且 checkBox3 被勾選時，將「综合海鲜」加入 message
                message += "综合海鲜\n";
            if (checkBox4.Checked)
                // 當前三個都未勾選且 checkBox4 被勾選時，將「義式火腿」加入 message
                message += "義式火腿\n";
            else
                // 如果以上都沒有勾選，顯示預設訊息，提示使用者尚未做任何選擇
                message = "您没有选择任何口味";
            {

            }

            // 使用 MessageBox 顯示最後組合好的訊息，標題為「您选择的口味是」
            MessageBox.Show(message, "您选择的口味是");
        }
    }
}
