namespace Tutorial_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }

        private void spanishbutton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos D?as";
        }

        private void germanbutton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }
    }
}
