namespace Array1DWinForms
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
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_gen = new System.Windows.Forms.Button();
            this.button2_roz = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxRoz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.CausesValidation = false;
            this.numericUpDownCount.Location = new System.Drawing.Point(249, 38);
            this.numericUpDownCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(181, 31);
            this.numericUpDownCount.TabIndex = 0;
            this.numericUpDownCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(17, 493);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виконав: Іглінський І.Ю., група ІПЗ-21-4(2)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1_gen
            // 
            this.button1_gen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_gen.Location = new System.Drawing.Point(438, 34);
            this.button1_gen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1_gen.Name = "button1_gen";
            this.button1_gen.Size = new System.Drawing.Size(149, 39);
            this.button1_gen.TabIndex = 2;
            this.button1_gen.Text = "Генерувати";
            this.button1_gen.UseVisualStyleBackColor = true;
            this.button1_gen.Click += new System.EventHandler(this.button1_gen_Click);
            // 
            // button2_roz
            // 
            this.button2_roz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2_roz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_roz.Location = new System.Drawing.Point(595, 34);
            this.button2_roz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2_roz.Name = "button2_roz";
            this.button2_roz.Size = new System.Drawing.Size(149, 39);
            this.button2_roz.TabIndex = 3;
            this.button2_roz.Text = "Розв\'язати";
            this.button2_roz.UseVisualStyleBackColor = true;
            this.button2_roz.Click += new System.EventHandler(this.button2_roz_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Location = new System.Drawing.Point(46, 83);
            this.dataGridViewArray.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.ReadOnly = true;
            this.dataGridViewArray.RowHeadersWidth = 51;
            this.dataGridViewArray.RowTemplate.Height = 29;
            this.dataGridViewArray.Size = new System.Drawing.Size(698, 339);
            this.dataGridViewArray.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(1, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кількість елементів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(134, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сортувати масив до від\'ємних ->";
            // 
            // TextBoxRoz
            // 
            this.TextBoxRoz.Location = new System.Drawing.Point(548, 434);
            this.TextBoxRoz.Name = "TextBoxRoz";
            this.TextBoxRoz.Size = new System.Drawing.Size(196, 31);
            this.TextBoxRoz.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 533);
            this.Controls.Add(this.TextBoxRoz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.button2_roz);
            this.Controls.Add(this.button1_gen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCount);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №4. Завдання 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownCount;
        private Label label1;
        private Button button1_gen;
        private Button button2_roz;
        private DataGridView dataGridViewArray;
        private Label label2;
        private Label label3;
        private TextBox TextBoxRoz;
    }
}