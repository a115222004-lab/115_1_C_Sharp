using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    // 表單類別：處理使用者介面與事件
    // 此類別透過設計工具產生部分內容（見 Form1.Designer.cs），
    // 並在本檔案中實作按鈕事件的行為。
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            // 載入由設計工具產生的控制項配置與屬性
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 按下「顯示日期」後將各輸入欄位的文字組合成一個顯示字串
            // 使用全形逗號（，）作為欄位分隔符號，並將結果放入輸出標籤
            string output = dayOfWeekTextBox.Text + "，" + monthTextBox.Text + "，" + dayOfMonthTextBox.Text + "，" + yearTextBox.Text;
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 按下「清除」時清空所有輸入欄位與輸出標籤
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();
            dateOutputLabel.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
