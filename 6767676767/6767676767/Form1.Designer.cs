namespace _6767676767
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Finland = new System.Windows.Forms.PictureBox();
            this.Germany = new System.Windows.Forms.PictureBox();
            this.France = new System.Windows.Forms.PictureBox();
            this.countryLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Finland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Germany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.France)).BeginInit();
            this.SuspendLayout();
            // 
            // Finland
            // 
            this.Finland.Image = ((System.Drawing.Image)(resources.GetObject("Finland.Image")));
            this.Finland.Location = new System.Drawing.Point(52, 96);
            this.Finland.Name = "Finland";
            this.Finland.Size = new System.Drawing.Size(192, 110);
            this.Finland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Finland.TabIndex = 0;
            this.Finland.TabStop = false;
            this.Finland.Click += new System.EventHandler(this.Finland_Click);
            // 
            // Germany
            // 
            this.Germany.Image = global::_6767676767.Properties.Resources.Germany;
            this.Germany.Location = new System.Drawing.Point(293, 99);
            this.Germany.Name = "Germany";
            this.Germany.Size = new System.Drawing.Size(208, 107);
            this.Germany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Germany.TabIndex = 1;
            this.Germany.TabStop = false;
            this.Germany.Click += new System.EventHandler(this.Germany_Click);
            // 
            // France
            // 
            this.France.Image = global::_6767676767.Properties.Resources.France;
            this.France.Location = new System.Drawing.Point(553, 99);
            this.France.Name = "France";
            this.France.Size = new System.Drawing.Size(202, 107);
            this.France.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.France.TabIndex = 2;
            this.France.TabStop = false;
            this.France.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // countryLable
            // 
            this.countryLable.AutoSize = true;
            this.countryLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLable.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countryLable.Location = new System.Drawing.Point(293, 274);
            this.countryLable.Name = "countryLable";
            this.countryLable.Size = new System.Drawing.Size(2, 63);
            this.countryLable.TabIndex = 3;
            this.countryLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "點選一個國旗，我告訴你是哪個國家。";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryLable);
            this.Controls.Add(this.France);
            this.Controls.Add(this.Germany);
            this.Controls.Add(this.Finland);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Finland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Germany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.France)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Finland;
        private System.Windows.Forms.PictureBox Germany;
        private System.Windows.Forms.PictureBox France;
        private System.Windows.Forms.Label countryLable;
        private System.Windows.Forms.Label label1;
    }
}

