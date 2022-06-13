namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Addbtn1 = new System.Windows.Forms.Button();
            this.Delbtn2 = new System.Windows.Forms.Button();
            this.Clearbtn3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "kudh";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Addbtn1
            // 
            this.Addbtn1.Location = new System.Drawing.Point(377, 46);
            this.Addbtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addbtn1.Name = "Addbtn1";
            this.Addbtn1.Size = new System.Drawing.Size(100, 28);
            this.Addbtn1.TabIndex = 2;
            this.Addbtn1.Text = "ADD";
            this.Addbtn1.UseVisualStyleBackColor = true;
            this.Addbtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delbtn2
            // 
            this.Delbtn2.Location = new System.Drawing.Point(377, 130);
            this.Delbtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delbtn2.Name = "Delbtn2";
            this.Delbtn2.Size = new System.Drawing.Size(100, 28);
            this.Delbtn2.TabIndex = 3;
            this.Delbtn2.Text = "Delete Name";
            this.Delbtn2.UseVisualStyleBackColor = true;
            this.Delbtn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clearbtn3
            // 
            this.Clearbtn3.Location = new System.Drawing.Point(377, 202);
            this.Clearbtn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clearbtn3.Name = "Clearbtn3";
            this.Clearbtn3.Size = new System.Drawing.Size(100, 28);
            this.Clearbtn3.TabIndex = 4;
            this.Clearbtn3.Text = "Clear";
            this.Clearbtn3.UseVisualStyleBackColor = true;
            this.Clearbtn3.Click += new System.EventHandler(this.Clearbtn3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(173, 113);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 116);
            this.listBox1.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 297);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Clearbtn3);
            this.Controls.Add(this.Delbtn2);
            this.Controls.Add(this.Addbtn1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Addbtn1;
        private System.Windows.Forms.Button Delbtn2;
        private System.Windows.Forms.Button Clearbtn3;
        private System.Windows.Forms.ListBox listBox1;
    }
}