namespace WindowsFormsApp1
{
    partial class Form5
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
            this.textBox1ID = new System.Windows.Forms.TextBox();
            this.textBox2Name = new System.Windows.Forms.TextBox();
            this.textBox3Fees = new System.Windows.Forms.TextBox();
            this.btn1Save = new System.Windows.Forms.Button();
            this.btn2Read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1ID
            // 
            this.textBox1ID.Location = new System.Drawing.Point(172, 89);
            this.textBox1ID.Name = "textBox1ID";
            this.textBox1ID.Size = new System.Drawing.Size(100, 22);
            this.textBox1ID.TabIndex = 0;
            // 
            // textBox2Name
            // 
            this.textBox2Name.Location = new System.Drawing.Point(172, 181);
            this.textBox2Name.Name = "textBox2Name";
            this.textBox2Name.Size = new System.Drawing.Size(100, 22);
            this.textBox2Name.TabIndex = 1;
            // 
            // textBox3Fees
            // 
            this.textBox3Fees.Location = new System.Drawing.Point(172, 275);
            this.textBox3Fees.Name = "textBox3Fees";
            this.textBox3Fees.Size = new System.Drawing.Size(100, 22);
            this.textBox3Fees.TabIndex = 2;
            // 
            // btn1Save
            // 
            this.btn1Save.Location = new System.Drawing.Point(27, 344);
            this.btn1Save.Name = "btn1Save";
            this.btn1Save.Size = new System.Drawing.Size(91, 38);
            this.btn1Save.TabIndex = 6;
            this.btn1Save.Text = "Write";
            this.btn1Save.UseVisualStyleBackColor = true;
            this.btn1Save.Click += new System.EventHandler(this.btn1Save_Click);
            // 
            // btn2Read
            // 
            this.btn2Read.Location = new System.Drawing.Point(172, 344);
            this.btn2Read.Name = "btn2Read";
            this.btn2Read.Size = new System.Drawing.Size(91, 38);
            this.btn2Read.TabIndex = 7;
            this.btn2Read.Text = "READ";
            this.btn2Read.UseVisualStyleBackColor = true;
            this.btn2Read.Click += new System.EventHandler(this.btn2Read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "  ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Course Fess";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2Read);
            this.Controls.Add(this.btn1Save);
            this.Controls.Add(this.textBox3Fees);
            this.Controls.Add(this.textBox2Name);
            this.Controls.Add(this.textBox1ID);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1ID;
        private System.Windows.Forms.TextBox textBox2Name;
        private System.Windows.Forms.TextBox textBox3Fees;
        private System.Windows.Forms.Button btn1Save;
        private System.Windows.Forms.Button btn2Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}