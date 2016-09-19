namespace Chapter_12.Exercises
{
    partial class Exercise_10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numWithdraw = new System.Windows.Forms.NumericUpDown();
            this.numDeposit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numWithdraw
            // 
            this.numWithdraw.DecimalPlaces = 2;
            this.numWithdraw.Location = new System.Drawing.Point(12, 91);
            this.numWithdraw.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWithdraw.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numWithdraw.Name = "numWithdraw";
            this.numWithdraw.Size = new System.Drawing.Size(120, 20);
            this.numWithdraw.TabIndex = 2;
            this.numWithdraw.ThousandsSeparator = true;
            // 
            // numDeposit
            // 
            this.numDeposit.DecimalPlaces = 2;
            this.numDeposit.Location = new System.Drawing.Point(12, 117);
            this.numDeposit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDeposit.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numDeposit.Name = "numDeposit";
            this.numDeposit.Size = new System.Drawing.Size(120, 20);
            this.numDeposit.TabIndex = 3;
            this.numDeposit.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exercise_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDeposit);
            this.Controls.Add(this.numWithdraw);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Exercise_10";
            this.Text = "Exercise_10";
            this.Load += new System.EventHandler(this.Exercise_10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numWithdraw;
        private System.Windows.Forms.NumericUpDown numDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}