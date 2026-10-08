namespace toutrial2_5
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
            this.cardFace = new System.Windows.Forms.PictureBox();
            this.cardBack = new System.Windows.Forms.PictureBox();
            this.showback = new System.Windows.Forms.Button();
            this.showface = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFace
            // 
            this.cardFace.Image = global::toutrial2_5.Properties.Resources.King_Hearts;
            this.cardFace.Location = new System.Drawing.Point(283, 61);
            this.cardFace.Name = "cardFace";
            this.cardFace.Size = new System.Drawing.Size(210, 289);
            this.cardFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFace.TabIndex = 0;
            this.cardFace.TabStop = false;
            this.cardFace.Visible = false;
            this.cardFace.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cardBack
            // 
            this.cardBack.Image = global::toutrial2_5.Properties.Resources.Backface_Blue;
            this.cardBack.Location = new System.Drawing.Point(275, 61);
            this.cardBack.Name = "cardBack";
            this.cardBack.Size = new System.Drawing.Size(218, 289);
            this.cardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBack.TabIndex = 1;
            this.cardBack.TabStop = false;
            // 
            // showback
            // 
            this.showback.Location = new System.Drawing.Point(144, 370);
            this.showback.Name = "showback";
            this.showback.Size = new System.Drawing.Size(136, 68);
            this.showback.TabIndex = 2;
            this.showback.Text = "顯示背面";
            this.showback.UseVisualStyleBackColor = true;
            this.showback.Click += new System.EventHandler(this.showback_Click);
            // 
            // showface
            // 
            this.showface.Location = new System.Drawing.Point(533, 370);
            this.showface.Name = "showface";
            this.showface.Size = new System.Drawing.Size(136, 68);
            this.showface.TabIndex = 3;
            this.showface.Text = "顯示正面";
            this.showface.UseVisualStyleBackColor = true;
            this.showface.Click += new System.EventHandler(this.showface_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showface);
            this.Controls.Add(this.showback);
            this.Controls.Add(this.cardBack);
            this.Controls.Add(this.cardFace);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cardFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardFace;
        private System.Windows.Forms.PictureBox cardBack;
        private System.Windows.Forms.Button showback;
        private System.Windows.Forms.Button showface;
    }
}

