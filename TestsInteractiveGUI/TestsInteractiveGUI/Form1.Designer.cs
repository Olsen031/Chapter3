namespace TestsInteractiveGUI
{
    partial class lblResult
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
            this.lblQuestionToUser = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore5 = new System.Windows.Forms.TextBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestionToUser
            // 
            this.lblQuestionToUser.AutoSize = true;
            this.lblQuestionToUser.Location = new System.Drawing.Point(222, 72);
            this.lblQuestionToUser.Name = "lblQuestionToUser";
            this.lblQuestionToUser.Size = new System.Drawing.Size(252, 13);
            this.lblQuestionToUser.TabIndex = 0;
            this.lblQuestionToUser.Text = "Enter your previous 5 test scores in the boxes below";
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(160, 153);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 1;
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(237, 215);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(100, 20);
            this.txtScore4.TabIndex = 2;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(493, 153);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 20);
            this.txtScore3.TabIndex = 3;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(329, 153);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 4;
            // 
            // txtScore5
            // 
            this.txtScore5.Location = new System.Drawing.Point(411, 215);
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.Size = new System.Drawing.Size(100, 20);
            this.txtScore5.TabIndex = 5;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(281, 269);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(182, 67);
            this.btnCalculateAverage.TabIndex = 6;
            this.btnCalculateAverage.Text = "Calculate your average test score";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(302, 371);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(35, 13);
            this.lblResult1.TabIndex = 7;
            this.lblResult1.Text = "label1";
            this.lblResult1.Visible = false;
            // 
            // lblResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.txtScore5);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblQuestionToUser);
            this.Name = "lblResult";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionToUser;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore5;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblResult1;
    }
}

