using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void Show12()
        {
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }
        private void Show14()
        {
            Form14 f14 = new Form14();
            f14.ShowDialog();
        }
        private void Show13()
        {
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void Book_Search_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show14));
            t.Start();
            this.Close();

            Form14 sec = new Form14();
            sec.Show();
        }

        private void Dispaly_Book_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show12));
            t.Start();
            this.Close();

            Form12 sec = new Form12();
            sec.Show();
        }

        private void Book_loan_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show13));
            t.Start();
            this.Close();

            Form13 sec = new Form13();
            sec.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
