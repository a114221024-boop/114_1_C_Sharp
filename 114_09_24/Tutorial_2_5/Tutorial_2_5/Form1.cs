namespace Tutorial_2_5
{
    // Form1 是主視窗表單類別
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化元件
        }

        // 當表單載入時觸發的事件
        private void Form1_Load(object sender, EventArgs e)
        {
            // 隱藏卡背圖片
            cardbackpictureBox2.Visible = false;
            // 隱藏卡面圖片
            cardfacepictureBox1.Visible = false;
        }

        // 按下顯示卡背按鈕時觸發的事件
        private void showBackbutton1_Click(object sender, EventArgs e)
        {
            // 顯示卡背圖片
            cardbackpictureBox2.Visible = true;
            // 隱藏卡面圖片
            cardfacepictureBox1.Visible = false;
        }

        // 按下顯示卡面按鈕時觸發的事件
        private void button1_Click(object sender, EventArgs e)
        {
            // 隱藏卡背圖片
            cardbackpictureBox2.Visible = false;
            // 顯示卡面圖片
            cardfacepictureBox1.Visible = true;
        }
    }
}

