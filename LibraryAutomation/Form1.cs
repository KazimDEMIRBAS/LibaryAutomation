namespace LibraryAutomation
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void l�STELEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 kitapEklemeEkrani = new Form2(this);
            kitapEklemeEkrani.Show();
            this.Hide();
        }

        public void kitapEkle(string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Silmek �stedi�inizden Emin misiniz?", @"Uyar�",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("G�ncellemek i�in herhangi bir isim se�iniz");
            }
            else
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.Insert(index, textBox1.Text);
            }
        }

        private void �yeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 uyeEkleScreen = new Form3(this);
            uyeEkleScreen.Show();
            this.Hide();
        }

        private void �yeleriD�zenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}