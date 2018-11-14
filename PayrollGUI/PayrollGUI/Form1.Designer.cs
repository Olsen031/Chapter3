namespace PayrollGUI
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
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtSSNInput = new System.Windows.Forms.TextBox();
            this.txtHourlyWageInput = new System.Windows.Forms.TextBox();
            this.txtHoursWorkedInput = new System.Windows.Forms.TextBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.lblFirstAndLast = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(65, 75);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(221, 13);
            this.lblSSN.TabIndex = 0;
            this.lblSSN.Text = "Enter social security #. Format XX-XXX-XXXX";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(65, 130);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(151, 13);
            this.lblHourlyRate.TabIndex = 1;
            this.lblHourlyRate.Text = "Enter your current hourly wage";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(65, 181);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(193, 13);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "Enter the total number of hours worked ";
            // 
            // txtSSNInput
            // 
            this.txtSSNInput.Location = new System.Drawing.Point(332, 75);
            this.txtSSNInput.Name = "txtSSNInput";
            this.txtSSNInput.Size = new System.Drawing.Size(100, 20);
            this.txtSSNInput.TabIndex = 3;
            // 
            // txtHourlyWageInput
            // 
            this.txtHourlyWageInput.Location = new System.Drawing.Point(332, 130);
            this.txtHourlyWageInput.Name = "txtHourlyWageInput";
            this.txtHourlyWageInput.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyWageInput.TabIndex = 4;
            // 
            // txtHoursWorkedInput
            // 
            this.txtHoursWorkedInput.Location = new System.Drawing.Point(332, 181);
            this.txtHoursWorkedInput.Name = "txtHoursWorkedInput";
            this.txtHoursWorkedInput.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorkedInput.TabIndex = 5;
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(332, 23);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(100, 20);
            this.txtNameInput.TabIndex = 6;
            // 
            // lblFirstAndLast
            // 
            this.lblFirstAndLast.AutoSize = true;
            this.lblFirstAndLast.Location = new System.Drawing.Point(65, 23);
            this.lblFirstAndLast.Name = "lblFirstAndLast";
            this.lblFirstAndLast.Size = new System.Drawing.Size(177, 13);
            this.lblFirstAndLast.TabIndex = 7;
            this.lblFirstAndLast.Text = "Please enter your first and last name";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(519, 75);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 91);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Click to calculate Gross Pay, Net Pay, and Withholding Taxes";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFirstAndLast);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.txtHoursWorkedInput);
            this.Controls.Add(this.txtHourlyWageInput);
            this.Controls.Add(this.txtSSNInput);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblSSN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtSSNInput;
        private System.Windows.Forms.TextBox txtHourlyWageInput;
        private System.Windows.Forms.TextBox txtHoursWorkedInput;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.Label lblFirstAndLast;
        private System.Windows.Forms.Button btnCalculate;
    }
}

