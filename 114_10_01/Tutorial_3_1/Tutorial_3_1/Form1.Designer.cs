namespace Tutorial_3_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dayOfWeekTextBox = new TextBox();
            monthTextBox = new TextBox();
            dayOfMoothTextBox = new TextBox();
            yearTextBox = new TextBox();
            dateOutputLabel = new Label();
            showDateButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(190, 46);
            label1.Name = "label1";
            label1.Size = new Size(142, 50);
            label1.TabIndex = 0;
            label1.Text = "星期：";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(230, 112);
            label2.Name = "label2";
            label2.Size = new Size(102, 50);
            label2.TabIndex = 1;
            label2.Text = "月：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(230, 185);
            label3.Name = "label3";
            label3.Size = new Size(102, 50);
            label3.TabIndex = 2;
            label3.Text = "日：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(230, 260);
            label4.Name = "label4";
            label4.Size = new Size(102, 50);
            label4.TabIndex = 3;
            label4.Text = "年：";
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dayOfWeekTextBox.Location = new Point(326, 43);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(379, 53);
            dayOfWeekTextBox.TabIndex = 4;
            dayOfWeekTextBox.Text = "三";
            dayOfWeekTextBox.TextChanged += dayOfWeekTextBox_TextChanged;
            // 
            // monthTextBox
            // 
            monthTextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            monthTextBox.Location = new Point(326, 112);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(379, 53);
            monthTextBox.TabIndex = 5;
            monthTextBox.Text = "10";
            // 
            // dayOfMoothTextBox
            // 
            dayOfMoothTextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dayOfMoothTextBox.Location = new Point(326, 182);
            dayOfMoothTextBox.Name = "dayOfMoothTextBox";
            dayOfMoothTextBox.Size = new Size(379, 53);
            dayOfMoothTextBox.TabIndex = 6;
            dayOfMoothTextBox.Text = "01";
            // 
            // yearTextBox
            // 
            yearTextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            yearTextBox.Location = new Point(326, 258);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(379, 53);
            yearTextBox.TabIndex = 7;
            yearTextBox.Text = "2025";
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.Fixed3D;
            dateOutputLabel.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dateOutputLabel.Location = new Point(70, 314);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(635, 50);
            dateOutputLabel.TabIndex = 8;
            dateOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            showDateButton.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showDateButton.Location = new Point(70, 378);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(235, 60);
            showDateButton.TabIndex = 9;
            showDateButton.Text = "显示日期";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitButton.Location = new Point(552, 378);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(235, 60);
            exitButton.TabIndex = 10;
            exitButton.Text = "离开";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            clearButton.Location = new Point(311, 378);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(235, 60);
            clearButton.TabIndex = 11;
            clearButton.Text = "清除";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(showDateButton);
            Controls.Add(dateOutputLabel);
            Controls.Add(yearTextBox);
            Controls.Add(dayOfMoothTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dayOfWeekTextBox;
        private TextBox monthTextBox;
        private TextBox dayOfMoothTextBox;
        private TextBox yearTextBox;
        private Label dateOutputLabel;
        private Button showDateButton;
        private Button exitButton;
        private Button clearButton;
    }
}
