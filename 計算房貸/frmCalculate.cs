using System;
using System.Text;
using System.Windows.Forms;

namespace MortgageApp
{
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();

            // --- 強效補丁：手動確保按鈕點擊事件有連上 ---
            // 預防 Designer.cs 失效，在建構子強制重新綁定
            this.btnCalculate.Click -= new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 執行時發出嗶聲，方便偵錯確按鈕是否有反應
                Console.Beep();
                txtResult.Clear();

                // 1. 取得輸入值
                double totalPrice = (double)numTotalPrice.Value;
                double downPayment = (double)numDownPayment.Value;
                double annualRate = (double)numRate.Value / 100;
                int loanYears = (int)numYears.Value;
                int graceYears = (int)numGrace.Value;

                // 基本防呆
                if (downPayment >= totalPrice)
                {
                    MessageBox.Show("自備款不能大於或等於房屋總價！", "輸入提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (graceYears >= loanYears)
                {
                    MessageBox.Show("寬限期不能超過貸款年限！", "輸入提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. 核心計算
                double loanAmount = totalPrice - downPayment;
                double monthlyRate = annualRate / 12;
                int totalMonths = loanYears * 12;
                int graceMonths = graceYears * 12;
                int repaymentMonths = totalMonths - graceMonths;

                double monthlyPayment = 0;
                double firstMonthInterest = loanAmount * monthlyRate;

                // 本息平均攤還公式
                if (monthlyRate > 0)
                {
                    monthlyPayment = (loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, repaymentMonths))
                                     / (Math.Pow(1 + monthlyRate, repaymentMonths) - 1);
                }
                else
                {
                    monthlyPayment = loanAmount / repaymentMonths;
                }

                double firstMonthPrincipal = (graceYears > 0) ? 0 : (monthlyPayment - firstMonthInterest);
                double totalInterest = (firstMonthInterest * graceMonths) + (monthlyPayment * repaymentMonths) - loanAmount;
                double totalRepay = loanAmount + totalInterest;

                // 3. 格式化輸出
                StringBuilder sb = new StringBuilder();
                string divider = new string('=', 35);

                sb.AppendLine(divider);
                sb.AppendLine("      【 房 貸 試 算 報 表 】");
                sb.AppendLine(divider);

                // 使用 \t (Tab) 配合固定寬度讓大字型下對齊更精準
                sb.AppendLine(string.Format("{0,-12}\t{1,15:N0} 元", "貸款總金額：", loanAmount));
                sb.AppendLine(string.Format("{0,-12}\t{1,15:N0} 元", "寬限期月繳：", firstMonthInterest));
                sb.AppendLine(string.Format("{0,-12}\t{1,15:N0} 元", "還款期月繳：", monthlyPayment));

                sb.AppendLine(new string('-', 35));

                sb.AppendLine(string.Format("{0,-12}\t{1,15:N0} 元", "首期本金：", firstMonthPrincipal));
                sb.AppendLine(string.Format("{0,-12}\t{1,15:N0} 元", "首期利息：", firstMonthInterest));

                sb.AppendLine(new string('-', 35));

                sb.AppendLine(string.Format("{0,-12}\t{1,15:N0} 元", "總支付利息：", totalInterest));
                sb.AppendLine(string.Format("{0,-12}\t{1,15:N0} 元", "總還款金額：", totalRepay));

                sb.AppendLine(divider);
                sb.AppendLine("\n※ 以上結果僅供參考，實際請洽銀行。");

                // 將結果塞入 TextBox
                txtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"計算過程發生錯誤：{ex.Message}", "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
