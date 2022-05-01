namespace Arrays2DWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.button2_roz = new System.Windows.Forms.Button();
            this.button1_gen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_N = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_M = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewSum = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(-510, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Виконав: Іглінський І.Ю., група ІПЗ-21-4(2)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxSum.Location = new System.Drawing.Point(488, 490);
            this.TextBoxSum.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.Size = new System.Drawing.Size(139, 31);
            this.TextBoxSum.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(15, 493);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Максимальна сума ->";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Кількість стовпців(n)";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(15, 150);
            this.dataGridViewMatrix.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.RowHeadersWidth = 51;
            this.dataGridViewMatrix.RowTemplate.Height = 29;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(614, 252);
            this.dataGridViewMatrix.TabIndex = 14;
            // 
            // button2_roz
            // 
            this.button2_roz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2_roz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_roz.Location = new System.Drawing.Point(471, 65);
            this.button2_roz.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2_roz.Name = "button2_roz";
            this.button2_roz.Size = new System.Drawing.Size(156, 39);
            this.button2_roz.TabIndex = 13;
            this.button2_roz.Text = "Розв\'язати";
            this.button2_roz.UseVisualStyleBackColor = true;
            this.button2_roz.Click += new System.EventHandler(this.button2_roz_Click);
            // 
            // button1_gen
            // 
            this.button1_gen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_gen.Location = new System.Drawing.Point(471, 17);
            this.button1_gen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1_gen.Name = "button1_gen";
            this.button1_gen.Size = new System.Drawing.Size(156, 41);
            this.button1_gen.TabIndex = 12;
            this.button1_gen.Text = "Генерувати";
            this.button1_gen.UseVisualStyleBackColor = true;
            this.button1_gen.Click += new System.EventHandler(this.button1_gen_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(191, 546);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Виконав: Іглінський І.Ю., група ІПЗ-21-4(2)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // numericUpDown_N
            // 
            this.numericUpDown_N.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_N.CausesValidation = false;
            this.numericUpDown_N.Location = new System.Drawing.Point(211, 17);
            this.numericUpDown_N.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.numericUpDown_N.Name = "numericUpDown_N";
            this.numericUpDown_N.Size = new System.Drawing.Size(210, 31);
            this.numericUpDown_N.TabIndex = 10;
            this.numericUpDown_N.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(14, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Кількість рядків(m)";
            // 
            // numericUpDown_M
            // 
            this.numericUpDown_M.Location = new System.Drawing.Point(211, 65);
            this.numericUpDown_M.Name = "numericUpDown_M";
            this.numericUpDown_M.Size = new System.Drawing.Size(210, 31);
            this.numericUpDown_M.TabIndex = 19;
            this.numericUpDown_M.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dataGridViewSum
            // 
            this.dataGridViewSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSum.Location = new System.Drawing.Point(12, 437);
            this.dataGridViewSum.Name = "dataGridViewSum";
            this.dataGridViewSum.RowHeadersWidth = 51;
            this.dataGridViewSum.RowTemplate.Height = 29;
            this.dataGridViewSum.Size = new System.Drawing.Size(615, 46);
            this.dataGridViewSum.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(15, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Сума елементів кожного стовпця";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 579);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewSum);
            this.Controls.Add(this.numericUpDown_M);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.button2_roz);
            this.Controls.Add(this.button1_gen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_N);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3 Завдання 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TextBoxSum;
        private Label label3;
        private Label label2;
        private DataGridView dataGridViewMatrix;
        private Button button2_roz;
        private Button button1_gen;
        private Label label4;
        private NumericUpDown numericUpDown_N;
        private Label label5;
        private NumericUpDown numericUpDown_M;
        private DataGridView dataGridViewSum;
        private Label label6;
    }
}