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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        private void Show11()
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show11));
            t.Start();
            this.Close();

            Form11 sec = new Form11();
            sec.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            LibraryControler sc13 = new LibraryControler();
            FileImplamentaion fi13 = new FileImplamentaion(sc13);
            string barcode;
            barcode = textBox1.Text;
            richTextBox1.Text = fi13.SerechBook(barcode);
            textBox1.Text = string.Empty;
        }
    }
}
