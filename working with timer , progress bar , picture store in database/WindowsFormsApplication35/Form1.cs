using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication35
{
    public partial class Form1 : Form
    {
        int st = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text !="")
            {
                MessageBox.Show("ok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(open.FileName);
                textBox1.Text = open.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            st++;
            this.progressBar1.Increment(1);
           if(st == 100)
           {
               timer1.Stop();
               progressBar1.Hide();
               MessageBox.Show("sucess");
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
