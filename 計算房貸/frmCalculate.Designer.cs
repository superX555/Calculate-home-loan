namespace MortgageApp
{
    partial class frmCalculate
    {
        /// <summary>
        /// 設計器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計器產生的程式碼

        /// <summary>
        /// 此為設計器支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.numTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.numDownPayment = new System.Windows.Forms.NumericUpDown();
            this.lblRate = new System.Windows.Forms.Label();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.lblYears = new System.Windows.Forms.Label();
            this.numYears = new System.Windows.Forms.NumericUpDown();
            this.lblGrace = new System.Windows.Forms.Label();
            this.numGrace = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrace)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPrice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numTotalPrice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDownPayment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numDownPayment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numRate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYears, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numYears, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGrace, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numGrace, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 230);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.Location = new System.Drawing.Point(3, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(219, 45);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "房屋總價 (元):";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTotalPrice
            // 
            this.numTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.numTotalPrice.Location = new System.Drawing.Point(228, 3);
            this.numTotalPrice.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numTotalPrice.Name = "numTotalPrice";
            this.numTotalPrice.Size = new System.Drawing.Size(269, 34);
            this.numTotalPrice.TabIndex = 1;
            this.numTotalPrice.ThousandsSeparator = true;
            this.numTotalPrice.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDownPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblDownPayment.Location = new System.Drawing.Point(3, 45);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(219, 45);
            this.lblDownPayment.TabIndex = 2;
            this.lblDownPayment.Text = "自備款金額 (元):";
            this.lblDownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numDownPayment
            // 
            this.numDownPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDownPayment.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.numDownPayment.Location = new System.Drawing.Point(228, 48);
            this.numDownPayment.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numDownPayment.Name = "numDownPayment";
            this.numDownPayment.Size = new System.Drawing.Size(269, 34);
            this.numDownPayment.TabIndex = 3;
            this.numDownPayment.ThousandsSeparator = true;
            this.numDownPayment.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            // 
            // lblRate
            // 
            this.lblRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblRate.Location = new System.Drawing.Point(3, 90);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(219, 45);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "年利率 (%):";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numRate
            // 
            this.numRate.DecimalPlaces = 2;
            this.numRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numRate.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.numRate.Location = new System.Drawing.Point(228, 93);
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(269, 34);
            this.numRate.TabIndex = 5;
            this.numRate.Value = new decimal(new int[] {
            215,
            0,
            0,
            131072});
            // 
            // lblYears
            // 
            this.lblYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYears.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblYears.Location = new System.Drawing.Point(3, 135);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(219, 45);
            this.lblYears.TabIndex = 6;
            this.lblYears.Text = "貸款年限 (年):";
            this.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numYears
            // 
            this.numYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numYears.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.numYears.Location = new System.Drawing.Point(228, 138);
            this.numYears.Name = "numYears";
            this.numYears.Size = new System.Drawing.Size(269, 34);
            this.numYears.TabIndex = 7;
            this.numYears.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblGrace
            // 
            this.lblGrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrace.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrace.Location = new System.Drawing.Point(3, 180);
            this.lblGrace.Name = "lblGrace";
            this.lblGrace.Size = new System.Drawing.Size(219, 50);
            this.lblGrace.TabIndex = 8;
            this.lblGrace.Text = "寬限期 (年):";
            this.lblGrace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numGrace
            // 
            this.numGrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numGrace.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.numGrace.Location = new System.Drawing.Point(228, 183);
            this.numGrace.Name = "numGrace";
            this.numGrace.Size = new System.Drawing.Size(269, 34);
            this.numGrace.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(25, 270);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(500, 60);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "計算房貸結果";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtResult.Location = new System.Drawing.Point(25, 345);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(500, 280);
            this.txtResult.TabIndex = 2;
            // 
            // frmCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 650);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCalculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "專業房貸試算器 v2.0";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.NumericUpDown numTotalPrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.NumericUpDown numDownPayment;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.NumericUpDown numYears;
        private System.Windows.Forms.Label lblGrace;
        private System.Windows.Forms.NumericUpDown numGrace;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
    }
}

