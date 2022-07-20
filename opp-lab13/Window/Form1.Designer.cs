namespace Window
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.архивацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заархивироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розархивироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розшифроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox_point = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.архивацияToolStripMenuItem,
            this.шифрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ВідкритьToolStripMenuItem_Click);
            // 
            // архивацияToolStripMenuItem
            // 
            this.архивацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заархивироватьToolStripMenuItem,
            this.розархивироватьToolStripMenuItem});
            this.архивацияToolStripMenuItem.Name = "архивацияToolStripMenuItem";
            this.архивацияToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.архивацияToolStripMenuItem.Text = "Архівація";
            // 
            // заархивироватьToolStripMenuItem
            // 
            this.заархивироватьToolStripMenuItem.Name = "заархивироватьToolStripMenuItem";
            this.заархивироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.заархивироватьToolStripMenuItem.Text = "Архивировать";
            this.заархивироватьToolStripMenuItem.Click += new System.EventHandler(this.ЗаархівуватьToolStripMenuItem_Click);
            // 
            // розархивироватьToolStripMenuItem
            // 
            this.розархивироватьToolStripMenuItem.Name = "розархивироватьToolStripMenuItem";
            this.розархивироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.розархивироватьToolStripMenuItem.Text = "Разархивировать";
            this.розархивироватьToolStripMenuItem.Click += new System.EventHandler(this.РозархівуватиToolStripMenuItem_Click);
            // 
            // шифрToolStripMenuItem
            // 
            this.шифрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зашифроватьToolStripMenuItem,
            this.розшифроватьToolStripMenuItem});
            this.шифрToolStripMenuItem.Name = "шифрToolStripMenuItem";
            this.шифрToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.шифрToolStripMenuItem.Text = "Шифрування";
            // 
            // зашифроватьToolStripMenuItem
            // 
            this.зашифроватьToolStripMenuItem.Name = "зашифроватьToolStripMenuItem";
            this.зашифроватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зашифроватьToolStripMenuItem.Text = "Зашифровать";
            this.зашифроватьToolStripMenuItem.Click += new System.EventHandler(this.ЗашифруватьToolStripMenuItem_Click);
            // 
            // розшифроватьToolStripMenuItem
            // 
            this.розшифроватьToolStripMenuItem.Name = "розшифроватьToolStripMenuItem";
            this.розшифроватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.розшифроватьToolStripMenuItem.Text = "Розшифровать";
            this.розшифроватьToolStripMenuItem.Click += new System.EventHandler(this.РозшифруватьToolStripMenuItem_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BackColor = System.Drawing.Color.White;
            this.listBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(13, 78);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(775, 276);
            this.listBox.TabIndex = 1;
            this.listBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // textBox_point
            // 
            this.textBox_point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_point.BackColor = System.Drawing.Color.White;
            this.textBox_point.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_point.Location = new System.Drawing.Point(577, 39);
            this.textBox_point.Name = "textBox_point";
            this.textBox_point.Size = new System.Drawing.Size(211, 25);
            this.textBox_point.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(525, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Стан:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_point);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Окно для роботы с файлами";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem архивацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заархивироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розархивироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розшифроватьToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBox_point;
        private System.Windows.Forms.Label label1;
    }
}

