using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection = chkbds.CheckedIndices;
            String check = " ";
            foreach (int i in indexCollection)
            {
                check += i + " ";
            }
            MessageBox.Show(" " + check);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedItemCollection = chkbds.CheckedItems;
            String check = " ";
            foreach (String i in checkedItemCollection)
            {
                check += i + " ";
            }
            MessageBox.Show(" " + check);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String check = " ";
            for (int i = 0; i < chkbds.Items.Count; i++)

            {
                if (chkbds.GetItemChecked(i))
                {
                    check += chkbds.Items[i] + " ";
                }
            }
            MessageBox.Show(" " + check);
        }

        private void btntrai_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chkbtrai.CheckedItems;
            foreach (String item in items)
            {
                cchkbphai.Items.Add(item);
               // chkbtrai.Items.Remove(item);
            }
            foreach (String s in cchkbphai.Items)
            {
                chkbtrai.Items.Remove(s);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cchkbphai.Items.AddRange(chkbtrai.Items);
            chkbtrai.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = cchkbphai.CheckedItems;
            foreach (String item in items)
            {
                chkbtrai.Items.Add(item);
                // chkbtrai.Items.Remove(item);
            }
            foreach (String s in chkbtrai.Items)
            {
                cchkbphai.Items.Remove(s);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chkbtrai.Items.AddRange(cchkbphai.Items);
            cchkbphai.Items.Clear();
        }

        private void mnufile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnufileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Blue;
        }

        private void btncreat_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(501).ToString();
                flowLayoutPanel1.Controls.Add(btn);
                btn.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void mnufileOpen_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            //frm.ShowDialog(); // chỉ khi tắt form con mới sd đc form cha
            frm.Show();
            this.Hide();
        }

        private void mnulifeNew_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnmo_Click(object sender, EventArgs e)
        {
            mnufileOpen.PerformClick();
        }

        private void tsbtnthoat_Click(object sender, EventArgs e)
        {
            mnufileExit.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
