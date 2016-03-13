using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic_Algorithm
{
    public partial class Form1 : Form
    {
        Genetic_Algorithm ga;

        public Form1()
        {
            InitializeComponent();

            Chromosone[] csones = new Chromosone[32];
            for (int i = 0; i < csones.Length; i++)
                csones[i] = MyChromosone.GetRandom();

            ga = new Genetic_Algorithm(csones, 50, .01);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ga.Next();
            appendText(ga.Log(3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                ga.Next();
            appendText(ga.Log(3));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                ga.Next();
            appendText(ga.Log(3));
        }

        private void appendText(string str)
        {
            richTextBox1.AppendText(str);
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }
    }
}
