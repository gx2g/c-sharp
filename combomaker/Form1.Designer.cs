namespace ComboMaker
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
            this.animaForm1 = new AnimaForm();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBTN = new AnimaButton();
            this.createBTN = new AnimaButton();
            this.saveBTN = new AnimaButton();
            this.imprtBTN2 = new AnimaButton();
            this.imprtBTN1 = new AnimaButton();
            this.animaForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animaForm1
            // 
            this.animaForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.animaForm1.Controls.Add(this.listBox3);
            this.animaForm1.Controls.Add(this.listBox2);
            this.animaForm1.Controls.Add(this.listBox1);
            this.animaForm1.Controls.Add(this.label2);
            this.animaForm1.Controls.Add(this.label1);
            this.animaForm1.Controls.Add(this.closeBTN);
            this.animaForm1.Controls.Add(this.createBTN);
            this.animaForm1.Controls.Add(this.saveBTN);
            this.animaForm1.Controls.Add(this.imprtBTN2);
            this.animaForm1.Controls.Add(this.imprtBTN1);
            this.animaForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animaForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.animaForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.animaForm1.Location = new System.Drawing.Point(0, 0);
            this.animaForm1.Name = "animaForm1";
            this.animaForm1.Size = new System.Drawing.Size(545, 342);
            this.animaForm1.TabIndex = 0;
            this.animaForm1.Text = "COMBOMAKER";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(364, 50);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(167, 214);
            this.listBox3.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(187, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(169, 214);
            this.listBox2.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 214);
            this.listBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total:";
            // 
            // closeBTN
            // 
            this.closeBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBTN.ForeColor = System.Drawing.Color.White;
            this.closeBTN.ImageLocation = new System.Drawing.Point(30, 6);
            this.closeBTN.ImageSize = new System.Drawing.Size(14, 14);
            this.closeBTN.Location = new System.Drawing.Point(456, 6);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 7;
            this.closeBTN.Text = "x";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.createBTN.ImageLocation = new System.Drawing.Point(30, 6);
            this.createBTN.ImageSize = new System.Drawing.Size(14, 14);
            this.createBTN.Location = new System.Drawing.Point(12, 304);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(344, 23);
            this.createBTN.TabIndex = 6;
            this.createBTN.Text = "Create List";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.saveBTN.ImageLocation = new System.Drawing.Point(30, 6);
            this.saveBTN.ImageSize = new System.Drawing.Size(14, 14);
            this.saveBTN.Location = new System.Drawing.Point(362, 275);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(169, 23);
            this.saveBTN.TabIndex = 5;
            this.saveBTN.Text = "Save List";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // imprtBTN2
            // 
            this.imprtBTN2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imprtBTN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.imprtBTN2.ImageLocation = new System.Drawing.Point(30, 6);
            this.imprtBTN2.ImageSize = new System.Drawing.Size(14, 14);
            this.imprtBTN2.Location = new System.Drawing.Point(187, 275);
            this.imprtBTN2.Name = "imprtBTN2";
            this.imprtBTN2.Size = new System.Drawing.Size(169, 23);
            this.imprtBTN2.TabIndex = 4;
            this.imprtBTN2.Text = "Import List";
            this.imprtBTN2.UseVisualStyleBackColor = true;
            this.imprtBTN2.Click += new System.EventHandler(this.imprtBTN2_Click);
            // 
            // imprtBTN1
            // 
            this.imprtBTN1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imprtBTN1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.imprtBTN1.ImageLocation = new System.Drawing.Point(30, 6);
            this.imprtBTN1.ImageSize = new System.Drawing.Size(14, 14);
            this.imprtBTN1.Location = new System.Drawing.Point(12, 275);
            this.imprtBTN1.Name = "imprtBTN1";
            this.imprtBTN1.Size = new System.Drawing.Size(169, 23);
            this.imprtBTN1.TabIndex = 3;
            this.imprtBTN1.Text = "Import List";
            this.imprtBTN1.UseVisualStyleBackColor = true;
            this.imprtBTN1.Click += new System.EventHandler(this.imprtBTN1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 342);
            this.Controls.Add(this.animaForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.animaForm1.ResumeLayout(false);
            this.animaForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AnimaForm animaForm1;
        private AnimaButton createBTN;
        private AnimaButton saveBTN;
        private AnimaButton imprtBTN2;
        private AnimaButton imprtBTN1;
        private AnimaButton closeBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

