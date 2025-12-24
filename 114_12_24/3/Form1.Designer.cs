namespace WinFormsApp1
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtNum4 = new TextBox();
            txtNum5 = new TextBox();
            btnGenerate = new Button();
            btnShow = new Button();
            btnExit = new Button();
            listBoxResults = new ListBox();
            lblCompareTitle = new Label();
            lblMatchCount = new Label();
            lblPrize = new Label();
            lblMatchedNumbers = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(30, 20);
            txtNum1.Name = "txtNum1";
            txtNum1.ReadOnly = true;
            txtNum1.Size = new Size(60, 30);
            txtNum1.TabIndex = 0;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(110, 20);
            txtNum2.Name = "txtNum2";
            txtNum2.ReadOnly = true;
            txtNum2.Size = new Size(60, 30);
            txtNum2.TabIndex = 1;
            txtNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(190, 20);
            txtNum3.Name = "txtNum3";
            txtNum3.ReadOnly = true;
            txtNum3.Size = new Size(60, 30);
            txtNum3.TabIndex = 2;
            txtNum3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum4
            // 
            txtNum4.Location = new Point(270, 20);
            txtNum4.Name = "txtNum4";
            txtNum4.ReadOnly = true;
            txtNum4.Size = new Size(60, 30);
            txtNum4.TabIndex = 3;
            txtNum4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNum5
            // 
            txtNum5.Location = new Point(350, 20);
            txtNum5.Name = "txtNum5";
            txtNum5.ReadOnly = true;
            txtNum5.Size = new Size(60, 30);
            txtNum5.TabIndex = 8;
            txtNum5.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(30, 60);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(120, 40);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "產生號碼";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(160, 60);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(120, 40);
            btnShow.TabIndex = 5;
            btnShow.Text = "開獎號碼";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(290, 60);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(30, 120);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(220, 119);
            listBoxResults.TabIndex = 7;
            // 
            // lblCompareTitle
            // 
            lblCompareTitle.AutoSize = true;
            lblCompareTitle.Font = new Font("Segoe UI", 12F);
            lblCompareTitle.Location = new Point(280, 120);
            lblCompareTitle.Name = "lblCompareTitle";
            lblCompareTitle.Size = new Size(139, 32);
            lblCompareTitle.TabIndex = 9;
            lblCompareTitle.Text = "比對結果：";
            // 
            // lblMatchCount
            // 
            lblMatchCount.AutoSize = true;
            lblMatchCount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMatchCount.ForeColor = Color.Red;
            lblMatchCount.Location = new Point(280, 152);
            lblMatchCount.Name = "lblMatchCount";
            lblMatchCount.Size = new Size(153, 38);
            lblMatchCount.TabIndex = 10;
            lblMatchCount.Text = "中0個號碼";
            // 
            // lblPrize
            // 
            lblPrize.AutoSize = true;
            lblPrize.Font = new Font("Segoe UI", 12F);
            lblPrize.ForeColor = Color.Red;
            lblPrize.Location = new Point(280, 197);
            lblPrize.Name = "lblPrize";
            lblPrize.Size = new Size(89, 32);
            lblPrize.TabIndex = 11;
            lblPrize.Text = "沒中獎";
            // 
            // lblMatchedNumbers
            // 
            lblMatchedNumbers.AutoSize = true;
            lblMatchedNumbers.Font = new Font("Segoe UI", 10F);
            lblMatchedNumbers.ForeColor = Color.Black;
            lblMatchedNumbers.Location = new Point(280, 210);
            lblMatchedNumbers.Name = "lblMatchedNumbers";
            lblMatchedNumbers.Size = new Size(0, 28);
            lblMatchedNumbers.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 280);
            Controls.Add(lblMatchedNumbers);
            Controls.Add(lblPrize);
            Controls.Add(lblMatchCount);
            Controls.Add(lblCompareTitle);
            Controls.Add(listBoxResults);
            Controls.Add(btnExit);
            Controls.Add(btnShow);
            Controls.Add(btnGenerate);
            Controls.Add(txtNum5);
            Controls.Add(txtNum4);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "樂透號碼產生器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label lblCompareTitle;
        private System.Windows.Forms.Label lblMatchCount;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblMatchedNumbers;
    }
}
