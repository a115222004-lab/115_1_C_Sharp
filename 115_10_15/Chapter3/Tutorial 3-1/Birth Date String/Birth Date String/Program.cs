using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Birth_Date_String
{
    static class Program
    {
        /// <summary>
        /// 應用程式進入點：設定視覺樣式並啟動主表單。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用視覺樣式，使表單使用系統或主題的外觀
            Application.EnableVisualStyles();
            // 設定文字繪製相容性（一般保留預設值 false）
            Application.SetCompatibleTextRenderingDefault(false);
            // 建立並執行主表單，開始事件迴圈
            Application.Run(new Form1());
        }
    }
}
