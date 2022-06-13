namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpIdBox1 = new System.Windows.Forms.TextBox();
            this.EmpNameBox2 = new System.Windows.Forms.TextBox();
            this.EmpSalaryBox3 = new System.Windows.Forms.TextBox();
            this.EmpDepNameBox4 = new System.Windows.Forms.TextBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Emp Name";
            // 
            // EmpIdBox1
            // 
            this.EmpIdBox1.Location = new System.Drawing.Point(216, 44);
            this.EmpIdBox1.Name = "EmpIdBox1";
            this.EmpIdBox1.Size = new System.Drawing.Size(105, 22);
            this.EmpIdBox1.TabIndex = 5;
            // 
            // EmpNameBox2
            // 
            this.EmpNameBox2.Location = new System.Drawing.Point(216, 112);
            this.EmpNameBox2.Name = "EmpNameBox2";
            this.EmpNameBox2.Size = new System.Drawing.Size(105, 22);
            this.EmpNameBox2.TabIndex = 6;
            // 
            // EmpSalaryBox3
            // 
            this.EmpSalaryBox3.Location = new System.Drawing.Point(216, 167);
            this.EmpSalaryBox3.Name = "EmpSalaryBox3";
            this.EmpSalaryBox3.Size = new System.Drawing.Size(105, 22);
            this.EmpSalaryBox3.TabIndex = 7;
            // 
            // EmpDepNameBox4
            // 
            this.EmpDepNameBox4.Location = new System.Drawing.Point(216, 231);
            this.EmpDepNameBox4.Name = "EmpDepNameBox4";
            this.EmpDepNameBox4.Size = new System.Drawing.Size(105, 22);
            this.EmpDepNameBox4.TabIndex = 8;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(15, 299);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(100, 32);
            this.showbutton.TabIndex = 10;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(216, 299);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(105, 32);
            this.clearbutton.TabIndex = 11;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 364);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.EmpDepNameBox4);
            this.Controls.Add(this.EmpSalaryBox3);
            this.Controls.Add(this.EmpNameBox2);
            this.Controls.Add(this.EmpIdBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpIdBox1;
        private System.Windows.Forms.TextBox EmpNameBox2;
        private System.Windows.Forms.TextBox EmpSalaryBox3;
        private System.Windows.Forms.TextBox EmpDepNameBox4;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button clearbutton;
    }
}