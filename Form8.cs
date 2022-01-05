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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Show2()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void Form8_Load(object sender, EventArgs e)
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

        private void Search_Click(object sender, EventArgs e)
        {
            LibraryControler sc13 = new LibraryControler();
            FileImplamentaion fi13 = new FileImplamentaion(sc13);
            string id;
            id = textBox1.Text;
            richTextBox1.Text =  fi13.SerechUser(id);
            textBox1.Text = string.Empty;
        }
    }
}
