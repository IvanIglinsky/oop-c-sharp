namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.TextBoxH = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(41, 68);
            this.TextBoxA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(116, 34);
            this.TextBoxA.TabIndex = 0;
            // 
            // TextBoxH
            // 
            this.TextBoxH.Location = new System.Drawing.Point(41, 282);
            this.TextBoxH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxH.Name = "TextBoxH";
            this.TextBoxH.Size = new System.Drawing.Size(116, 34);
            this.TextBoxH.TabIndex = 1;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(266, 68);
            this.TextBoxB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(114, 34);
            this.TextBoxB.TabIndex = 2;
            // 
            // TextBoxR
            // 
            this.TextBoxR.Location = new System.Drawing.Point(414, 55);
            this.TextBoxR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxR.Multiline = true;
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.Size = new System.Drawing.Size(420, 420);
            this.TextBoxR.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введіть крок h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(429, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Введіть проміжок [a ,b]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Табулювання";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(690, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = " Лабораторна робота №1.Виконав: Іглінський І.Ю., група ІПЗ-21-4(2)";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 585);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxR);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.TextBoxH);
            this.Controls.Add(this.TextBoxA);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private TextBox TextBoxA;
        private TextBox TextBoxH;
        private TextBox TextBoxB;
        private TextBox TextBoxR;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
    }
}