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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        private void Show11()
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }
        private void loan_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter full information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LibraryControler sc14 = new LibraryControler();
                FileImplamentaion fi14 = new FileImplamentaion(sc14);
                string barcode;
                string id;
                id = textBox2.Text;
                barcode = textBox1.Text;
                richTextBox1.Text = fi14.loan(barcode, id);
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show11));
            t.Start();
            this.Close();

            Form11 sec = new Form11();
            sec.Show();
        }
    }
}
