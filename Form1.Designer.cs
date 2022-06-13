namespace WindowsFormsApp1
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnName1 = new System.Windows.Forms.Label();
            this.btn2Pass = new System.Windows.Forms.Label();
            this.textBx1 = new System.Windows.Forms.TextBox();
            this.textBx2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(15, 218);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(117, 33);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnName1
            // 
            this.btnName1.AutoSize = true;
            this.btnName1.Location = new System.Drawing.Point(12, 112);
            this.btnName1.Name = "btnName1";
            this.btnName1.Size = new System.Drawing.Size(78, 16);
            this.btnName1.TabIndex = 2;
            this.btnName1.Text = "Enter Name";
            this.btnName1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn2Pass
            // 
            this.btn2Pass.AutoSize = true;
            this.btn2Pass.Location = new System.Drawing.Point(12, 172);
            this.btn2Pass.Name = "btn2Pass";
            this.btn2Pass.Size = new System.Drawing.Size(101, 16);
            this.btn2Pass.TabIndex = 3;
            this.btn2Pass.Text = "Enter Password";
            // 
            // textBx1
            // 
            this.textBx1.Location = new System.Drawing.Point(172, 112);
            this.textBx1.Name = "textBx1";
            this.textBx1.Size = new System.Drawing.Size(131, 22);
            this.textBx1.TabIndex = 4;
            this.textBx1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBx2
            // 
            this.textBx2.Location = new System.Drawing.Point(172, 169);
            this.textBx2.Name = "textBx2";
            this.textBx2.Size = new System.Drawing.Size(131, 22);
            this.textBx2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 320);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBx2);
            this.Controls.Add(this.textBx1);
            this.Controls.Add(this.btn2Pass);
            this.Controls.Add(this.btnName1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label btnName1;
        private System.Windows.Forms.Label btn2Pass;
        private System.Windows.Forms.TextBox textBx1;
        private System.Windows.Forms.TextBox textBx2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

