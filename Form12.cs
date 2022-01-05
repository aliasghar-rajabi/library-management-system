using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace WindowsFormsApp1
{
    public partial class Form12 : Form
    {
        private void Show11()
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }
        public Form12()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show11));
            t.Start();
            this.Close();

            Form11 sec = new Form11();
            sec.Show();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            LibraryControler sc1 = new LibraryControler();
            FileImplamentaion fi1 = new FileImplamentaion(sc1);
            richTextBox1.Text = fi1.showBook();
        }
    }
}
