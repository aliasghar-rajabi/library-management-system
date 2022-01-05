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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Show2()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show2));
            t.Start();
            this.Close();

            Form2 sec = new Form2();
            sec.Show();
        }

        private void loan_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == string.Empty && textBox2.Text == string.Empty )
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
                richTextBox1.Text = fi14.loan(barcode,id);
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
