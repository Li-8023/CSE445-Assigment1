using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.ServiceReference1;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            
            //get the input info
            String input = textBox_input.Text;
            stringStatistics statistic = myClient.analyzerStr(input);

            textBox_vowel.Text = Convert.ToString(statistic.Vowel);
            textBox_upper.Text = Convert.ToString(statistic.Uppercase);
            textBox_numWords.Text = Convert.ToString(myClient.wordCount(input));
        }
    }
}
