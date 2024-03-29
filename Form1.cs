﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random random = new Random();
            
            int y = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[y];
            double min = 1000; double max = 0;
            int index_min = 0; int index_max = 0;

            double soucet = 0;

            for (int x = 0;x<y;++x)
            {   

                pole[x] = random.NextDouble() * (1000 - 1) + 1;
                listBox1.Items.Add(pole[x].ToString("F2"));
                
                if(pole[x] > max)
                {
                    max = pole[x];
                    index_max = x;
                }

                if (pole[x] < min)
                {
                    min = pole[x];
                    index_min = x;
                }
                soucet += pole[x];

            }

            pole[index_min] = max;
            pole[index_max] = min;

            soucet -= (max + min);

            

            

            for(int x = 0;x<y;++x)
            {

                listBox2.Items.Add(pole[x].ToString("F2"));
            }
            
            
            label1.Text = "Max = " + max.ToString("F2");
            label2.Text = "Min = " + min.ToString("F2");

            if (y == 0) label5.Text = "Prumer bez MIN a MAX nelze vypocitat";
            else label5.Text = "Prumer bez MIN a MAX je " + (soucet / (double)(y-2)).ToString("F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random random = new Random();

            int y = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[y];

           for(int x = 0; x<y;++x)
           {
                pole[x] = random.NextDouble() * (1000 - 1) + 1;
                listBox1.Items.Add(pole[x].ToString("F2"));
            }

            double max = pole.Max();
            double min = pole.Min();
            double soucet = pole.Sum() - (max + min);

            int pozice_min = Array.IndexOf(pole, min);
            int pozice_max = Array.IndexOf(pole, max);

            pole[pozice_max] = min;
            pole[pozice_min] = max;

            for (int x = 0; x < y; ++x)
            {
                listBox2.Items.Add(pole[x].ToString("F2"));
            }


            label1.Text = "Max = " + max.ToString("F2");
            label2.Text = "Min = " + min.ToString("F2");

            if (pole.Length == 0) label5.Text = "Prumer bez MIN a MAX nelze vypocitat";
            else label5.Text = "Prumer bez MIN a MAX je " + (soucet / (double)(pole.Length-2)).ToString("F2");

        }
    }
}
