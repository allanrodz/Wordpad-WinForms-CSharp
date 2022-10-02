using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ofd.Title = "Open My Files";
            ofd.Filter = "All Files|*.*|Text Files|*.txt";
            ofd.InitialDirectory = @"C:\";


            if(ofd.ShowDialog() == DialogResult.OK)
            {

                rtb.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = ofd.FileName;





        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Title = "Save Files";
            sfd.Filter = "All Files|*.*|Text Files|*.txt";
            sfd.InitialDirectory = @"C:\";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                rtb.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);

            }
            this.Text = sfd.FileName;

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetup.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printD.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = rtb.Font;
            fd.ShowDialog();
            rtb.Font = fd.Font;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
