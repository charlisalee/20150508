namespace Example2
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.setSalaryButtonA = new System.Windows.Forms.Button();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.setSalaryButtonB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setSalaryButtonA
            // 
            this.setSalaryButtonA.Location = new System.Drawing.Point(163, 49);
            this.setSalaryButtonA.Name = "setSalaryButtonA";
            this.setSalaryButtonA.Size = new System.Drawing.Size(109, 23);
            this.setSalaryButtonA.TabIndex = 0;
            this.setSalaryButtonA.Text = "設定薪水方法A";
            this.setSalaryButtonA.UseVisualStyleBackColor = true;
            this.setSalaryButtonA.Click += new System.EventHandler(this.setSalaryButtonA_Click);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(53, 51);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 1;
            this.salaryTextBox.TextChanged += new System.EventHandler(this.salaryTextBox_TextChanged);
            // 
            // setSalaryButtonB
            // 
            this.setSalaryButtonB.Location = new System.Drawing.Point(163, 118);
            this.setSalaryButtonB.Name = "setSalaryButtonB";
            this.setSalaryButtonB.Size = new System.Drawing.Size(109, 23);
            this.setSalaryButtonB.TabIndex = 2;
            this.setSalaryButtonB.Text = "設定薪水方法B";
            this.setSalaryButtonB.UseVisualStyleBackColor = true;
            this.setSalaryButtonB.Click += new System.EventHandler(this.setSalaryButtonB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.setSalaryButtonB);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.setSalaryButtonA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setSalaryButtonA;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button setSalaryButtonB;
    }
}

