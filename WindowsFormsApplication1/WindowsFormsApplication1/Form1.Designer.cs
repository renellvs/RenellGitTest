namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.ForeColor = System.Drawing.Color.Red;
            this.lblHello.Location = new System.Drawing.Point(76, 99);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(152, 13);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Testing Testing testing Testing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(60, 160);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(110, 38);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHello;
    }
}

