namespace GlazedForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioButtonSingle = new System.Windows.Forms.RadioButton();
            this.RadioButtonDouble = new System.Windows.Forms.RadioButton();
            this.Windowsill = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Розмір вікна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина(см):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Висота(см):";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(170, 92);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(125, 34);
            this.textBoxWidth.TabIndex = 3;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(170, 134);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(125, 34);
            this.textBoxHeight.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Матеріал:";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Дерево",
            "Метал",
            "Металопластик"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(170, 180);
            this.comboBoxMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(184, 36);
            this.comboBoxMaterial.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(427, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Склопакет";
            // 
            // RadioButtonSingle
            // 
            this.RadioButtonSingle.AutoSize = true;
            this.RadioButtonSingle.Checked = true;
            this.RadioButtonSingle.Location = new System.Drawing.Point(427, 88);
            this.RadioButtonSingle.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonSingle.Name = "RadioButtonSingle";
            this.RadioButtonSingle.Size = new System.Drawing.Size(175, 32);
            this.RadioButtonSingle.TabIndex = 8;
            this.RadioButtonSingle.TabStop = true;
            this.RadioButtonSingle.Text = "Однокамерний";
            this.RadioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDouble
            // 
            this.RadioButtonDouble.AutoSize = true;
            this.RadioButtonDouble.Location = new System.Drawing.Point(427, 130);
            this.RadioButtonDouble.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonDouble.Name = "RadioButtonDouble";
            this.RadioButtonDouble.Size = new System.Drawing.Size(162, 32);
            this.RadioButtonDouble.TabIndex = 9;
            this.RadioButtonDouble.TabStop = true;
            this.RadioButtonDouble.Text = "Двокамерний";
            this.RadioButtonDouble.UseVisualStyleBackColor = true;
            // 
            // Windowsill
            // 
            this.Windowsill.AutoSize = true;
            this.Windowsill.Location = new System.Drawing.Point(427, 184);
            this.Windowsill.Margin = new System.Windows.Forms.Padding(4);
            this.Windowsill.Name = "Windowsill";
            this.Windowsill.Size = new System.Drawing.Size(136, 32);
            this.Windowsill.TabIndex = 10;
            this.Windowsill.Text = "Підвіконня";
            this.Windowsill.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(36, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Вартість:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(156, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(409, 258);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(217, 39);
            this.Calculate.TabIndex = 13;
            this.Calculate.Text = "Розрахувати";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Виконав: Іглінський Іван ІПЗ-21-4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 367);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Windowsill);
            this.Controls.Add(this.RadioButtonDouble);
            this.Controls.Add(this.RadioButtonSingle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Склопакет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private Label label4;
        private ComboBox comboBoxMaterial;
        private Label label5;
        private RadioButton RadioButtonSingle;
        private RadioButton RadioButtonDouble;
        private CheckBox Windowsill;
        private Label label6;
        private Label label7;
        private Button Calculate;
        private Label label8;
    }
}