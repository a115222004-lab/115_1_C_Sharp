namespace Tutorial2_3
{
    partial class Form1
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
            this.translateLabel = new System.Windows.Forms.Label();
            this.義大利 = new System.Windows.Forms.Button();
            this.德國 = new System.Windows.Forms.Button();
            this.西班牙 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我告訴你怎麼說\r\n\"早安\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateLabel.Location = new System.Drawing.Point(245, 136);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(229, 86);
            this.translateLabel.TabIndex = 1;
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.translateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // 義大利
            // 
            this.義大利.Location = new System.Drawing.Point(84, 317);
            this.義大利.Name = "義大利";
            this.義大利.Size = new System.Drawing.Size(106, 77);
            this.義大利.TabIndex = 2;
            this.義大利.Text = "義大利";
            this.義大利.UseVisualStyleBackColor = true;
            this.義大利.Click += new System.EventHandler(this.button1_Click);
            // 
            // 德國
            // 
            this.德國.Location = new System.Drawing.Point(583, 317);
            this.德國.Name = "德國";
            this.德國.Size = new System.Drawing.Size(106, 77);
            this.德國.TabIndex = 3;
            this.德國.Text = "德國";
            this.德國.UseVisualStyleBackColor = true;
            this.德國.Click += new System.EventHandler(this.德國_Click);
            // 
            // 西班牙
            // 
            this.西班牙.Location = new System.Drawing.Point(313, 317);
            this.西班牙.Name = "西班牙";
            this.西班牙.Size = new System.Drawing.Size(110, 77);
            this.西班牙.TabIndex = 4;
            this.西班牙.Text = "西班牙";
            this.西班牙.UseVisualStyleBackColor = true;
            this.西班牙.Click += new System.EventHandler(this.西班牙_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.西班牙);
            this.Controls.Add(this.德國);
            this.Controls.Add(this.義大利);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Button 義大利;
        private System.Windows.Forms.Button 德國;
        private System.Windows.Forms.Button 西班牙;
    }
}

