namespace GreenvilleRevenueGUI
{
    partial class Form1
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
            this.lblLastYear = new System.Windows.Forms.Label();
            this.lblThisYear = new System.Windows.Forms.Label();
            this.txtLastYearInput = new System.Windows.Forms.TextBox();
            this.txtThisYearInput = new System.Windows.Forms.TextBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.lblThisYearRevenueOutput = new System.Windows.Forms.Label();
            this.lblMoreThanLastYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastYear
            // 
            this.lblLastYear.AutoSize = true;
            this.lblLastYear.Location = new System.Drawing.Point(49, 82);
            this.lblLastYear.Name = "lblLastYear";
            this.lblLastYear.Size = new System.Drawing.Size(223, 13);
            this.lblLastYear.TabIndex = 0;
            this.lblLastYear.Text = "Enter the number of contestants from last year";
            // 
            // lblThisYear
            // 
            this.lblThisYear.AutoSize = true;
            this.lblThisYear.Location = new System.Drawing.Point(49, 140);
            this.lblThisYear.Name = "lblThisYear";
            this.lblThisYear.Size = new System.Drawing.Size(262, 13);
            this.lblThisYear.TabIndex = 1;
            this.lblThisYear.Text = "Enter the number of expected contestants for this year";
            // 
            // txtLastYearInput
            // 
            this.txtLastYearInput.Location = new System.Drawing.Point(339, 82);
            this.txtLastYearInput.Name = "txtLastYearInput";
            this.txtLastYearInput.Size = new System.Drawing.Size(100, 20);
            this.txtLastYearInput.TabIndex = 2;
            // 
            // txtThisYearInput
            // 
            this.txtThisYearInput.Location = new System.Drawing.Point(339, 133);
            this.txtThisYearInput.Name = "txtThisYearInput";
            this.txtThisYearInput.Size = new System.Drawing.Size(100, 20);
            this.txtThisYearInput.TabIndex = 3;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(339, 179);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(100, 63);
            this.btnRevenue.TabIndex = 4;
            this.btnRevenue.Text = "Click to generate revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // lblThisYearRevenueOutput
            // 
            this.lblThisYearRevenueOutput.AutoSize = true;
            this.lblThisYearRevenueOutput.Location = new System.Drawing.Point(49, 302);
            this.lblThisYearRevenueOutput.Name = "lblThisYearRevenueOutput";
            this.lblThisYearRevenueOutput.Size = new System.Drawing.Size(35, 13);
            this.lblThisYearRevenueOutput.TabIndex = 6;
            this.lblThisYearRevenueOutput.Text = "label1";
            this.lblThisYearRevenueOutput.Visible = false;
            // 
            // lblMoreThanLastYear
            // 
            this.lblMoreThanLastYear.AutoSize = true;
            this.lblMoreThanLastYear.Location = new System.Drawing.Point(49, 357);
            this.lblMoreThanLastYear.Name = "lblMoreThanLastYear";
            this.lblMoreThanLastYear.Size = new System.Drawing.Size(35, 13);
            this.lblMoreThanLastYear.TabIndex = 7;
            this.lblMoreThanLastYear.Text = "label1";
            this.lblMoreThanLastYear.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoreThanLastYear);
            this.Controls.Add(this.lblThisYearRevenueOutput);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.txtThisYearInput);
            this.Controls.Add(this.txtLastYearInput);
            this.Controls.Add(this.lblThisYear);
            this.Controls.Add(this.lblLastYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastYear;
        private System.Windows.Forms.Label lblThisYear;
        private System.Windows.Forms.TextBox txtLastYearInput;
        private System.Windows.Forms.TextBox txtThisYearInput;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Label lblThisYearRevenueOutput;
        private System.Windows.Forms.Label lblMoreThanLastYear;
    }
}

