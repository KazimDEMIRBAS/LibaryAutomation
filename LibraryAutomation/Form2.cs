using System;
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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 parametredenGelenForm1)
        {
            InitializeComponent();
            form1 = parametredenGelenForm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.kitapEkle(textBox2.Text);
            form1.Show();
            this.Close();
        }
    }
}
