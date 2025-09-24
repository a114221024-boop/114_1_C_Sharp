namespace Tutorial_2_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardfacepictureBox1 = new PictureBox();
            showBackbutton1 = new Button();
            button1 = new Button();
            cardbackpictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cardfacepictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardbackpictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cardfacepictureBox1
            // 
            cardfacepictureBox1.Image = Properties.Resources.Ace_Hearts1;
            cardfacepictureBox1.Location = new Point(316, 86);
            cardfacepictureBox1.Name = "cardfacepictureBox1";
            cardfacepictureBox1.Size = new Size(235, 239);
            cardfacepictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cardfacepictureBox1.TabIndex = 0;
            cardfacepictureBox1.TabStop = false;
            // 
            // showBackbutton1
            // 
            showBackbutton1.Location = new Point(536, 362);
            showBackbutton1.Name = "showBackbutton1";
            showBackbutton1.Size = new Size(133, 53);
            showBackbutton1.TabIndex = 2;
            showBackbutton1.Text = "显示背面";
            showBackbutton1.UseVisualStyleBackColor = true;
            showBackbutton1.Click += showBackbutton1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(197, 362);
            button1.Name = "button1";
            button1.Size = new Size(140, 53);
            button1.TabIndex = 3;
            button1.Text = "显示正面";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cardbackpictureBox2
            // 
            cardbackpictureBox2.Image = Properties.Resources.Backface_Red;
            cardbackpictureBox2.Location = new Point(316, 86);
            cardbackpictureBox2.Name = "cardbackpictureBox2";
            cardbackpictureBox2.Size = new Size(235, 239);
            cardbackpictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            cardbackpictureBox2.TabIndex = 4;
            cardbackpictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cardbackpictureBox2);
            Controls.Add(button1);
            Controls.Add(showBackbutton1);
            Controls.Add(cardfacepictureBox1);
            Name = "Form1";
            Text = "翻扑克牌";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardfacepictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardbackpictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardfacepictureBox1;
        private Button showBackbutton1;
        private Button button1;
        private PictureBox cardbackpictureBox2;
    }
}
