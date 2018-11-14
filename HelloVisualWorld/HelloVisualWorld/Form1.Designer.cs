namespace HelloVisualWorld
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnHere = new System.Windows.Forms.Button();
            this.btnGoodBye = new System.Windows.Forms.Button();
            this.btnReallyLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(90, 67);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(96, 13);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello Visual World!";
            this.lblHello.Visible = false;
            // 
            // btnHere
            // 
            this.btnHere.Location = new System.Drawing.Point(109, 208);
            this.btnHere.Name = "btnHere";
            this.btnHere.Size = new System.Drawing.Size(113, 40);
            this.btnHere.TabIndex = 1;
            this.btnHere.Text = "Click Here";
            this.btnHere.UseVisualStyleBackColor = true;
            this.btnHere.Click += new System.EventHandler(this.btnHere_Click);
            // 
            // btnGoodBye
            // 
            this.btnGoodBye.Location = new System.Drawing.Point(344, 205);
            this.btnGoodBye.Name = "btnGoodBye";
            this.btnGoodBye.Size = new System.Drawing.Size(113, 40);
            this.btnGoodBye.TabIndex = 2;
            this.btnGoodBye.Text = "Click Me Last";
            this.btnGoodBye.UseVisualStyleBackColor = true;
            this.btnGoodBye.Click += new System.EventHandler(this.btnGoodBye_Click);
            // 
            // btnReallyLast
            // 
            this.btnReallyLast.Location = new System.Drawing.Point(493, 205);
            this.btnReallyLast.Name = "btnReallyLast";
            this.btnReallyLast.Size = new System.Drawing.Size(106, 79);
            this.btnReallyLast.TabIndex = 3;
            this.btnReallyLast.Text = "No Really Click Me Last";
            this.btnReallyLast.UseVisualStyleBackColor = true;
            this.btnReallyLast.Click += new System.EventHandler(this.btnReallyLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReallyLast);
            this.Controls.Add(this.btnGoodBye);
            this.Controls.Add(this.btnHere);
            this.Controls.Add(this.lblHello);
            this.Name = "Form1";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnHere;
        private System.Windows.Forms.Button btnGoodBye;
        private System.Windows.Forms.Button btnReallyLast;
    }
}

