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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void Show2()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            LibraryControler sc1 = new LibraryControler();
            FileImplamentaion fi1 = new FileImplamentaion(sc1);
            richTextBox1.Text = fi1.report();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Show2));
            t.Start();
            this.Close();

            Form2 sec = new Form2();
            sec.Show();
        }
    }
}
