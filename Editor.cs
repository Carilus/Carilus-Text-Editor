using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace Cailus_Text_Editor
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sread = new StreamReader(openFileDialog.FileName);
                txtEditor.Text = sread.ReadToEnd();
                sread.Close();
               
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Text Files (.txt)|*.txt";
            svd.Title = "Save file.....";
            if(svd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(svd.FileName);
                writer.Write(txtEditor.Text);
                writer.Close();
            }
        }
       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Text Files (.txt)|*.txt";
            svd.Title = "Save file.....";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(svd.FileName);
                writer.Write(txtEditor.Text);
                writer.Close();
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "File";
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if(printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog1.Font;
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.ShowDialog();

        
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Later
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
