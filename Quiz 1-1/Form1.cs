using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            author1.Text = " ";
            author2.Text = " ";
            author3.Text = " ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void authors_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonauthor1_Click(object sender, EventArgs e)
        {
            author1.Text = "Margaret Mitchell";
            author2.Text = " ";
            author3.Text = " ";
        }

        private void buttonauthor2_Click(object sender, EventArgs e)
        {
            author2.Text = "Alex Haley";
            author1.Text = " ";
            author3.Text = " ";
        }

        private void buttonauthor3_Click(object sender, EventArgs e)
        {
            author3.Text = "Ayn Rand";
            author1.Text = " ";
            author2.Text = " ";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
