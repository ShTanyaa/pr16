using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prakt15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void изменитьАдресОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            button1.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            string[] znach = new string[4];
            znach = listBox1.Items[i].ToString().Split(' ');
            textBox1.Text = znach[0]+" "+ znach[1]+ " "+znach[2]+" "+ znach[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("t.txt");
            string line;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                listBox1.Items.Add(line);
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
