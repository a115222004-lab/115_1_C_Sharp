using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fuel_Economy
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 設定 Windows Forms 的視覺樣式與文字呈現方式。
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 建立並執行主表單。
            Application.Run(new Form1());
        }
    }
}
