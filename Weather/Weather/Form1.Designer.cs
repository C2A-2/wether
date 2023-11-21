namespace Weather
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.maxtemCheckBox = new System.Windows.Forms.CheckBox();
            this.mintemCheckBox = new System.Windows.Forms.CheckBox();
            this.winspCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(117, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "☺たくくんのおてんきよほう☺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "緯度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(24, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "経度";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(107, 141);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(212, 25);
            this.latBox.TabIndex = 3;
            this.latBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lonBox
            // 
            this.lonBox.Location = new System.Drawing.Point(107, 202);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(212, 25);
            this.lonBox.TabIndex = 4;
            this.lonBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maxtemCheckBox
            // 
            this.maxtemCheckBox.AutoSize = true;
            this.maxtemCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxtemCheckBox.Location = new System.Drawing.Point(325, 137);
            this.maxtemCheckBox.Name = "maxtemCheckBox";
            this.maxtemCheckBox.Size = new System.Drawing.Size(136, 28);
            this.maxtemCheckBox.TabIndex = 8;
            this.maxtemCheckBox.Text = "最高気温";
            this.maxtemCheckBox.UseVisualStyleBackColor = true;
            // 
            // mintemCheckBox
            // 
            this.mintemCheckBox.AutoSize = true;
            this.mintemCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mintemCheckBox.Location = new System.Drawing.Point(325, 198);
            this.mintemCheckBox.Name = "mintemCheckBox";
            this.mintemCheckBox.Size = new System.Drawing.Size(136, 28);
            this.mintemCheckBox.TabIndex = 9;
            this.mintemCheckBox.Text = "最低気温";
            this.mintemCheckBox.UseVisualStyleBackColor = true;
            // 
            // winspCheckBox
            // 
            this.winspCheckBox.AutoSize = true;
            this.winspCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.winspCheckBox.Location = new System.Drawing.Point(485, 137);
            this.winspCheckBox.Name = "winspCheckBox";
            this.winspCheckBox.Size = new System.Drawing.Size(86, 28);
            this.winspCheckBox.TabIndex = 10;
            this.winspCheckBox.Text = "風速";
            this.winspCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(152, 248);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(309, 33);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "実行";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 310);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.winspCheckBox);
            this.Controls.Add(this.mintemCheckBox);
            this.Controls.Add(this.maxtemCheckBox);
            this.Controls.Add(this.lonBox);
            this.Controls.Add(this.latBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "天気予報";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.CheckBox maxtemCheckBox;
        private System.Windows.Forms.CheckBox mintemCheckBox;
        private System.Windows.Forms.CheckBox winspCheckBox;
        private System.Windows.Forms.Button startButton;
    }
}

