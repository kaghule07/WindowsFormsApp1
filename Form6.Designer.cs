namespace WindowsFormsApp1
{
    partial class Form6
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
            this.btn6CreateFolder = new System.Windows.Forms.Button();
            this.btn1DepName = new System.Windows.Forms.Button();
            this.btn2DepName = new System.Windows.Forms.Button();
            this.btn3DepLoc = new System.Windows.Forms.Button();
            this.btn4Write = new System.Windows.Forms.Button();
            this.btn5Read = new System.Windows.Forms.Button();
            this.btn7CreateFile = new System.Windows.Forms.Button();
            this.textBox2Name = new System.Windows.Forms.TextBox();
            this.textBox3Loc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1ID
            // 
            this.textBox1ID.Location = new System.Drawing.Point(197, 51);
            this.textBox1ID.Name = "textBox1ID";
            this.textBox1ID.Size = new System.Drawing.Size(100, 22);
            this.textBox1ID.TabIndex = 0;
            // 
            // btn6CreateFolder
            // 
            this.btn6CreateFolder.Location = new System.Drawing.Point(399, 77);
            this.btn6CreateFolder.Name = "btn6CreateFolder";
            this.btn6CreateFolder.Size = new System.Drawing.Size(114, 49);
            this.btn6CreateFolder.TabIndex = 1;
            this.btn6CreateFolder.Text = "Create Folder";
            this.btn6CreateFolder.UseVisualStyleBackColor = true;
            this.btn6CreateFolder.Click += new System.EventHandler(this.btn6CreateFolder_Click);
            // 
            // btn1DepName
            // 
            this.btn1DepName.Location = new System.Drawing.Point(12, 42);
            this.btn1DepName.Name = "btn1DepName";
            this.btn1DepName.Size = new System.Drawing.Size(143, 41);
            this.btn1DepName.TabIndex = 2;
            this.btn1DepName.Text = "Enter Dep Id";
            this.btn1DepName.UseVisualStyleBackColor = true;
            // 
            // btn2DepName
            // 
            this.btn2DepName.Location = new System.Drawing.Point(12, 127);
            this.btn2DepName.Name = "btn2DepName";
            this.btn2DepName.Size = new System.Drawing.Size(143, 41);
            this.btn2DepName.TabIndex = 3;
            this.btn2DepName.Text = "Dept Name";
            this.btn2DepName.UseVisualStyleBackColor = true;
            // 
            // btn3DepLoc
            // 
            this.btn3DepLoc.Location = new System.Drawing.Point(12, 212);
            this.btn3DepLoc.Name = "btn3DepLoc";
            this.btn3DepLoc.Size = new System.Drawing.Size(143, 41);
            this.btn3DepLoc.TabIndex = 4;
            this.btn3DepLoc.Text = "Dep Location";
            this.btn3DepLoc.UseVisualStyleBackColor = true;
            // 
            // btn4Write
            // 
            this.btn4Write.Location = new System.Drawing.Point(12, 299);
            this.btn4Write.Name = "btn4Write";
            this.btn4Write.Size = new System.Drawing.Size(143, 41);
            this.btn4Write.TabIndex = 5;
            this.btn4Write.Text = "Write";
            this.btn4Write.UseVisualStyleBackColor = true;
            this.btn4Write.Click += new System.EventHandler(this.btn4Write_Click);
            // 
            // btn5Read
            // 
            this.btn5Read.Location = new System.Drawing.Point(197, 299);
            this.btn5Read.Name = "btn5Read";
            this.btn5Read.Size = new System.Drawing.Size(100, 41);
            this.btn5Read.TabIndex = 6;
            this.btn5Read.Text = "Read";
            this.btn5Read.UseVisualStyleBackColor = true;
            this.btn5Read.Click += new System.EventHandler(this.btn5Read_Click);
            // 
            // btn7CreateFile
            // 
            this.btn7CreateFile.Location = new System.Drawing.Point(399, 190);
            this.btn7CreateFile.Name = "btn7CreateFile";
            this.btn7CreateFile.Size = new System.Drawing.Size(114, 49);
            this.btn7CreateFile.TabIndex = 7;
            this.btn7CreateFile.Text = "Create File";
            this.btn7CreateFile.UseVisualStyleBackColor = true;
            this.btn7CreateFile.Click += new System.EventHandler(this.btn7CreateFile_Click);
            // 
            // textBox2Name
            // 
            this.textBox2Name.Location = new System.Drawing.Point(197, 136);
            this.textBox2Name.Name = "textBox2Name";
            this.textBox2Name.Size = new System.Drawing.Size(100, 22);
            this.textBox2Name.TabIndex = 8;
            // 
            // textBox3Loc
            // 
            this.textBox3Loc.Location = new System.Drawing.Point(197, 217);
            this.textBox3Loc.Name = "textBox3Loc";
            this.textBox3Loc.Size = new System.Drawing.Size(100, 22);
            this.textBox3Loc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 384);
            this.Controls.Add(this.textBox3Loc);
            this.Controls.Add(this.textBox2Name);
            this.Controls.Add(this.btn7CreateFile);
            this.Controls.Add(this.btn5Read);
            this.Controls.Add(this.btn4Write);
            this.Controls.Add(this.btn3DepLoc);
            this.Controls.Add(this.btn2DepName);
            this.Controls.Add(this.btn1DepName);
            this.Controls.Add(this.btn6CreateFolder);
            this.Controls.Add(this.textBox1ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1ID;
        private System.Windows.Forms.Button btn6CreateFolder;
        private System.Windows.Forms.Button btn1DepName;
        private System.Windows.Forms.Button btn2DepName;
        private System.Windows.Forms.Button btn3DepLoc;
        private System.Windows.Forms.Button btn4Write;
        private System.Windows.Forms.Button btn5Read;
        private System.Windows.Forms.Button btn7CreateFile;
        private System.Windows.Forms.TextBox textBox2Name;
        private System.Windows.Forms.TextBox textBox3Loc;
    }
}

