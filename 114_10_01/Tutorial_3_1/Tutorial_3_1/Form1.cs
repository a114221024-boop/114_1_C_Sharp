namespace Tutorial_3_1
{
    public partial class Form1 : Form
    {
        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的所有控制項
        }

        // 標籤點擊事件（目前未使用）
        private void label1_Click(object sender, EventArgs e)
        {
            // 此事件目前沒有任何程式碼
        }

        // 離開按鈕點擊事件：關閉視窗
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉目前的表單
        }

        // 顯示日期按鈕點擊事件：組合並顯示日期字串
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 從文字方塊取得星期、月份、年份、日期
            string dateOfWeek = dayOfWeekTextBox.Text; // 星期
            string month = monthTextBox.Text;           // 月份
            string year = yearTextBox.Text;             // 年份
            string dayOfMonth = dayOfMoothTextBox.Text; // 日期（注意：原本拼寫錯誤，應為 dayOfMonthTextBox）

            // 組合成繁體中文日期格式字串
            string output = "中華民國 " + year + " 年 " + month + " 月 " + dayOfMonth + " 日 " + dateOfWeek;

            dateOutputLabel.Text = output; // 顯示在標籤上
        }

        // 星期文字方塊內容改變事件（目前未使用）
        private void dayOfWeekTextBox_TextChanged(object sender, EventArgs e)
        {
            // 此事件目前沒有任何程式碼
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = ""; 
            monthTextBox.Text = "";
            yearTextBox.Text = "";
            dayOfMoothTextBox.Text = "";
            dateOutputLabel.Text = "";

        }
    }
}
