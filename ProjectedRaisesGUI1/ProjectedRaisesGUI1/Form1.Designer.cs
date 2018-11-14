namespace ProjectedRaisesGUI1
{
    partial class ProjectedRaisesGUI
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
            this.lblEmployee1 = new System.Windows.Forms.Label();
            this.lblEmployee2 = new System.Windows.Forms.Label();
            this.lblEmployee3 = new System.Windows.Forms.Label();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btnEmployee1 = new System.Windows.Forms.Button();
            this.btnEmployee2 = new System.Windows.Forms.Button();
            this.btnEmployee3 = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployee1
            // 
            this.lblEmployee1.AutoSize = true;
            this.lblEmployee1.Location = new System.Drawing.Point(80, 94);
            this.lblEmployee1.Name = "lblEmployee1";
            this.lblEmployee1.Size = new System.Drawing.Size(129, 13);
            this.lblEmployee1.TabIndex = 0;
            this.lblEmployee1.Text = "Enter Employee 1\'s Salary";
            // 
            // lblEmployee2
            // 
            this.lblEmployee2.AutoSize = true;
            this.lblEmployee2.Location = new System.Drawing.Point(80, 186);
            this.lblEmployee2.Name = "lblEmployee2";
            this.lblEmployee2.Size = new System.Drawing.Size(129, 13);
            this.lblEmployee2.TabIndex = 1;
            this.lblEmployee2.Text = "Enter Employee 2\'s Salary";
            // 
            // lblEmployee3
            // 
            this.lblEmployee3.AutoSize = true;
            this.lblEmployee3.Location = new System.Drawing.Point(80, 266);
            this.lblEmployee3.Name = "lblEmployee3";
            this.lblEmployee3.Size = new System.Drawing.Size(129, 13);
            this.lblEmployee3.TabIndex = 2;
            this.lblEmployee3.Text = "Enter Employee 3\'s Salary";
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(208, 266);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(100, 20);
            this.txtbox3.TabIndex = 3;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(208, 186);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 20);
            this.txtbox2.TabIndex = 4;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(208, 94);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 20);
            this.txtbox1.TabIndex = 5;
            // 
            // btnEmployee1
            // 
            this.btnEmployee1.Location = new System.Drawing.Point(353, 91);
            this.btnEmployee1.Name = "btnEmployee1";
            this.btnEmployee1.Size = new System.Drawing.Size(75, 23);
            this.btnEmployee1.TabIndex = 6;
            this.btnEmployee1.Text = "Calculate";
            this.btnEmployee1.UseVisualStyleBackColor = true;
            this.btnEmployee1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployee2
            // 
            this.btnEmployee2.Location = new System.Drawing.Point(353, 186);
            this.btnEmployee2.Name = "btnEmployee2";
            this.btnEmployee2.Size = new System.Drawing.Size(75, 23);
            this.btnEmployee2.TabIndex = 7;
            this.btnEmployee2.Text = "Calculate";
            this.btnEmployee2.UseVisualStyleBackColor = true;
            this.btnEmployee2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmployee3
            // 
            this.btnEmployee3.Location = new System.Drawing.Point(353, 261);
            this.btnEmployee3.Name = "btnEmployee3";
            this.btnEmployee3.Size = new System.Drawing.Size(75, 23);
            this.btnEmployee3.TabIndex = 8;
            this.btnEmployee3.Text = "Calculate";
            this.btnEmployee3.UseVisualStyleBackColor = true;
            this.btnEmployee3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(472, 91);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(0, 13);
            this.lblResult1.TabIndex = 9;
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Location = new System.Drawing.Point(472, 269);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(0, 13);
            this.lblResult3.TabIndex = 10;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(472, 189);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 13);
            this.lblResult2.TabIndex = 11;
            // 
            // ProjectedRaisesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.btnEmployee3);
            this.Controls.Add(this.btnEmployee2);
            this.Controls.Add(this.btnEmployee1);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.lblEmployee3);
            this.Controls.Add(this.lblEmployee2);
            this.Controls.Add(this.lblEmployee1);
            this.Name = "ProjectedRaisesGUI";
            this.Text = "Projected Raises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee1;
        private System.Windows.Forms.Label lblEmployee2;
        private System.Windows.Forms.Label lblEmployee3;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btnEmployee1;
        private System.Windows.Forms.Button btnEmployee2;
        private System.Windows.Forms.Button btnEmployee3;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Label lblResult2;
    }
}

