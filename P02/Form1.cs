using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();

            int[] pole = new int[n];

            if(radioButton1.Checked == true)
            {

                for(int x = 0; x<n;x++)
                {
                    pole[x] = rnd.Next(1, 11);
                    listBox1.Items.Add(pole[x]);
                }

                Array.Sort(pole);
                Array.Reverse(pole);

                for (int x = 0; x < n; x++)
                {
                    listBox2.Items.Add(pole[x]);
                }

            }

            else 
            {

                for (int x = 0; x < n; x++)
                {
                    pole[x] = rnd.Next(1, 11);
                    listBox1.Items.Add(pole[x]);
                }

                Array.Sort(pole);
                

                for (int x = 0; x < n; x++)
                {
                    listBox2.Items.Add(pole[x]);
                }

            }
        }

    }
}
