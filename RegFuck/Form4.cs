using System;
using System.Windows.Forms;

namespace RegFuck
{
    public partial class Form4 : Form
    {
        public static double hkcr = 1;
        public static double hku = 0.07;
        public static double hklm = 0.5;
        public static double del = 0.02;

        public static int seed = new Random().Next();

        public Form4()
        {
            InitializeComponent();

            textBox1.Text = seed.ToString();

            trackBar1.Value = (int)(hkcr * 100);
            label2.Text = trackBar1.Value + "%";

            trackBar2.Value = (int)(hku * 100);
            label4.Text = trackBar2.Value + "%";

            trackBar3.Value = (int)(hklm * 100);
            label6.Text = trackBar3.Value + "%";

            trackBar4.Value = (int)(del * 100);
            label8.Text = trackBar4.Value + "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            hkcr = trackBar1.Value / 100.0;
            label2.Text = trackBar1.Value + "%";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            hku = trackBar2.Value / 100.0;
            label4.Text = trackBar2.Value + "%";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            hklm = trackBar3.Value / 100.0;
            label6.Text = trackBar3.Value + "%";
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            del = trackBar4.Value / 100.0;
            label8.Text = trackBar4.Value + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = new Random().Next().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out seed))
                seed = textBox1.Text.GetHashCode();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6__Click(object sender, EventArgs e)
        {

        }

        private void label1__Click(object sender, EventArgs e)
        {

        }

        private void label4__Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
