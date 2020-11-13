using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUImage2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowsState = FormWindowState.Maximized;
            TopMost = true;
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();
            userControl11.Hide();
            userControl31.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl31.Show();
            userControl31.BringToFront();
            userControl21.Hide();
            userControl11.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();
            userControl11.Hide();
            userControl31.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userControl31.Show();
            userControl31.BringToFront();
            userControl21.Hide();
            userControl11.Hide();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }
    }
}
