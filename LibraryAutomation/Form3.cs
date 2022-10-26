﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Form3 : Form
    {
        Form1 form1;
        
        

        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Silmek İstediğinizden Emin misiniz?", @"Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
