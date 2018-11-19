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
            this.btnClickHere = new System.Windows.Forms.Button();
            this.btnGoodBye = new System.Windows.Forms.Button();
            this.btnClickLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(251, 69);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(96, 13);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello, Visual World";
            this.lblHello.Visible = false;
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(263, 121);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(75, 23);
            this.btnClickHere.TabIndex = 1;
            this.btnClickHere.Text = "Click Here";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click_1);
            // 
            // btnGoodBye
            // 
            this.btnGoodBye.Location = new System.Drawing.Point(263, 169);
            this.btnGoodBye.Name = "btnGoodBye";
            this.btnGoodBye.Size = new System.Drawing.Size(75, 61);
            this.btnGoodBye.TabIndex = 2;
            this.btnGoodBye.Text = "Click Me Last";
            this.btnGoodBye.UseVisualStyleBackColor = true;
            this.btnGoodBye.Click += new System.EventHandler(this.btnGoodBye_Click);
            // 
            // btnClickLast
            // 
            this.btnClickLast.Location = new System.Drawing.Point(263, 264);
            this.btnClickLast.Name = "btnClickLast";
            this.btnClickLast.Size = new System.Drawing.Size(75, 63);
            this.btnClickLast.TabIndex = 3;
            this.btnClickLast.Text = "No Really Click Me Last";
            this.btnClickLast.UseVisualStyleBackColor = true;
            this.btnClickLast.Click += new System.EventHandler(this.btnClickLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.btnClickLast);
            this.Controls.Add(this.btnGoodBye);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.lblHello);
            this.Name = "Form1";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Button btnGoodBye;
        private System.Windows.Forms.Button btnClickLast;
    }
}

