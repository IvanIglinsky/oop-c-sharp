using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ClassLibrary;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Compression;

namespace Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < files.Length; i++)
                listBox.Items.Add(System.IO.Path.GetFileName(files[i]));
        }

        DESCryptoServiceProvider sSecretKey;

        private void ВідкритьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                textBox_point.Text = "Помилка, файл не відкритий";
                textBox_point.ForeColor = Color.Red;
                return;
            }
            string filename = openFileDialog.FileName;
            string file_specname = System.IO.Path.GetFileName(filename);
            textBox_point.Text = "Файл відкритий";
            textBox_point.ForeColor = Color.Green;
            listBox.Items.Add("Шлях: " + filename);
            listBox.Items.Add("Ім'я файла: " + file_specname);
        }

        private void ЗашифруватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sSecretKey = EncryptDecrypt.GenerateKey();

            GCHandle gch = GCHandle.Alloc(sSecretKey.Key, GCHandleType.Pinned);

            EncryptDecrypt.EncryptFile(openFileDialog.FileName, @"E:\GitLabOOP\opp-lab13\Encrypted.txt.crypt", sSecretKey);

            gch.Free();
        }

        private void РозшифруватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptDecrypt.DecryptFile(@"E:\GitLabOOP\opp-lab13\Encrypted.txt.crypt", @"E:\GitLabOOP\opp-lab13\Decrypted.txt", sSecretKey);

        }

        private void ЗаархівуватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream sourceStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(@"E:\GitLabOOP\opp-lab13\compressed.gzar"))
                {
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        private void РозархівуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream sourceStream = new FileStream(@"E:\GitLabOOP\opp-lab13\compressed.gzar", FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(@"E:\GitLabOOP\opp-lab13\decompress.txt"))
                {
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                    }
                }
            }
        }
    }
}
