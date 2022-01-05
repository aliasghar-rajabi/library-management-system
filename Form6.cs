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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Name")
                NameTextBox.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Family")
                NameTextBox.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
