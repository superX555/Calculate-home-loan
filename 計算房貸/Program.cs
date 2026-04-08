using System;
using System.Windows.Forms;

namespace MortgageApp // 修改這裡，與 Form 一致
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 確保啟動的是 MortgageApp 裡的 frmCalculate
            Application.Run(new frmCalculate());
        }
    }
}
