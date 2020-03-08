using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            
            CountFiveSeconds();
            textBox1.Text += "Waiting for method" + Environment.NewLine;
            textBox1.Text += "Made changes from laptop" + Environment.NewLine;
            
        }

        private async Task CountFiveSeconds()
        {
            textBox1.Text = "Counting to Three" + Environment.NewLine;
            string text = await Task.Run(() => DoTheSleep(3));
            textBox1.Text += text;

        }

        private String DoTheSleep(int i)
        {
            for (int a = 0; a < i; a++)
            {
                System.Threading.Thread.Sleep(1000);

            }
            return "Done";
        }
    }
}
