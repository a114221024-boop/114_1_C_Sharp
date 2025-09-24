namespace Tutorial_2_3
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
            translationLabel = new Label();
            義大利button = new Button();
            germanbutton = new Button();
            spanishbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(117, 60);
            label1.Name = "label1";
            label1.Size = new Size(519, 61);
            label1.TabIndex = 0;
            label1.Text = "选一個語言,我會說早安";
            label1.Click += label1_Click;
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.Fixed3D;
            translationLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            translationLabel.Location = new Point(177, 206);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(360, 96);
            translationLabel.TabIndex = 1;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // 義大利button
            // 
            義大利button.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            義大利button.Location = new Point(66, 363);
            義大利button.Name = "義大利button";
            義大利button.Size = new Size(134, 46);
            義大利button.TabIndex = 2;
            義大利button.Text = "義大利文";
            義大利button.UseVisualStyleBackColor = true;
            義大利button.Click += button1_Click;
            // 
            // germanbutton
            // 
            germanbutton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            germanbutton.Location = new Point(523, 363);
            germanbutton.Name = "germanbutton";
            germanbutton.Size = new Size(134, 46);
            germanbutton.TabIndex = 3;
            germanbutton.Text = "徳文";
            germanbutton.UseVisualStyleBackColor = true;
            germanbutton.Click += germanbutton_Click;
            // 
            // spanishbutton
            // 
            spanishbutton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            spanishbutton.Location = new Point(297, 363);
            spanishbutton.Name = "spanishbutton";
            spanishbutton.Size = new Size(134, 46);
            spanishbutton.TabIndex = 4;
            spanishbutton.Text = "西班牙文";
            spanishbutton.UseVisualStyleBackColor = true;
            spanishbutton.Click += spanishbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spanishbutton);
            Controls.Add(germanbutton);
            Controls.Add(義大利button);
            Controls.Add(translationLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "語言翻译器";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label translationLabel;
        private Button 義大利button;
        private Button button1;
        private Button button2;
        private Button germanbutton;
        private Button spanishbutton;
    }
}
