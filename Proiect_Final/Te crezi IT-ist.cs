using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proiect_Final
{
    public partial class Te_crezi_IT_ist : Form
    {
        public Te_crezi_IT_ist()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            label3.Text = "Te crezi IT-ist?";
            label3.ForeColor = Color.White;
            label3.Visible = true;
            panel1.BackColor = Color.DimGray;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            label2.Visible = false;
            
            
           
        }

        private void Te_crezi_IT_ist_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\book\Util\log.txt");

            string a = sr.ReadLine();
            string s = sr.ReadLine();
            label6.Text = a;
            label7.Text = s;
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            label3.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\book\Util\level.txt");
            sw.WriteLine("1");
            sw.Close();
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\book\Util\level.txt");
            sw.WriteLine("2");
            sw.Close();
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\book\Util\level.txt");
            sw.WriteLine("3");
            sw.Close();
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
