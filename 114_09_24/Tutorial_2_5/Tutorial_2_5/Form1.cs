namespace Tutorial_2_5
{
    // Form1 �O�D����������O
    public partial class Form1 : Form
    {
        // �غc�禡�A��l�ƪ�椸��
        public Form1()
        {
            InitializeComponent(); // ��l�Ƥ���
        }

        // ������J��Ĳ�o���ƥ�
        private void Form1_Load(object sender, EventArgs e)
        {
            // ���åd�I�Ϥ�
            cardbackpictureBox2.Visible = false;
            // ���åd���Ϥ�
            cardfacepictureBox1.Visible = false;
        }

        // ���U��ܥd�I���s��Ĳ�o���ƥ�
        private void showBackbutton1_Click(object sender, EventArgs e)
        {
            // ��ܥd�I�Ϥ�
            cardbackpictureBox2.Visible = true;
            // ���åd���Ϥ�
            cardfacepictureBox1.Visible = false;
        }

        // ���U��ܥd�����s��Ĳ�o���ƥ�
        private void button1_Click(object sender, EventArgs e)
        {
            // ���åd�I�Ϥ�
            cardbackpictureBox2.Visible = false;
            // ��ܥd���Ϥ�
            cardfacepictureBox1.Visible = true;
        }
    }
}

