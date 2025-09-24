namespace Tutorial_2_4
{
    partial class finlandpictureBox
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.countrylabel = new System.Windows.Forms.Label();
            this.germanypictureBox3 = new System.Windows.Forms.PictureBox();
            this.FrancepictureBox = new System.Windows.Forms.PictureBox();
            this.finlandpictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.germanypictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrancepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(220, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "点选國旗出现國名";
            // 
            // countrylabel
            // 
            this.countrylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countrylabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countrylabel.Location = new System.Drawing.Point(186, 335);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(396, 72);
            this.countrylabel.TabIndex = 1;
            this.countrylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // germanypictureBox3
            // 
            this.germanypictureBox3.Image = global::Tutorial_2_4.Properties.Resources.Germany;
            this.germanypictureBox3.Location = new System.Drawing.Point(557, 159);
            this.germanypictureBox3.Name = "germanypictureBox3";
            this.germanypictureBox3.Size = new System.Drawing.Size(214, 133);
            this.germanypictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanypictureBox3.TabIndex = 4;
            this.germanypictureBox3.TabStop = false;
            this.germanypictureBox3.Click += new System.EventHandler(this.germanypictureBox3_Click);
            // 
            // FrancepictureBox
            // 
            this.FrancepictureBox.Image = global::Tutorial_2_4.Properties.Resources.France;
            this.FrancepictureBox.Location = new System.Drawing.Point(293, 159);
            this.FrancepictureBox.Name = "FrancepictureBox";
            this.FrancepictureBox.Size = new System.Drawing.Size(214, 133);
            this.FrancepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrancepictureBox.TabIndex = 3;
            this.FrancepictureBox.TabStop = false;
            this.FrancepictureBox.Click += new System.EventHandler(this.FrancepictureBox_Click);
            // 
            // finlandpictureBox1
            // 
            this.finlandpictureBox1.Image = global::Tutorial_2_4.Properties.Resources.Finland;
            this.finlandpictureBox1.Location = new System.Drawing.Point(25, 159);
            this.finlandpictureBox1.Name = "finlandpictureBox1";
            this.finlandpictureBox1.Size = new System.Drawing.Size(214, 133);
            this.finlandpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandpictureBox1.TabIndex = 2;
            this.finlandpictureBox1.TabStop = false;
            this.finlandpictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // finlandpictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.germanypictureBox3);
            this.Controls.Add(this.FrancepictureBox);
            this.Controls.Add(this.finlandpictureBox1);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.label1);
            this.Name = "finlandpictureBox";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.germanypictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrancepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandpictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countrylabel;
        private System.Windows.Forms.PictureBox finlandpictureBox1;
        private System.Windows.Forms.PictureBox FrancepictureBox;
        private System.Windows.Forms.PictureBox germanypictureBox3;
    }
}

