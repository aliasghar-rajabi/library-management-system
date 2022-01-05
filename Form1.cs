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
    public partial class Form1 : Form
    {
        private object userTextbox;
        private object pasTextbox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user, pas;
            if (
                user = userTextbox.text;
            pas = pasTextbox.text;
            )
            new Form2().Show();
            else 
            MessageBox.Show("اطلاعات نادرست است");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
