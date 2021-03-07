namespace lab1calculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnequals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(47, 28);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(170, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(47, 76);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(28, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(189, 105);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(28, 23);
            this.btnminus.TabIndex = 2;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.Btnminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(189, 76);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(28, 23);
            this.btnplus.TabIndex = 3;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.Btnplus_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(115, 163);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(28, 23);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // btndecimal
            // 
            this.btndecimal.Location = new System.Drawing.Point(81, 163);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(28, 23);
            this.btndecimal.TabIndex = 5;
            this.btndecimal.Text = ".";
            this.btndecimal.UseVisualStyleBackColor = true;
            this.btndecimal.Click += new System.EventHandler(this.Btndecimal_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(47, 163);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(28, 23);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(115, 134);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(28, 23);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(81, 134);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(28, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(47, 134);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(28, 23);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(115, 105);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(28, 23);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(81, 105);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(28, 23);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(47, 105);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(28, 23);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(115, 76);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(28, 23);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(81, 76);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(28, 23);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(189, 163);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(28, 23);
            this.btndivide.TabIndex = 15;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.Btndivide_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(189, 134);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(28, 23);
            this.btnmultiply.TabIndex = 16;
            this.btnmultiply.Text = "x";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.Btnmultiply_Click);
            // 
            // btnequals
            // 
            this.btnequals.Location = new System.Drawing.Point(155, 76);
            this.btnequals.Name = "btnequals";
            this.btnequals.Size = new System.Drawing.Size(28, 23);
            this.btnequals.TabIndex = 17;
            this.btnequals.Text = "=";
            this.btnequals.UseVisualStyleBackColor = true;
            this.btnequals.Click += new System.EventHandler(this.Btnequals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 226);
            this.Controls.Add(this.btnequals);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btndecimal);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btnequals;
    }
}

