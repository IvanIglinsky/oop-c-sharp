namespace TravelForm
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
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.radioButtonZima = new System.Windows.Forms.RadioButton();
            this.Summ = new System.Windows.Forms.Button();
            this.checkBoxGid = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonLito = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть країну :";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Болгарія",
            "Німеччина",
            "Польща"});
            this.comboBoxCountry.Location = new System.Drawing.Point(250, 92);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(211, 39);
            this.comboBoxCountry.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(61, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість днів:";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDay.Location = new System.Drawing.Point(250, 44);
            this.textBoxDay.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(87, 38);
            this.textBoxDay.TabIndex = 3;
            // 
            // radioButtonZima
            // 
            this.radioButtonZima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonZima.AutoSize = true;
            this.radioButtonZima.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonZima.Location = new System.Drawing.Point(556, 113);
            this.radioButtonZima.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonZima.Name = "radioButtonZima";
            this.radioButtonZima.Size = new System.Drawing.Size(88, 35);
            this.radioButtonZima.TabIndex = 5;
            this.radioButtonZima.Text = "Зима";
            this.radioButtonZima.UseVisualStyleBackColor = false;
            // 
            // Summ
            // 
            this.Summ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Summ.Location = new System.Drawing.Point(486, 222);
            this.Summ.Margin = new System.Windows.Forms.Padding(5);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(186, 45);
            this.Summ.TabIndex = 6;
            this.Summ.Text = "Розрахувати";
            this.Summ.UseVisualStyleBackColor = true;
            this.Summ.Click += new System.EventHandler(this.Summ_Click);
            // 
            // checkBoxGid
            // 
            this.checkBoxGid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxGid.AutoSize = true;
            this.checkBoxGid.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGid.Location = new System.Drawing.Point(32, 150);
            this.checkBoxGid.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxGid.Name = "checkBoxGid";
            this.checkBoxGid.Size = new System.Drawing.Size(473, 35);
            this.checkBoxGid.TabIndex = 7;
            this.checkBoxGid.Text = "Послуга індивідуального гіда(50 $ в день)";
            this.checkBoxGid.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(213, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(61, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вартість :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(322, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Виконав: Іглінський Іван ІПЗ-21-4";
            // 
            // radioButtonLito
            // 
            this.radioButtonLito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLito.AutoSize = true;
            this.radioButtonLito.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonLito.Checked = true;
            this.radioButtonLito.Location = new System.Drawing.Point(556, 58);
            this.radioButtonLito.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonLito.Name = "radioButtonLito";
            this.radioButtonLito.Size = new System.Drawing.Size(78, 35);
            this.radioButtonLito.TabIndex = 4;
            this.radioButtonLito.TabStop = true;
            this.radioButtonLito.Text = "Літо";
            this.radioButtonLito.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 336);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxGid);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.radioButtonZima);
            this.Controls.Add(this.radioButtonLito);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Тур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCountry;
        private Label label2;
        private TextBox textBoxDay;
        private RadioButton radioButtonZima;
        private Button Summ;
        private CheckBox checkBoxGid;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButtonLito;
    }
}